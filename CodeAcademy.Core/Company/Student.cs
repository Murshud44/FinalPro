using CodeAcademy.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademy.Core.Entities
{
    public class Student:IEntity
    {
        private static int _id;
        public int StudentId { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int GroupId { get; set; }
        public object StudentSurname { get; set; }

        public Student()
        {
            StudentId = _id;
            _id++;
        }
        public Student(string name,string surname):this()
        {
            Name = name;
            Surname = surname;
        }
    }

}
