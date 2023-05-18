using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeAcademy.Core.Interfaces;

public interface IGroupService
{
    void Create(string groupName, string type, int capacity);
    void Delete(string groupName);
    void Update(int id,int capacity);
    Group GetByName(string groupName);

    Group GetById(string groupName);
    List<Group> GetAll();
}
