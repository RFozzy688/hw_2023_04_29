//Реалізуйте користувацький тип «Фірма». В ньому має бути інформація про назву фірми, дату заснування, 
//профіль бізнесу (маркетинг, IT, і т. д.), ПІБ директора, кількість працівників, адреса. 
//Для масиву фірм реалізуйте такі запити: 
// 1 Отримати інформацію про всі фірми. 
// 2 Отримати фірми, які мають у назві слово «Food». 
// 3 Отримати фірми, які працюють у галузі маркетингу. 
// 4 Отримати фірми, які працюють у галузі маркетингу або IT. 
// 5 Отримати фірми з кількістю працівників більшою, ніж 100. 
// 6 Отримати фірми з кількістю працівників у діапазоні від 100 до 300. 
// 7 Отримати фірми, які знаходяться в Лондоні. 
// 8 Отримати фірми, в яких прізвище директора White. 
// 9 Отримати фірми, які засновані більше двох років тому. 
// 10 Отримати фірми з дня заснування яких минуло 123 дні. 
// 11 Отримати фірми, в яких прізвище директора Black і мають у назві фірми слово «White». 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_2023_04_29
{
    public class Company
    {
        public string NameCompany { get; set; }
        public DateTime FoundationDate { get; set; }
        public string Profile { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int CountEmployee { get; set; }
        public string City { get; set; }
        public override string ToString()
        {
            return $"Название фирмы: {NameCompany}\nДата основания: {FoundationDate.ToShortDateString()}\nПрофиль: {Profile}\n" +
                $"Имя: {Name}\nФамилия: {SurName}\nКоличество сотрудников: {CountEmployee}\nГород: {City}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Company> companies = new List<Company> {
                new Company {
                    NameCompany = "Fast Food",
                    FoundationDate = new DateTime(2022, 1, 1),
                    Profile = "Marketing",
                    Name = "Joe",
                    SurName = "White",
                    CountEmployee = 110,
                    City = "London"
                },
                new Company {
                    NameCompany = "Frozen Food",
                    FoundationDate = new DateTime(2023, 4, 10),
                    Profile = "Marketing",
                    Name = "Emma",
                    SurName = "Kirk",
                    CountEmployee = 60,
                    City = "Paris"
                },
                new Company {
                    NameCompany = "White Dog",
                    FoundationDate = new DateTime(2020, 9, 15),
                    Profile = "IT",
                    Name = "Henry",
                    SurName = "Black",
                    CountEmployee = 210,
                    City = "London"
                },
                new Company {
                    NameCompany = "White",
                    FoundationDate = new DateTime(2015, 9, 15),
                    Profile = "Electronics",
                    Name = "Daniel",
                    SurName = "Black",
                    CountEmployee = 310,
                    City = "Germany"
                },
                new Company {
                    NameCompany = "Naughty Dog",
                    FoundationDate = new DateTime(1984, 9, 27),
                    Profile = "IT",
                    Name = "Evan",
                    SurName = "Wells",
                    CountEmployee = 500,
                    City = "USA"
                }
            };

            // 1 Отримати інформацію про всі фірми. 
            var query = from i in companies
                        select i;

            Console.WriteLine("Все компании:\n");
            foreach (var item in query)
            {
                Console.WriteLine(item + "\n");
            }

            //2 Отримати фірми, які мають у назві слово «Food».
            query = from i in companies
                        where i.NameCompany.IndexOf("Food") > -1
                        select i;

            Console.WriteLine("Все компании которые имеют в названии слово Food:\n");
            foreach (var item in query)
            {
                Console.WriteLine(item + "\n");
            }

            //3 Отримати фірми, які працюють у галузі маркетингу. 
            query = from i in companies
                    where i.Profile == "Marketing"
                    select i;

            Console.WriteLine("Все компании которые работают в сфере маркетинга:\n");
            foreach (var item in query)
            {
                Console.WriteLine(item + "\n");
            }
        }
    }
}
