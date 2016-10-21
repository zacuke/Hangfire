﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Jobs
{
    /// <summary>
    /// generated by http://json2csharp.com/
    /// with the following text
    /// {"coord":{"lon":151.21,"lat":-33.87},"weather":[{"id":802,"main":"Clouds","description":"scattered clouds","icon":"03d"}],"base":"stations","main":{"temp":291.71,"pressure":1007,"humidity":52,"temp_min":290.25,"temp_max":292.59},"wind":{"speed":1.54,"deg":329,"gust":6.68},"rain":{},"clouds":{"all":48},"dt":1474511760,"sys":{"type":3,"id":55623,"message":0.0122,"country":"AU","sunrise":1474487077,"sunset":1474530697},"id":6619279,"name":"City of Sydney","cod":200}
    /// the json text can be retrieve from "http://api.openweathermap.org/data/2.5/weather?APPID=be357b55d043cf450620449e0e8b4d7c&id=6619279";
    /// </summary>
    [DataContract]
    public class OpenWeatherResult
    {
        [DataMember]
        public Coord coord { get; set; }
        [DataMember]
        public List<Weather> weather { get; set; }
        [DataMember]
        public string @base { get; set; }
        [DataMember]
        public Main main { get; set; }
        [DataMember]
        public Wind wind { get; set; }
        [DataMember]
        public Rain rain { get; set; }
        [DataMember]
        public Clouds clouds { get; set; }
        [DataMember]
        public int dt { get; set; }
        [DataMember]
        public Sys sys { get; set; }
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public int cod { get; set; }
    }

    public class Coord
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }

    [DataContract]
    public class Weather
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string main { get; set; }

        [DataMember]
        public string description { get; set; }

        [DataMember]
        public string icon { get; set; }
    }

    public class Main
    {
        public double temp { get; set; }
        public double pressure { get; set; }
        public double humidity { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
    }

    public class Wind
    {
        public double speed { get; set; }
        public double deg { get; set; }
        public double gust { get; set; }
    }

    public class Rain
    {
    }

    public class Clouds
    {
        public int all { get; set; }
    }

    public class Sys
    {
        public int type { get; set; }
        public int id { get; set; }
        public double message { get; set; }
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }
}