using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
    class Display
    {
        //Problem 1. Define class
        private double? size;
        private int? colors;

        public Display(double? size = null, int? numberOfColors = null)
        {
            this.Size = size;
            this.Colors = numberOfColors;
        }

        //Problem 2. Constructors
        public int? Colors
        {
            get { return this.colors; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid number of colors!");
                }
                this.colors = value;
            }
        }

        public double? Size
        {
            get { return this.size; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid size!");
                }
                this.size = value;
            }
        }
    }
}
