using CodeAcademy.Core.Entities;
using CodeAcademy.Data_Acsess.IRepositery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademy.Data_Acsess.Implementations;

public class StudentRepository : IRepositery<Student>
{
    public void Add(Student entity)
    {
        Class1.GroupType.Add(entity);
    }

    public void delete(Student entity)
    {
       Class1.Students.Remove(entity);
    }

    public Student? Get(int id)
    {
        return Class1.Students.Find(st=>st.StudentId == id);
    }

    public List<Student> GetAll()
    {
        return Class1.Students;
    }

    public void update(Group entity)
    {
         Student stu = Class1.GroupType.Find(st => st.GroupId == id);
        stu.StudentName = entity.GroupName;
        stu.StudentSurname = entity.GroupSurname;

    }
}

