// See https://aka.ms/new-console-template for more information
using IBM.WMQ;
using IBMMQ_Connection;
using Microsoft.Extensions.Configuration;
using System.Collections;

Console.WriteLine("Loading settings");

IConfigurationRoot config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

Settings settings = config.GetRequiredSection("Settings").Get<Settings>()!;

Console.WriteLine("Connecting to queue manager");

MQQueueManager queueManager = new(settings.QueueManagerName, settings.GetMQConnectionProperties());

Console.WriteLine("Connecting to queue");
var queue = queueManager.AccessQueue(settings.QueueName, settings.QueueOpenOptions);

Console.WriteLine("Success");
queue.Close();
queueManager.Close();

Console.WriteLine("Press any key to exit");
Console.ReadKey();