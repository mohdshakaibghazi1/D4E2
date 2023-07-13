using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4E2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String username = "john";
            String password = "pass123";
            String username1;
            String password1;
            Console.WriteLine("enter username");
            username1=Console.ReadLine();
            password1=Console.ReadLine();
            var result = (username1 == username) && (password1 == password) ? "Login Successful" : "invalid password";
            Console.WriteLine(result); 
            Console.ReadKey();
        }
    }
}
