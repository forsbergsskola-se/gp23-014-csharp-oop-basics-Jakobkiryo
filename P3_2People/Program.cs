person[] person = new person[3];

for (var i = 0; i < person.Length; i++)
{
    person[i] = new person();
    person[i].Name = Console.ReadLine();
    
}

for (var i = 0; i < person.Length; i++)
{
    person[i].Greeting();
    
}