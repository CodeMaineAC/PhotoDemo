using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


namespace PhotoDemo
{
    class FramedPhoto : Photo
    {
        private const double PREMIUM = 25.00;

        public string Style { get; set; }
        public string Material { get; set; }

        public override string ToString()
        {
            SetPrice(PREMIUM); //Set price here to make sure Width and Height have been set
            string text =
                string.Format("{0}    {1} X {2}  {3}, {4} frame Price: {5}"
                , GetType().ToString(), Width, Height, Style, Material,
                Price.ToString("C", CultureInfo.GetCultureInfo("en-US")));

            return text;
        }
    }
}
