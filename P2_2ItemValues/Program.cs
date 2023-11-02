//putting diferrent values on items.

Item[] items = new Item[3];

for (var i = 0; i < items.Length; i++)
{
    items[i] = new Item();
}

items[0].goldValue = 100;
items[1].goldValue = 200;
items[2].goldValue = 300;

for (var i = 0; i < items.Length; i++)
{
    Console.WriteLine(items[i].goldValue);
}