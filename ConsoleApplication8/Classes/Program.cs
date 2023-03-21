using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            using (PersonContext db = new PersonContext())
            {
                // создаем два объекта Person
                Person Person1 = new Person { Name = "Tom"};
                Person Person2 = new Person { Name = "Sam"};

                // добавляем их в бд
                db.Persons.Add(Person1);
                db.Persons.Add(Person2);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                // получаем объекты из бд и выводим на консоль
                var Persons = db.Persons;
                Console.WriteLine("Список объектов:");
                foreach (Person u in Persons)
                {
                    Console.WriteLine("{0}.{1} - {2}", u.Id, u.Name);
                }
            }
        }
    }
}
