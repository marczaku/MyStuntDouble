// See https://aka.ms/new-console-template for more information

Item[] items = new Item[3];

for (var i = 0; i < items.Length; i++)
{
    items[i] = new Item(); // i = 2
}

items[0].goldValue = 100;
items[1].goldValue = 200;
items[2].goldValue = 300;

for (var itemIndex = 0; itemIndex < items.Length; itemIndex++)
{
    Console.WriteLine(items[itemIndex].goldValue);
}