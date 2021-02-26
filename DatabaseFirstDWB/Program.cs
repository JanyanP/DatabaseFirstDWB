using System;

namespace DatabaseFirstDWB
{
    class Program
    {
        var dbContext = new NorthwindContext();

            var employeeQry = dbContext.Employees.Select(s => new
            {
                s.TitleOfCourtesy,
                s.FirstName,
                s.LastName
            }).Where(w => w.TitleOfCourtesy == "Mr.");

            var output = employeeQry.ToList();
            Console.WriteLine(output);
            output.ForEach(fe => Console.WriteLine("Nombre: " + fe.FirstName));
        }
      
        static void Main(string[] args)
        {
            Exciserse1();
        }
    }
}
