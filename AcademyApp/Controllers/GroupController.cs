using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Utilities.Helper;

namespace AcademyApp.Controllers
{
    class GroupController
    {
        private GroupService groupService;
        public GroupController()
        {
            groupService = new GroupService();
        }
        public void CreateGroup()
        {
        EnterName:
            Extention.Print(ConsoleColor.Green, $"Group Name");
            string name = Console.ReadLine();

            Extention.Print(ConsoleColor.Green, $"Group Size");
            string groupSize = Console.ReadLine();
            int size;


            bool isSize = int.TryParse(groupSize, out size);
            if (isSize)
            {
                Group group = new Group
                {
                    Name = name,
                    MaxSize = size
                };

                groupService.Create(group);
                Extention.Print(ConsoleColor.Green, $"{group.Name} created");
            }
            else
            {
                Extention.Print(ConsoleColor.Red, "Duzgun daxil et");
                goto EnterName;
            }
        }
        public void GetAllGroup()
        {
            
            //string name2 = Console.ReadLine();

            foreach (var item in groupService.GetAll())
            {
                Extention.Print(ConsoleColor.Yellow, $"{item.Name}");
            }
        }
        public void RemoveGroup()
        {
            int id = int.Parse(Console.ReadLine());
            Extention.Print(ConsoleColor.Green, $"{groupService.Delete(id).Name}");
            
        }
        public void UpdateGroup()
        {
        UpdateGroup:
            Extention.Print(ConsoleColor.Green, $"Enter Id");
            string groupid=Console.ReadLine();
            Extention.Print(ConsoleColor.Red, $"Enter Name");
            string name=Console.ReadLine();
            int id;
            bool isId=int.TryParse(groupid ,out id);   
            if (isId)
            {
                Group group = new Group
                {
                    
                    Id=id,
                    Name = name,
                };
                groupService.Update(id,group);
                Extention.Print(ConsoleColor.Green, $"{group.Name} Update");

            }
            else
            {
                Extention.Print(ConsoleColor.White,"duzgun daxil et");
                goto UpdateGroup;
            }

        }
        public void GetGroup()
        {

            Extention.Print(ConsoleColor.Green, $"Enter id");
            string name = Console.ReadLine();

            Group group = new Group
            {
                Name = name,
            };
            groupService.GetGroup(name);
                

          

        }
    }
}
