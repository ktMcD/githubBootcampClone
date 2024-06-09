// See https://aka.ms/new-console-template for more information
using ZooKeeper;

Zebra zebra = new Zebra();

zebra.BloodCategoryType = BloodCategory.WarmBlooded;

Console.WriteLine(zebra.Speak());
