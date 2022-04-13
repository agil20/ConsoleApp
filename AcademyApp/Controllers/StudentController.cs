
using Business.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Utilities.Helper;

namespace AcademyApp.Controllers
{
    class StudentController
    {

        private StudentService studentService;
        public StudentController()
        {
            studentService = new StudentService();
        }
        public void CreateStudent()
        {
        CreateStudent:
            Extention.Print(ConsoleColor.White, "Adi daxil edin");
            string name =Console.ReadLine();
          
            

        }



    }
}
