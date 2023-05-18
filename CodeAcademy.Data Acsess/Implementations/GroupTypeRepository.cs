using CodeAcademy.Core.Entities;
using CodeAcademy.Data_Acsess.IRepositery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademy.Data_Acsess.Implementations;

public class GroupTypeRepository : Class1<GroupType>
{
    public void Add(GroupType entity)
    {
        Class1.Types.Add(entity);
    } 

    public void delete(GroupType entity)
    {
        Class1.Types.Remove(entity);
    }

    public GroupType? Get(int id)
    {
        return Class1.Types.Find(t => t.GroupTypeId == id);

    }
    public GroupType? GetByName(string type)
    {
        return Class1.Types.Find(t => t.Type == type);
    }

    public List<GroupType>? GetAll(int id) 
    {
        return Class1.Types;
    }

    public void update(GroupType entity)
    {
        GroupType type=Class1.Types.Find(t =>t.GroupTypeId == entity.GroupTypeId);
        type.Type=entity.Type;
    
    }
}

