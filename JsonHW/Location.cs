using System;
using System.Collections.Generic;
using System.Text;

namespace JsonHW
{
    public class Location
    {
        public int request { get; set; }
        public int type { get; set; }
        public string query { get; set; }
        public string language { get; set; }
        public int unit { get; set; }
        public int location { get; set; }
        public string name { get; set; }
        public string Name { get; internal set; }
        public int country { get; set; }
        public string Country { get; internal set; }
        public int region { get; set; }
        public string Region { get; internal set; }
        public string lat { get; set; }
        public double Lat { get; internal set; }
        public string lon { get; set; }
        public double Lon { get; internal set; }
        public int timezone_id { get; set; }
        public string Timezone_id { get; internal set; }
        public int localtime { get; set; }
        public int localtime_epoch { get; set; }
        public string utc_offset { get; set; }
        public int current { get; set; }
        public int observation_time { get; set; }
        public int temperature { get; set; }
        public string weather_code { get; set; }
        public string weather_icons { get; set; }
        public string weather_descriptions { get; set; }
        public int wind_speed { get; set; }
        public int wind_degree { get; set; }
        public string wind_dir { get; set; }
        public int pressure { get; set; }
        public int precip { get; set; }
        public int humidity { get; set; }
        public int cloudcover { get; set; }
        public int feelslike { get; set; }
        public int uv_index { get; set; }
        public int visibility { get; set; }
        public string is_day { get; set; }
        public int Locationtime { get; internal set; }
    }
}
