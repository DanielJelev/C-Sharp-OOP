using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        var worker = new Worker("john", "gothi", 450,24);
        Console.WriteLine(worker.MoneyPerhour());
        List<Student> students = new List<Student>
        {
            new Student("5080808058550","Jane","Mane"),
            new Student("5524254524424","Sonya","Blade"),
            new Student("6656488745688","Jack","Sparow"),
            new Student("5858254899988","Hanna","Montana"),
            new Student("2121144445325","Derek","Simpson"),
            new Student("3554846513554","Daniel","Krage"),
            new Student("3665441262424","Kolin","Kolins"),
            new Student("9978753342425","Cane","Marrow"),
            new Student("7797775464654","Rick","Ross"),
            new Student("6654484515684","Johny","Cage"),
        };
        List<Worker> workers = new List<Worker> 
        {
            new Worker("James","Bond",500.20,8),
            new Worker("Adam","Anderson",700.50,10),
            new Worker("David","Jackman",1200.30,8),
            new Worker("Kevin","Mace",900,7),
            new Worker("Jerry","Conner",850.30,6),
            new Worker("Mike","O'Brayan",780,9),
            new Worker("Michael","Jakson",2000.200,5),
            new Worker("Lenny","Cross",1760.60,8),
            new Worker("Derek","Regal",920.99,7),
            new Worker("Paul","Mc'Kent",600,8),
        };
        Console.WriteLine("Workers:\n");
        List<Student> orderStudents = students.OrderBy(x => x.FacultyNumber).ToList();
        List<Worker> orderWorkers = workers.OrderByDescending(x => x.MoneyPerhour()).ToList();
        foreach (var item in orderWorkers)
        {
            Console.WriteLine("{0} {1} - Money per hour: {2}",item.FirstName,item.LastName,item.MoneyPerhour());
        }
        Console.WriteLine();
        Console.WriteLine("Students:\n");
        foreach (var item in orderStudents)
        {
            Console.WriteLine("{0} {1} - Faculty number: {2}", item.FirstName, item.LastName, item.FacultyNumber);
        }
        Console.WriteLine("\nAll names:\n");
        var customCollection = (from student in students
                                select new
                                {
                                    firstName = student.FirstName,
                                    lastName = student.LastName
                                }
                                       ).Union(from workerr in workers
                                               select new
                                               {
                                                   firstName = workerr.FirstName,
                                                   lastName = workerr.LastName
                                               }).OrderBy(x => x.firstName).OrderBy(x => x.lastName);
        {
            foreach (var item in customCollection)
            {
                Console.WriteLine(item.firstName +" "+ item.lastName);
            }
        }
    }
}


