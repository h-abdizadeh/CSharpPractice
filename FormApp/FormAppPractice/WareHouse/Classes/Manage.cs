
using WareHouse.Models;
using WareHouse.Context;

namespace WareHouse.Classes;

public class Manage
{
    DatabaseContext _context = new DatabaseContext();
    public string[] GetGroups()
    {
        //1 ef
        //var groups = _context.Groups.Select(g => g.Title).ToArray();
        //return groups;

        //2 linq
        var group = from g in _context.Groups
                    select g.Title;

        return group.ToArray();
    }

    public int GetGroupId(string groupName)
    {
        var group = 
            _context.Groups.FirstOrDefault(g => g.Title == groupName);

        if (group == null) return 0;

        return group.Id;

    }
}
