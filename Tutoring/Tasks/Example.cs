using System;
using System.Collections.Generic;

namespace Tutoring;

class Command
{
    public string Name;
    private List<string> _acceptedCommandNames = new () {"Forward", "Back", "Stop"};
    public Command(string name)
    {
        if (_acceptedCommandNames.Contains(name))
            Name = name;
        else
            Name = "Stop";
    }
}
class Programm
{
    public void ShowCommand(Command command)
    {
        if (command == null)
        {
            Console.WriteLine("No Command");
            return;           
        }
        Console.WriteLine(command.Name);
    }
}
