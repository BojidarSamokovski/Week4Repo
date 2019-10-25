using System;
using Registration.Models;
using Registration.DBContext;
namespace Registration.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var User = new User()
            {
                IdFuckYou = "laina",
                Email = "Laina",
                Password = "lainaa123"
            };
            var ctx = new RegistryContext();

            ctx.Users.Add(User);

            ctx.SaveChanges();

            Console.WriteLine("DONE"  );

        }
    }
}
