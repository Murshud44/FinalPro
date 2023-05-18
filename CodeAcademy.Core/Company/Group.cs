using CodeAcademy.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodeAcademy.Core.Entities;

public class Group:IEntity
{
    private static int _id;
    public int GroupId { get; }
    public string GroupName { get; set; }
    public int Capacity { get; set; }
    public int GroupTypeId { get; set; }
    public object GroupSurname { get; set; }
    public object Group { get; set; }

    public Group()
    {
        GroupId = _id;
        _id++;
    }
    public Group(string name, int capacity) : this()
    {
        GroupName = name;
        Capacity = capacity;
    }

}


