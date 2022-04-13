using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    internal interface IStudent
    {
        Student Create(Student student);
        Student Update(int Id, Group group);

        Student Delete(int Id);

        Student GetStudent(string name);
       

        List<Student> GetAll(string name = null);



    }
}
