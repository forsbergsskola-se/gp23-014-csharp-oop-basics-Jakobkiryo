
person[] people = new person[3];

for (int i = 0; i < people.Length; i++)
{
    people[i] = new person();
}

for (var i = 0; i < people.Length; i++)
{
    Console.WriteLine(people[i]);
}