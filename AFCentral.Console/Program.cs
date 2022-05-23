using System;

namespace AFCentral.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter your FirstName");
            var firstName = System.Console.ReadLine();
            System.Console.WriteLine("Please enter your SurName");
            var surname = System.Console.ReadLine();
            System.Console.WriteLine("Please enter your Printer code");
            var printerCode = System.Console.ReadLine();

            DataAccess.SqlServerAccess ssa = new DataAccess.SqlServerAccess(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AFCentral;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            System.Console.WriteLine(ssa.CallSP());


        }
    }
}
