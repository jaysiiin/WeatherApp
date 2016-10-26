using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace WeatherApp1.Models
{
    public class Weather
    {
        public Object getWeatherForcast()
        {
            string url = "http://api.openweathermap.org/data/2.5/weather?q=Cleveland&APPID=ac5023b431549318bd42a0683808c501&units=imperial";
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }
    }
}