using System;
using System.Collections.Generic;
using Umbraco.Core.Composing;

namespace JsonHW
{
    class Program
    {
        public static int Localtime_epoch { get; private set; }
        public static double Utc_offset { get; private set; }

        static void Main(string[] args)
        {
            var requestList = new List<Request>
            {
                new Request
                {
                    Type = "City",
                    Query = "Astana, Kazakhstan",
                    Language = "en",
                    Unit = "m"
                },
                new Location
                {
                    Name = "Astana",
                    Country = "Kazakhstan",
                    Region = "Astana",
                    Lat = 51.181,
                    Lon = 71.428,
                    Timezone_id = "Asia\/Almaty",
                    Locationtime = 2021-02-15 21:04,
                    Localtime_epoch = 1613423040,
                    Utc_offset = 6.0
                },
                new Current 
                {
                    Observation_time = 03:04 PM,
                    Temperature = -6,
                    Weather_code = 116,
                    Weather_icons = "https:\/\/assets.weatherstack.com\/images\/wsymbols01_png_64\/wsymbol_0004_black_low_cloud.png",
                    Weather_descriptions = "Partly cloudy",
                    Wind_speed = 19,
                    Wind_degree = 190,
                    Wind_dir = "S",
                    Pressure = 1018,
                    Precip = 0,
                    Humidity = 93,
                    Cloudcover = 50,
                    Feelslike = -12,
                    Uv_index = 1,
                    Visibility = 10,
                    Is_day = "no"
                }
            };
        }
    }
}
