using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
            new SqlServerCustomerDal(),
            new OracleCustomerDal(),
            new MySqlCustomerDal()
             };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }


            //Bir inrerface hiçbir şekilde new lenemez.Çünkü tek başına bir anlamı yoktur.
            /*
               CustomerManager customerManager = new CustomerManager();
               customerManager.Add(new OracleCustomerDal());
               //    PersonManager manager = new PersonManager();
               //    Customer customer = new Customer
               //    {
               //        Id = 1,
               //        FirstName = "Ali",
               //        LastName = "Can",
               //        Adress = "İzmir"

               //    };
               //    Student student = new Student
               //    {
               //        Id = 1,
               //        FirstName = "Kaan",
               //        LastName = "Can",
               //        Departmant = "Computer Sciences"
               //    };
               //    manager. Add(customer);
               //    manager.Add(student);
               //    //manager.Add(new Customer { Id = 1, FirstName = "Ali", LastName = "Can", Adress = "İzmir" });

                 Console.ReadLine();


               //interface IPerson     //soyut nesne ve tek başına bir şey ifade etmez
               //{
               //   int Id { get; set; }
               //   string FirstName { get; set; }
               //    string LastName { get; set; }
               //                               //temel amacı bir temel nesne oluşturup bütün nesnleri ondan implemente etmektir
               //}
               //class Customer : IPerson //somut nesne
               //{
               //    public int Id { get; set; }
               //    public string FirstName { get ; set ; }
               //    public string LastName { get; set ; }
               //    public string Adress { get; set; }
               //}
               //class Student : IPerson
               //{
               //    public int Id { get; set ; }
               //    public string FirstName { get ; set ; }
               //    public string LastName { get; set ; }
               //    public string Departmant { get; set; }
               //}
               //class PersonManager
               //{
               //    public void Add(IPerson person)
               //    {
               //        Console.WriteLine(person.FirstName);
               //    }
               //

           */


            //Poliformizim:Çok Biçimlilik =Bir nesneyi farklı amaçlarla imlemenete edip o implementasyonlara ulaşmaktır.
            Console.ReadLine();
        }
    }
}