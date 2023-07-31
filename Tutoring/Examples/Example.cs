using System;

namespace Tutoring;

class Person
{
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
    }
    public virtual void Print()
    {
        Console.WriteLine($"Person {Name}");
    }
}
 
class Employee : Person
{
    public string Company { get; set; }
    public Employee(string name, string company) : base(name)
    {
        Company = company;
    }

    public override void Print()
    {
        Console.WriteLine($"Person {Name} working in company - {Company}");
    }
}
 
class Client : Person
{
    public string Bank { get; set; }
    public Client(string name, string bank) : base(name)
    {
        Bank = bank;
    }
}