Person[] people = new Person[3];  // 0   1   2

for (var i = 0; i < people.Length; i++)
{
    people[i] = new Person();
}

for (var i = 0; i < people.Length; i++)
{
    Console.WriteLine(people[i]);
}