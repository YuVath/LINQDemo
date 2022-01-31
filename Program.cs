using System;
using System.Collections.Generic;
using System.Linq;


namespace LINQDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Simple LINQ


            //    int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //    var lowNums = from num in numbers
            //                  where num > 5
            //                  select num;
            //    Console.WriteLine("NUmbers < 5");
            //    foreach (var item in numbers)
            //    {
            //        Console.WriteLine(item);
            //    }

            //List<int> numbers = new List<int>() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //// Query Syntax


            //var querySyntax = from num in numbers
            //              where num > 5
            //              select num;
            //Console.WriteLine("NUmbers < 5");
            //foreach (var item in querySyntax)

            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine();
            //Console.WriteLine("--------------------------");

            //// Method Syntax


            //var methodSyntax = numbers.Where(x => x > 5);

            //foreach (var item in methodSyntax)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine();
            //Console.WriteLine("--------------------------");

            //// Mix Syntax


            //var mixedSyntax = (from num in numbers
            //                   select num).Max();
            //Console.WriteLine(mixedSyntax);


            // IEnumerable 


            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //List<Employee> employees = new List<Employee>()
            //{
            //    new Employee(){Id = 1,Name="Azwar" , Email="ju@gmail.com"},
            //    new Employee(){Id = 2,Name="Fareed", Email="qubi@gmail.com"},
            //    new Employee(){Id = 3,Name="Hasni", Email="hachi@gmail.com"},
            //    new Employee{Id = 4,Name="Syed", Email ="roku@gmail.com"}
            //};

            //IEnumerable<Employee> query = from emp in employees
            //                              where emp.Id == 1
            //                              select emp;
            //foreach (Employee emp in query)
            //{
            //    Console.WriteLine(emp.Id + " " + emp.Name);
            //}

            // IQuerable


            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //List<Employee> employees = new List<Employee>()
            //{
            //    new Employee(){Id = 1,Name="Azwar" , Email="ju@gmail.com"},
            //    new Employee(){Id = 2,Name="Fareed", Email="qubi@gmail.com"},
            //    new Employee(){Id = 3,Name="Hasni", Email="hachi@gmail.com"},
            //    new Employee{Id = 4,Name="Syed", Email ="roku@gmail.com"}
            //};

            //IQueryable<Employee> query = employees.AsQueryable();

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.Id + " " + item.Name + " " + item.Email);
            //}

            // Projection Operations


            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //List<Employee> employees = new List<Employee>()
            //{
            //    new Employee(){Id = 1,Name="Azwar" , Email="ju@gmail.com"},
            //    new Employee(){Id = 2,Name="Fareed", Email="qubi@gmail.com"},
            //    new Employee(){Id = 3,Name="Hasni", Email="hachi@gmail.com"},
            //    new Employee{Id = 4,Name="Syed", Email ="roku@gmail.com"}
            //};

            //var basicQuery = (from emp in employees
            //                  select emp).ToList();

            //var basicMethod = employees.ToList();

            //Console.WriteLine("--------------");

            //var basicPropQuery = (from emp in employees
            //                      select emp.Id.ToString()).ToList();

            //var basicPropMethod = employees.Select(emp => emp.Id).ToList();

            //foreach (var item in basicMethod)
            //{
            //    Console.WriteLine(item.Id + " " + item.Name + " " + item.Email);
            //}

            // Select Query



            //List<Employee> employees = new List<Employee>()
            //{
            //    new Employee(){Id = 1,Name="Azwar" , Email="ju@gmail.com"},
            //    new Employee(){Id = 2,Name="Fareed", Email="qubi@gmail.com"},
            //    new Employee(){Id = 3,Name="Hasni", Email="hachi@gmail.com"},
            //    new Employee{Id = 4,Name="Syed", Email ="roku@gmail.com"}
            //};

            //var selectQuery = (from emp in employees
            //                   select new Employee()
            //                   {
            //                       Id = emp.Id,
            //                       Email = emp.Email,

            //                   }).ToList();

            //foreach (var item in selectQuery)
            //{
            //    Console.WriteLine(item.Id + " " + item.Name + " " + item.Email);
            //}

            //var convetQuery = (from emp in employees
            //                   select new Student
            //                   {
            //                       StudentId = emp.Id,
            //                       FullName = emp.Name,
            //                       StEmail = emp.Email
            //                   }).ToList();

            //foreach (var item in convetQuery)
            //{
            //    Console.WriteLine($"{item.StudentId}\t{item.FullName}\t{item.StEmail}");
            //}

            // Select Method


            //List<Employee> employees = new List<Employee>()
            //{
            //    new Employee(){Id = 1,Name="Azwar" , Email="ju@gmail.com"},
            //    new Employee(){Id = 2,Name="Fareed", Email="qubi@gmail.com"},
            //    new Employee(){Id = 3,Name="Hasni", Email="hachi@gmail.com"},
            //    new Employee{Id = 4,Name="Syed", Email ="roku@gmail.com"}
            //};

            //var selectMethod = employees.Select(emp => new Employee
            //{
            //    Id = emp.Id,
            //    Name = emp.Name,

            //}).ToList();

            //foreach (var item in selectMethod)
            //{
            //    Console.WriteLine($"{item.Id}\t{item.Name}\t Email ??? {item.Email}");
            //}

            //var convertMethod = employees.Select(emp => new Student()
            //{
            //    StudentId = emp.Id,
            //    FullName = emp.Name,
            //    StEmail = emp.Email
            //}).ToList();

            //foreach (var item in convertMethod)
            //{
            //    Console.WriteLine($"{item.StudentId}\t{item.FullName}\t{item.StEmail}");
            //}

            // How to select data by using the index



            //List<Employee> employees = new List<Employee>()
            //{
            //    new Employee(){Id = 1,Name="Azwar" , Email="ju@gmail.com"},
            //    new Employee(){Id = 2,Name="Fareed", Email="qubi@gmail.com"},
            //    new Employee(){Id = 3,Name="Hasni", Email="hachi@gmail.com"},
            //    new Employee{Id = 4,Name="Syed", Email ="roku@gmail.com"}
            //};

            ////var indexQuery = employees.Select((emp , index) => new
            ////{
            ////    Index = index,
            ////    FullName = emp.Name
            ////}).ToList();

            ////foreach (var item in indexQuery)
            ////{
            ////    Console.WriteLine($"{item.Index}\t{item.FullName}");
            ////}

            //var lastItem = employees.LastOrDefault();

            //List<string> strList = new List<string>() { "Azwar","Fareed"};


            //// Select Many by Method



            //var methodResult = strList.SelectMany(x => x).ToList();

            //// Select Many by Query

            //var queryMethod = (from rec in  strList
            //                   from ch in rec
            //                   select ch).ToList();


            // Select Many Another Example


            //var dataSource = new List<Employee>()
            //{
            //    new Employee(){Id = 1,Name="Azwar" , Email="ju@gmail.com" , Programming = new List<string>(){ "C#","PHP","JAVA"} },
            //    new Employee(){Id = 2,Name="Fareed", Email="qubi@gmail.com",Programming = new List<string>(){ "LINQ","C#" ,"MVC"}},
            //    new Employee(){Id = 3,Name="Hasni", Email="hachi@gmail.com",Programming = new List<string>(){ "LINQ","VB","SQL"}},
            //};

            //var methodSyntax = dataSource.SelectMany(emp => emp.Programming).ToList();

            //foreach (var item in methodSyntax)
            //{
            //    Console.WriteLine($"Programming = {item}");
            //}



            // Select Many Another Example




            //var dataSource = new List<Employee>()
            //{
            //    new Employee(){Id = 1 , Name = "Syed" , Email = "10@gmail.com" , Programming = new List<Techs>
            //    {
            //        new Techs(){Technology = "C#"},
            //        new Techs(){Technology ="PHP"},
            //        new Techs(){Technology =".Net"}
            //    } },
            //    new Employee(){Id = 2 , Name = "Muhammad" , Email = "9@gmail.com" , Programming = new List<Techs>
            //    {
            //        new Techs(){Technology ="C#"},
            //        new Techs(){Technology ="VB"},
            //        new Techs(){Technology=".Net"}
            //    }
            //    },
            //    new Employee(){Id = 3 , Name = "Azwar", Email = "8@gmail.com" , Programming = new List<Techs>
            //    {
            //        new Techs(){Technology ="LINQ"},
            //        new Techs(){Technology="MVC"},
            //        new Techs(){Technology ="C#"}
            //    } },
            //    new Employee(){Id = 4, Name = "Fareed", Email="7@gmail.com", Programming = new List<Techs>()},
            //    new Employee(){Id = 5 , Name = "Hasni",Email="6@gmail.com", Programming = new List<Techs>()}
            //};

            //var methodQuery = dataSource.SelectMany(emp => emp.Programming).ToList();

            //var queryQuery = (from emp in dataSource
            //                  from pro in emp.Programming
            //                  select pro).ToList();

            // Filtering Operators
            // Where Operator



            //var dataSource = new List<string>() { "Syed" , "Muhammad", "Azwar" , "Fareed", "Hasni"};

            //var queryQuery = (from data in dataSource
            //                  where data == "Syed" || data.Length > 7
            //                  select data).ToList();

            //var methodQuery = dataSource.Where(x => x == "Syed" || x.Length > 5 ).ToList();



            // Filtering Operators
            // Where Operator



            //var dataSource = new List<Employee>()
            //{
            //    new Employee(){Id = 1 , Name = "Syed" , Email = "10@gmail.com" , Programming = new List<Techs>
            //    {
            //        new Techs(){Technology = "C#"},
            //        new Techs(){Technology ="PHP"},
            //        new Techs(){Technology =".Net"},
            //        new Techs(){Technology ="MVC"},
            //        new Techs(){Technology ="SQL"}
            //    } },
            //    new Employee(){Id = 2 , Name = "Muhammad" , Email = "9@gmail.com" , Programming = new List<Techs>
            //    {
            //        new Techs(){Technology ="C#"},
            //        new Techs(){Technology ="VB"},
            //        new Techs(){Technology=".Net"}
            //    }
            //    },
            //    new Employee(){Id = 3 , Name = "Azwar", Email = "8@gmail.com" , Programming = new List<Techs>
            //    {
            //        new Techs(){Technology="MVC"},
            //        new Techs(){Technology ="C#"}
            //    } },
            //    new Employee(){Id = 4, Name = "Fareed", Email="7@gmail.com", Programming = new List<Techs>()},
            //    new Employee(){Id = 5 , Name = "Hasni",Email="6@gmail.com", Programming = new List<Techs>()}
            //};

            //var querySyntax = (from employee in dataSource
            //                   where employee.Programming.Count() == 0
            //                   select employee).ToList();

            //var methodSyntax = dataSource.Where(x=> x.Programming.Count() > 2).ToList();


            // Filtering Operators
            // OfType Operator



            //var dataSource = new List<object>() { "Azwar", "Fareed", "Hasni", 1, 2, 3, 4, 5, 6 };

            //var methodQuery = dataSource.OfType<string>().ToList();

            //var queryQuery = (from data in dataSource
            //                  where data is string
            //                  select data).ToList();


            // Order By



            //var dataSource = new List<int>() { 5, 12, 13, 1, 7, 52, 100 };

            //var queryQuery =  (from num in dataSource
            //                   where num > 10
            //                   orderby num
            //                   select num).ToList();

            //var methodQuery = dataSource.Where(x => x > 10).OrderBy(x => x).ToList();


            // Order By



            //var stringList = new List<string>() { "Syed", "Muhammad", "Azwar", "Fareed", "Hasni" };

            //var queryQuery = (from name in stringList
            //                  where name.Length > 6
            //                  orderby name
            //                  select name).ToList();


            //var methodQuery = stringList.Where(x => x.Length > 6).OrderBy(x => x).ToList();


            // Order By



            //var dataSource = new List<Employee>()
            //{
            //    new Employee()
            //    {
            //        Id = 3,
            //        Email = "Smith@gmail.com",
            //        Name = "Smith"
            //    },
            //    new Employee()
            //    {
            //        Id=2,
            //        Email = "Thomas@gmail.com",
            //        Name = "Thomas"
            //    },
            //    new Employee()
            //    {
            //        Id = 1,
            //        Email = "Allen@gmail.com",
            //        Name = "Allen"
            //    },
            //    new Employee()
            //    {
            //        Id = 4,
            //        Email = "Anderson@gmail.com",
            //        Name = "Anderson"
            //    }
            //};

            //var queryQuery = (from id in dataSource
            //                  orderby id.Id
            //                  select id).ToList();

            //var methodQuery = dataSource.OrderBy(x => x.Id).ToList();



            // Order By Descending



            //var dataSource = new List<int>() { 5, 12, 13, 1, 7, 52, 100 };

            //var queryQuery = (from num in dataSource
            //                  where num > 10
            //                  orderby num descending
            //                  select num).ToList();

            //var methodQuery = dataSource.Where(x => x > 10).OrderByDescending(x => x).ToList();



            // Then By




            //var dataSource = new List<Employee>()
            //{
            //    new Employee()
            //    {
            //        Id = 3,
            //        Email = "Smith@gmail.com",
            //        LastName = "Smith",
            //        FirstName = " Foo"
            //    },
            //    new Employee()
            //    {
            //        Id=2,
            //        Email = "Thomas@gmail.com",
            //        LastName = "Thomas",
            //        FirstName = "Mark"
            //    },
            //    new Employee()
            //    {
            //        Id = 1,
            //        Email = "Allen@gmail.com",
            //        LastName = "Allen",
            //        FirstName = "Mark"
            //    },
            //    new Employee()
            //    {
            //        Id = 4,
            //        Email = "Anderson@gmail.com",
            //        LastName = "Anderson",
            //        FirstName = "Foo"
            //    }
            //};

            //var ms = dataSource.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();

            //var qs = (from item in dataSource
            //         orderby item.FirstName, item.LastName
            //         select item).ToList();

            //foreach (var item in qs)
            //{
            //    Console.WriteLine($"{item.Id} , {item.Email} , {item.LastName} , {item.FirstName}");
            //}

























            Console.WriteLine();
        }
    }
}
