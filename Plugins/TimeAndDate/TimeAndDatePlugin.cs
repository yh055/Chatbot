using BasePlugin;
using BasePlugin.Interfaces;
using BasePlugin.Records;
using System;
using System.Collections.Generic;

namespace TimeAndDate
{
    public class TimeAndDatePlugin : IPluginWithScheduler
    {
        IScheduler _scheduler;

        public TimeAndDatePlugin(IScheduler scheduler) => _scheduler = scheduler;

        public static string _Id = "TimeAndDate";
        public string Id => _Id;

        public PluginOutput Execute(PluginInput input)
        {
            DateTime currentTime = DateTime.Now;

            return new PluginOutput(currentTime);

        }

     
    }
}