using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace PhotoDemo
{
    class Photo
    {
        private double width = 0;
        private double height = 0;
        protected double price;

        public double Width
        {
            get { return width; }
            set
            {
                width = value;
                SetPrice();
            }
        }

        public  double Height
        {
            get { return height; }
            set
            {
                height = value;
                SetPrice();
            }
        }

        public double Price
        {
            get { return price; }
        }


        protected void SetPrice(double premium = 0)
        {
            if(Width == 8 && Height == 10)
            {
                price = 3.99 + premium;
            }
            else if (Width == 10 && Height == 12)
            {
                price = 5.99 + premium;
            }
            else
            {
                price = 9.99 + premium;
            }
           
        }

        public override string ToString()
        {
            string text = 
                string.Format("{0}    {1} X {2}   Price: {3:c}"
                , GetType().ToString(), Width, Height, 
                Price.ToString("C",CultureInfo.GetCultureInfo("en-US")));

            return text;
        }


    }
}
