using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace PhotoDemo
{
    class MattedPhoto : Photo
    {
        private const double PREMIUM = 10.00;
        private string color;

        public string Color
        {
            get { return color; }
            set
            {
                color = value;
                SetPrice(PREMIUM);
            }
        }

        public override string ToString()
        {
            SetPrice(PREMIUM); //Set price here to make sure Width and Height have been set
            string text =
                string.Format("{0}    {1} X {2}  {3} matting Price: {4}"
                , GetType().ToString(), Width, Height, Color,
                Price.ToString("C", CultureInfo.GetCultureInfo("en-US")));

            return text;
        }
  
    }
}
