namespace MobilePhoneDevice
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class GSM
    {
        //Problem 1. Define class
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        public Battery battery;
        public Display display;

        //Problem 4. ToString
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("Model: " + this.model);
            result.AppendLine("Manufacturer: " + this.manufacturer);
            result.AppendLine(string.Format(new System.Globalization.CultureInfo("en-US"), "Price: {0:C}", this.price));
            result.AppendLine("Owner: " + this.owner);
            result.AppendLine("Battery type: " + this.battery.TypeOfBattery);

            return result.ToString();
        }

        public GSM(string model, string manufacturer, decimal? price = null, string owner = null)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Price = price;
            this.Owner = owner;
            this.battery = new Battery();
            this.display = new Display();
        }

        //Problem 2. Constructors
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The manufacturer cannot be null");
                }
                this.manufacturer = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The model cannot be null");
                }
                this.model = value;
            }
        }

        public decimal? Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArithmeticException("Ivalid price");
                }
                this.price = value;
            }
        }

        public string Owner { get; private set; }
    }
}
