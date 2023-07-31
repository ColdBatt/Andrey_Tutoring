using System.Collections;

namespace Tutoring;

public class User
{
    private int _id;
    public string Name { get; set; }
    public string Phone { get; private set; }
    public int Age { get; }
    public EducationType Education { get; set; }

    public User(int id, string name, string phone, int age, EducationType type)
    {
        _id = id;
        Name = name;
        Phone = phone;
        Age = age;
        Education = type;
    }

    public override string ToString()
    {
        return $"id - {_id}\n" +
               $"Name - {Name}\n" +
               $"Phone - {Phone}\n" +
               $"Age - {Age}\n" +
               $"Education - {Education}";
    }
}