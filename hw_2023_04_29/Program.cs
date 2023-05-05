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
        public string Address { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
