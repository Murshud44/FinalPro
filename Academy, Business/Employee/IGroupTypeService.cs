using CodeAcademy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy__Business.Interface27;

public interface IGroupTypeService
{
    void Create(string type);
    void Delete(string type);
    GroupType GetById(int id);
    List<GroupType> GetAll();
}
