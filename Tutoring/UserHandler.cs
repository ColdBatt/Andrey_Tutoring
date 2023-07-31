using System.Collections.Generic;

namespace Tutoring;

public class DataHandler
{
    private List<User> _data { get; set; }

    public DataHandler(User[] data)
    {
        _data = new List<User>();
        foreach (var item in data)
        {
            _data.Add(item);
        }
    }

    public User GetOldestUser()
    {
        var maxAge = 0;
        User oldestUser = null;
        
        foreach (var user in _data)
        {
            if (user.Age > maxAge)
            {
                maxAge = user.Age;
                oldestUser = user;
            }
        }

        return oldestUser;
    }

    public List<User> GetAllUsersOfEducation(EducationType education)
    {
        var result = new List<User>();
        foreach (var user in _data)
        {
            if (user.Education == education)
                result.Add(user);
        }

        return result;
    }
}