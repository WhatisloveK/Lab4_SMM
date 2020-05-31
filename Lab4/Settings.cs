    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Settings
    {
        public const int StartMetricDelay = 3000;

        public const double DEVICE_1_MU = 0.2,
                            DEVICE_2_TIME = 2 * TimeMeasure;

        public const int QUEUE_1_LIMIT = 3;
        public const int START_QUEUE_LIMIT = 1;

        public const int TimeMeasure = 10;

        private const double inputLambda = 0.2;

        public const int Delay = (int)((1.0 / inputLambda) * TimeMeasure);
    }

    public enum WorkMode
    {
        Intensity = 1,
        Time = 2
    }
}
