---
title: Extensions
summary: A list of all extensions to NServiceBus including all community contributions and external integrations
---

This is a curated list of all the extensions to NServiceBus developed by both the community and Particular. To add an extension see [How to Contribute](https://github.com/Particular/docs.particular.net#how-to-contribute). If any extension has been abandoned and no longer maintained please [let us know](https://github.com/Particular/docs.particular.net/issues).

**<a href="http://particular.net/"><img src="particular-project.png"></a> Particular run project**

## Transports 

 * #### [AmazonSQS](https://github.com/ahofman/NServiceBus.AmazonSQS) <a href="http://www.nuget.org/packages/NServiceBus.AmazonSQS/"><img src="http://img.shields.io/nuget/v/NServiceBus.AmazonSQS.svg?" title="NuGet Status"></a>
 Provides support for sending messages over [Amazon SQS](http://aws.amazon.com/sqs/). 

 * #### [Azure Service Bus](/nservicebus/windows-azure-transport.md)  <a href="http://www.nuget.org/packages/NServiceBus.Azure.Transports.WindowsAzureServiceBus/"><img src="http://img.shields.io/nuget/v/NServiceBus.Azure.Transports.WindowsAzureServiceBus.svg?" title="NuGet Status"></a> <a href="http://particular.net/"><img src="particular-project.png" title="A Particular run project"></a>
 Provides support for sending messages over [Azure Service Bus](http://azure.microsoft.com/en-us/services/service-bus/).

 * #### [Azure Storage Queues](/nservicebus/windows-azure-transport.md) <a href="http://www.nuget.org/packages/NServiceBus.Azure.Transports.WindowsAzureStorageQueues/"><img src="http://img.shields.io/nuget/v/NServiceBus.Azure.Transports.WindowsAzureStorageQueues.svg?" title="NuGet Status"></a> <a href="http://particular.net/"><img src="particular-project.png" title="A Particular run project"></a>
 Provides support for sending messages over [Azure Storage Queue](http://azure.microsoft.com/en-us/documentation/articles/storage-dotnet-how-to-use-queues/).

 * #### [MSMQ](/nservicebus/msmqtransportconfig.md) <a href="http://www.nuget.org/packages/NServiceBus/"><img src="http://img.shields.io/nuget/v/NServiceBus.svg?" title="NuGet Status"></a> <a href="http://particular.net/"><img src="particular-project.png" title="A Particular run project"></a>
 Provides support for sending messages over [Microsoft Message Queuing (MSMQ)](https://msdn.microsoft.com/en-us/library/ms711472%28v=vs.85%29.aspx). This is the default transport in the NServiceBus core.

 * #### [OracleAQ](https://github.com/rosieks/NServiceBus.OracleAQ) <a href="http://www.nuget.org/packages/NServiceBus.OracleAQ/"><img src="http://img.shields.io/nuget/v/NServiceBus.OracleAQ.svg?" title="NuGet Status"></a>
 Provides support for sending messages over [Oracle Advanced Queuing (Oracle AQ)](http://docs.oracle.com/cd/B10500_01/appdev.920/a96587/qintro.htm).

 * #### [RabbitMQ](/nservicebus/rabbitmq/) <a href="http://www.nuget.org/packages/NServiceBus.RabbitMQ/"><img src="http://img.shields.io/nuget/v/NServiceBus.RabbitMQ.svg?" title="NuGet Status"></a> <a href="http://particular.net/"><img src="particular-project.png" title="A Particular run project"></a>
 Provides support for sending messages over [RabbitMQ](http://www.rabbitmq.com/) using the [RabbitMQ .net Client](http://www.nuget.org/packages/RabbitMQ.Client/).

 * #### [SqlServer](/nservicebus/sqlserver/) <a href="http://www.nuget.org/packages/NServiceBus.SqlServer/"><img src="http://img.shields.io/nuget/v/NServiceBus.SqlServer.svg?" title="NuGet Status"></a> <a href="http://particular.net/"><img src="particular-project.png" title="A Particular run project"></a>
 Provides support for sending messages over  [Microsoft Sql Server](http://www.microsoft.com/en-us/server-cloud/products/sql-server/) using SQL tables as the storage mechanism for messages.

## Serializers

 * #### JSON
 There are several implementation of [JSON](http://en.wikipedia.org/wiki/JSON) serializers.

  * #### [Core Json](/) <a href="http://www.nuget.org/packages/NServiceBus/"><img src="http://img.shields.io/nuget/v/NServiceBus.svg?" title="NuGet Status"></a> <a href="http://particular.net/"><img src="particular-project.png" title="A Particular run project"></a>
  Using an ILMeged copy of [Json.NET](http://www.newtonsoft.com/json) built into the NServiceBus core.

  * #### [External Json](/) <a href="http://www.nuget.org/packages/NServiceBus.Newtonsoft.Json/"><img src="http://img.shields.io/nuget/v/NServiceBus.Newtonsoft.Json.svg?" title="NuGet Status"></a>
  Using an external copy of [Json.NET](http://www.newtonsoft.com/json) so the full programmatic API of Json.NET can be leveraged.

  * #### [Jil](https://github.com/SimonCropp/NServiceBus.Jil) <a href="http://www.nuget.org/packages/NServiceBus.Jil/"><img src="http://img.shields.io/nuget/v/NServiceBus.Jil.svg?" title="NuGet Status"></a>
  The [Jil Project](https://github.com/kevin-montrose/Jil) is a fast JSON serializer built on [Sigil](https://github.com/kevin-montrose/Sigil) with a number of somewhat crazy optimization tricks.

 * #### [ProtoBuf](https://github.com/SimonCropp/NServiceBus.ProtoBuf) <a href="http://www.nuget.org/packages/NServiceBus.ProtoBuf/"><img src="http://img.shields.io/nuget/v/NServiceBus.ProtoBuf.svg?" title="NuGet Status"></a>
 [ProtoBuf](https://code.google.com/p/protobuf-net/) is [Googles](https://developers.google.com/protocol-buffers/) binary serializer designed to be small, fast and simple.

 * #### [MessagePack](https://github.com/SimonCropp/NServiceBus.MessagePack) <a href="http://www.nuget.org/packages/NServiceBus.MessagePack/"><img src="http://img.shields.io/nuget/v/NServiceBus.MessagePack.svg?" title="NuGet Status"></a>
 [MessagePack](http://msgpack.org/) is a binary serializer designed to be both compact and fast.

 * #### XML

  * #### [SystemXml](https://github.com/fhalim/NServiceBus.Serializers.SystemXml) <a href="http://www.nuget.org/packages/NServiceBus.Serializers.SystemXml/"><img src="http://img.shields.io/nuget/v/NServiceBus.Serializers.SystemXml.svg?" title="NuGet Status"></a>
Using the .net [System.Xml.Serialization](https://msdn.microsoft.com/en-us/library/system.xml.serialization.aspx) to serialize messages. It allows better interoperability with non-NServiceBus peers.

  * #### [Xml](/) <a href="http://www.nuget.org/packages/NServiceBus/"><img src="http://img.shields.io/nuget/v/NServiceBus.svg?" title="NuGet Status"></a> <a href="http://particular.net/"><img src="particular-project.png" title="A Particular run project"></a>
  A custom XML serializer built into the NServiceBus core.

## Persisters

 * #### MongoDB
 [MongoDB](http://www.mongodb.org/) is a cross-platform document-oriented database. There are current two projects supporting 

  * #### [NServiceBus.MongoDB](https://github.com/sbmako/NServiceBus.MongoDB) <a href="http://www.nuget.org/packages/NServiceBus.MongoDB/"><img src="http://img.shields.io/nuget/v/NServiceBus.MongoDB.svg?" title="NuGet Status"></a>

  * #### [NServiceBus.Persistence.MongoDb](https://github.com/tekmaven/NServiceBus.Persistence.MongoDb) <a href="http://www.nuget.org/packages/NServiceBus.Persistence.MongoDb/"><img src="http://img.shields.io/nuget/v/NServiceBus.Persistence.MongoDb.svg?" title="NuGet Status"></a>

 * #### [NHibernate](/nservicebus/relational-persistence-using-nhibernate.md) <a href="http://www.nuget.org/packages/NServiceBus.NHibernate/"><img src="http://img.shields.io/nuget/v/NServiceBus.NHibernate.svg?" title="NuGet Status"></a> <a href="http://particular.net/"><img src="particular-project.png" title="A Particular run project"></a>

 * #### [PostgreSQL](https://github.com/fhalim/NServiceBus.PostgreSQL) <a href="http://www.nuget.org/packages/NServiceBus.PostgreSQL/"><img src="http://img.shields.io/nuget/v/NServiceBus.PostgreSQL.svg?" title="NuGet Status"></a>

Leverages the [JSONB](http://www.postgresql.org/docs/devel/static/datatype-json.html) data type for storing data in [PostgreSQL](http://www.postgresql.org/).

 * #### [RavenDB](/nservicebus/ravendb/) <a href="http://www.nuget.org/packages/NServiceBus.RavenDB/"><img src="http://img.shields.io/nuget/v/NServiceBus.RavenDB.svg?" title="NuGet Status"></a> <a href="http://particular.net/"><img src="particular-project.png" title="A Particular run project"></a>

 * #### [DocumentDB](https://github.com/synhershko/NServiceBus.DocumentDB)
 A proof-of-concept project that shows the possibility of support for [Azure DocumentDB](http://azure.microsoft.com/en-us/services/documentdb/)

## Logging

 * #### [Log4Net](/nservicebus/logging-in-nservicebus.md#log4net)  <a href="http://www.nuget.org/packages/NServiceBus.Log4Net/"><img src="http://img.shields.io/nuget/v/NServiceBus.Log4Net.svg?" title="NuGet Status"></a> <a href="http://particular.net/"><img src="particular-project.png" title="A Particular run project"></a>

 * #### [NLog](/nservicebus/logging-in-nservicebus.md#nlog) <a href="http://www.nuget.org/packages/NServiceBus.NLog/"><img src="http://img.shields.io/nuget/v/NServiceBus.NLog.svg?" title="NuGet Status"></a> <a href="http://particular.net/"><img src="particular-project.png" title="A Particular run project"></a>

 * #### [CommonLogging](/nservicebus/logging-in-nservicebus.md#commonlogging) <a href="http://www.nuget.org/packages/NServiceBus.CommonLogging/"><img src="http://img.shields.io/nuget/v/NServiceBus.CommonLogging.svg?" title="NuGet Status"></a> <a href="http://particular.net/"><img src="particular-project.png" title="A Particular run project"></a>

 * #### [Serilog](https://github.com/SimonCropp/NServiceBus.Serilog) <a href="http://www.nuget.org/packages/NServiceBus.Serilog/"><img src="http://img.shields.io/nuget/v/NServiceBus.Serilog.svg?" title="NuGet Status"></a>
 Support for logging NServiceBus information to [Serilog](http://serilog.net/) logging library and the [Seq](http://getseq.net/) monitoring system both of which built on the concepts structured logging.

## Containers

 * #### [Autofac](/nservicebus/containers.md) <a href="http://www.nuget.org/packages/NServiceBus.Autofac/"><img src="http://img.shields.io/nuget/v/NServiceBus.Autofac.svg?" title="NuGet Status"></a> <a href="http://particular.net/"><img src="particular-project.png" title="A Particular run project"></a>

 * #### [CastleWindsor](/nservicebus/containers.md) <a href="http://www.nuget.org/packages/NServiceBus.CastleWindsor/"><img src="http://img.shields.io/nuget/v/NServiceBus.CastleWindsor.svg?" title="NuGet Status"></a> <a href="http://particular.net/"><img src="particular-project.png" title="A Particular run project"></a>

 * #### [Ninject](/nservicebus/containers.md) <a href="http://www.nuget.org/packages/NServiceBus.Ninject/"><img src="http://img.shields.io/nuget/v/NServiceBus.Ninject.svg?" title="NuGet Status"></a> <a href="http://particular.net/"><img src="particular-project.png" title="A Particular run project"></a>

 * #### [StructureMap](/nservicebus/containers.md)  <a href="http://www.nuget.org/packages/NServiceBus.StructureMap/"><img src="http://img.shields.io/nuget/v/NServiceBus.StructureMap.svg?" title="NuGet Status"></a> <a href="http://particular.net/"><img src="particular-project.png" title="A Particular run project"></a>

 * #### [Spring](/nservicebus/containers.md) <a href="http://www.nuget.org/packages/NServiceBus.Spring/"><img src="http://img.shields.io/nuget/v/NServiceBus.Spring.svg?" title="NuGet Status"></a> <a href="http://particular.net/"><img src="particular-project.png" title="A Particular run project"></a>

 * #### [Unity](/nservicebus/containers.md) <a href="http://www.nuget.org/packages/NServiceBus.Unity/"><img src="http://img.shields.io/nuget/v/NServiceBus.Unity.svg?" title="NuGet Status"></a> <a href="http://particular.net/"><img src="particular-project.png" title="A Particular run project"></a>

## Other

 * #### [Aggregates.NET](https://github.com/volak/Aggregates.NET) <a href="http://www.nuget.org/packages/Aggregates.NET/"><img src="http://img.shields.io/nuget/v/Aggregates.NET.svg?" title="NuGet Status"></a>
 .NET event sourced domain driven design model via [NEventStore](http://www.appccelerate.com/distributedeventbroker.html).

 * #### Azure Hosting

  * #### [Azure Host](/nservicebus/hosting-nservicebus-in-windows-azure.md) <a href="http://www.nuget.org/packages/NServiceBus.Hosting.Azure/"><img src="http://img.shields.io/nuget/v/NServiceBus.Hosting.Azure.svg?" title="NuGet Status"></a> <a href="http://particular.net/"><img src="particular-project.png" title="A Particular run project"></a>
  The process used when hosting an endpoint on [Azure](http://azure.microsoft.com/en-us/).

  * #### [Multi Endpoint Azure Host](/nservicebus/hosting-nservicebus-in-windows-azure.md) <a href="http://www.nuget.org/packages/NServiceBus.Hosting.Azure.HostProcess/"><img src="http://img.shields.io/nuget/v/NServiceBus.Hosting.Azure.HostProcess.svg?" title="NuGet Status"></a> <a href="http://particular.net/"><img src="particular-project.png" title="A Particular run project"></a>
  The process used when sharing an [Azure](http://azure.microsoft.com/en-us/) instance between multiple endpoints.

 * #### [Distributed Event Broker](https://github.com/appccelerate/distributedeventbroker.nservicebus) <a href="http://www.nuget.org/packages/Appccelerate.DistributedEventBroker.NServiceBus/"><img src="http://img.shields.io/nuget/v/Appccelerate.DistributedEventBroker.NServiceBus.svg?" title="NuGet Status"></a> 
 Allows sending events over the [Appccelerate.EventBroker](http://www.appccelerate.com/distributedeventbroker.html) infrastructure.

 * #### [Distributor](/nservicebus/load-balancing-with-the-distributor.md) <a href="http://www.nuget.org/packages/NServiceBus.Distributor.MSMQ/"><img src="http://img.shields.io/nuget/v/NServiceBus.Distributor.MSMQ.svg?" title="NuGet Status"></a> <a href="http://particular.net/"><img src="particular-project.png" title="A Particular run project"></a>
 Distributor for the MSMQ transport.

 * #### [Gateway](/nservicebus/introduction-to-the-gateway.md) <a href="http://www.nuget.org/packages/NServiceBus.Gateway/"><img src="http://img.shields.io/nuget/v/NServiceBus.Gateway.svg?" title="NuGet Status"></a> <a href="http://particular.net/"><img src="particular-project.png" title="A Particular run project"></a>

 * #### [Mandrill](https://github.com/feinoujc/NServiceBus.Mandrill) <a href="http://www.nuget.org/packages/Aggregates.NET/"><img src="http://img.shields.io/nuget/v/Aggregates.NET.svg?" title="NuGet Status"></a>
 [Mandrill](http://mandrill.com/) is a email infrastructure service built by [MailChimp](http://mailchimp.com/). This extension allow for sending Mandrill emails as messages.

 * #### [Mailer](https://github.com/SimonCropp/NServiceBus.Mailer) <a href="http://www.nuget.org/packages/NServiceBus.Mailer/"><img src="http://img.shields.io/nuget/v/NServiceBus.Mailer.svg?" title="NuGet Status"></a>
 Extension to enable sending SMTP emails as messages.

 * #### [MessageRouting](https://github.com/jbogard/NServiceBus.MessageRouting) <a href="http://www.nuget.org/packages/NServiceBus.MessageRouting/"><img src="http://img.shields.io/nuget/v/NServiceBus.MessageRouting.svg?" title="NuGet Status"></a>
 An implementation the [Routing Slip](http://www.enterpriseintegrationpatterns.com/RoutingTable.html) pattern that enables you to route a message to one or more destinations

 * #### [HandlerOrdering](https://github.com/SimonCropp/HandlerOrdering) <a href="http://www.nuget.org/packages/HandlerOrdering/"><img src="http://img.shields.io/nuget/v/HandlerOrdering.svg?" title="NuGet Status"></a>
 Allows a more expressive way to order handlers.

 * #### [NES (.NET Event Sourcing)](https://github.com/elliotritchie/NES) <a href="http://www.nuget.org/packages/NES.NServiceBus/"><img src="http://img.shields.io/nuget/v/NES.NServiceBus.svg?" title="NuGet Status"></a>
 NES that helps you build domain models when you're doing event sourcing. It attempts to fill in the gaps between NServiceBus and NEventStore.

 * #### [SignalR](https://github.com/roycornelissen/SignalR.NServiceBus)
 Backplane for [SignalR](http://signalr.net/)

 * #### [NServiceBus.SLR](https://github.com/KenBerg75/NServiceBus.SLR) <a href="http://www.nuget.org/packages/NServiceBus.SLR/"><img src="http://img.shields.io/nuget/v/NServiceBus.SLR.svg?" title="NuGet Status"></a>
 A plugin to NServiceBus that allows configuration of Second Level Retries based on the Exception Type.