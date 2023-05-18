using CodeAcademy.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademy.Core.Entities;

public class GroupType:IEntity
{
    private static int _id;
    public readonly object GroupName;

    public int GroupTypeId { get; }
    public string Type { get; set; }
    public GroupType()
    {
        GroupTypeId = _id;
        _id++;
    }
    public GroupType(string type) : this()
    {
        Type = type;
    }
}
