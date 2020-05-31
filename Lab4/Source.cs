using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Lab4
{
    public class Source
    {
        private double customerCount;
        private double queue1Length;

        private CustomQueue queue1;

        private Device device11;
        private Device device12;
        private Device device2;

        private List<Customer> servedCustomers;

        private CustomQueue startQueue;

        private object loker = new object();

        private string queue1Name = "Queue1";

        public Source()
        {
            customerCount = 0;
            queue1Length = 0;
        }


        public void ExecuteAsync(CancellationToken stoppingToken)
        {
            void Init()
            {
                servedCustomers = new List<Customer>();

                queue1 = new CustomQueue(queue1Name, Settings.QUEUE_1_LIMIT, stoppingToken);

                startQueue = new CustomQueue("StartQueue", stoppingToken);

                device11 = new Device("Device11", Settings.DEVICE_1_MU, startQueue, x => queue1.MoveToQueue(x), WorkMode.Intensity);
                device12 = new Device("Device12", Settings.DEVICE_1_MU, startQueue, x => queue1.MoveToQueue(x), WorkMode.Intensity);
                device2 = new Device("Device2", Settings.DEVICE_2_TIME, queue1, x =>
                {
                    EndWork(x);
                }, WorkMode.Time);

            }

            Init();

            var thread1 = new Thread(() => device11.ExecuteAsync(stoppingToken));
            thread1.Name = "Device11";

            var thread2 = new Thread(() => device12.ExecuteAsync(stoppingToken));
            thread2.Name = "Device12";

            var thread3 = new Thread(() => device2.ExecuteAsync(stoppingToken));
            thread3.Name = "Device2";


            thread1.Start();
            thread2.Start();
            thread3.Start();

            int delayTime = Settings.Delay;
            int count = 0;
            while (!stoppingToken.IsCancellationRequested)
            {
                Customer customer = new Customer($"Customer {count}");
                customerCount++;

                customer.WriteToFile("Has been created");
                customer.CreateMessage("Has been created");

                if ((startQueue.Count >= Settings.START_QUEUE_LIMIT)||
                    (device11.IsBusy && device12.IsBusy))
                {
                    customer.WriteToFile("Has been rejected");
                    customer.CreateMessage("Has been rejected");
                    customer.IsRejected = true;

                    EndWork(customer);
                }
                else
                {
                    startQueue.MoveToQueue(customer);
                }

                Thread.Sleep(delayTime);
                count++;
            }
        }

        private void EndWork(Customer customer)
        {
            servedCustomers.Add(customer);
            customer.WriteToFile("End Work");
            customer.CreateMessage("End Work");

            lock (loker)
            {
                customer.WriteFinalMessage();
            }
        }

        public InformationDTO GetInformation()
        {
            double rejectionProcent = servedCustomers.Where(x => x.IsRejected).Count() / customerCount;
            queue1Length = queue1.AverageLentgth;

            var queue1AvrTimeAsReal = servedCustomers.Where(x => !x.IsRejected).Select(x => x.Timings[queue1Name]).Average();

            var queue1AvrTime = queue1.LengthOfQueuePerTime / servedCustomers.Count;//queue1.AllServed;

            var device11Loading = device11.DeviceLoading;
            var device12Loading = device12.DeviceLoading;
            var device2Loading = device2.DeviceLoading;

            return new InformationDTO()
            {
                RejectionProcent = rejectionProcent,
                Queue1AvrLength = queue1Length,
                Queue1AvrTime = queue1AvrTime,
                Queue1AvrTimeAsReal = queue1AvrTimeAsReal,
                Device11Loading = device11Loading,
                Device12Loading = device12Loading,
                Device2Loading = device2Loading
            };
        }
    }
}
