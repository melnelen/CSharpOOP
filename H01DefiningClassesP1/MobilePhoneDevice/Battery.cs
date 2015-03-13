using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
    class Battery
    {
        //Problem 1. Define class
        private string batteryModel;
        private int? batteryHoursIdle;
        private int? batteryHoursTalk;

        //Problem 2. Constructors
        public string BatteryModel { get; private set; }

        public int? BatteryHoursIdle
        {
            get { return this.batteryHoursIdle; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid battery idle hours capacity!");
                }
                this.batteryHoursIdle = value;
            }
        }

        public int? BatteryHoursTalk
        {
            get { return this.batteryHoursTalk; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid battery talk hours capacity!");
                }
                this.batteryHoursTalk = value;
            }
        }

        //Problem 3. Enumeration
        public enum BatteryType
        {
            LiIon,
            NiMH,
            NiCd,
            Unknown
        }

        public BatteryType TypeOfBattery { get; private set; }
    }
}
