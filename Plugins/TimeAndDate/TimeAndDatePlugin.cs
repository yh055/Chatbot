using BasePlugin;
using BasePlugin.Interfaces;
using BasePlugin.Records;
using System;
using System.Collections.Generic;

namespace TimeAndDate
{
    public class TimeAndDatePlugin : IPlugin
    {
    

       

        public static string _Id = "TimeAndDate";
        public string Id => _Id;

        public PluginOutput Execute(PluginInput input)
        {
            DateTime currentTime = DateTime.Now;

            return new PluginOutput(currentTime.ToString());

        }

     
    }
}