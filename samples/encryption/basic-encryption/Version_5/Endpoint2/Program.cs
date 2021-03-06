﻿using System;
using NServiceBus;

class Program
{
    static void Main()
    {
        var busConfiguration = new BusConfiguration();
        busConfiguration.EndpointName("Samples.Encryption.Endpoint2");
        busConfiguration.RijndaelEncryptionService();
        busConfiguration.UsePersistence<InMemoryPersistence>();
        var startableBus = Bus.Create(busConfiguration);
        using (startableBus.Start())
        {
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}