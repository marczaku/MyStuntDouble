﻿Person[] people = new Person[3];

for (var i = 0; i < people.Length; i++)
{
    people[i] = new Person();
    people[i].Name = Console.ReadLine();
}

for (var i = 0; i < people.Length; i++)
{
    people[i].Greeting();
}