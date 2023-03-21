using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsoleApplication8
{
    class Person
    {
        public int Id { get; set; }
        public string SurName { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
