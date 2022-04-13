using Business.Interfaces;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    public  class StudentService : IStudent
    {
        public static int Count { get; set; }
        private StudentRepository _studentRepository;
        public StudentService()
        {
            _studentRepository=new StudentRepository();
        }
        public Student Create(Student student)
        {
            student.Id = Count;


            _studentRepository.Create(student);
            Count++;
            return student;

        }

        public Student Delete(int Id)
        {
            Student isExist = _studentRepository.GetOne(g => g.Id == Id);
            if (isExist == null)
            {
                return null;
            }
            _studentRepository.Delete(isExist);
            return isExist;
        }

        public List<Student> GetAll(string name = null)
        {
            return _studentRepository.GetAll();
        }

      

        public Student GetStudent(string name)
        {
            return _studentRepository.GetOne(g => g.Name == name);
        }

        public Student Update(int Id, Group group)
        {
            return _studentRepository.GetOne(g => g.Id == Id);
        }

     
    }
}
