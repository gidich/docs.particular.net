﻿using System;
using log4net.Config;
using NServiceBus;
using NServiceBus.Log4Net;
using NServiceBus.Logging;

class Program
{

    static void Main()
    {
        #region ConfigureAppender
        var consoleAppender = new MyConsoleAppender
                              {
                                  Color = ConsoleColor.Green
                              };
        BasicConfigurator.Configure(consoleAppender);
        LogManager.Use<Log4NetFactory>();
        #endregion

        var busConfig = new BusConfiguration();
        busConfig.EndpointName("Samples.Log4Net.Appender");
        busConfig.UseSerialization<JsonSerializer>();
        busConfig.EnableInstallers();
        busConfig.UsePersistence<InMemoryPersistence>();

        using (var bus = Bus.Create(busConfig))
        {
            bus.Start();
            bus.SendLocal(new MyMessage());
            Console.WriteLine("\r\nPress any key to stop program\r\n");
            Console.ReadKey();
        }
    }
}
