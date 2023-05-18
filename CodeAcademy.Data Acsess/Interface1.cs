using CodeAcademy.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademy.Data_Acsess;

public interface Interface1 <T> where T : IEntity
{
    void Add(T entity);
    void update (T entity);
    void delete (T entity);
    T Get(int id);
    List<T> GetAll();

    T GetByName(string name);
    List<T> GetAllByName(string name);
}
