using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Teste
{
    class Index {

        //variables
        static string userInput;
        static Login logininstance = new Login();
        static Register registerinstance = new Register();
        /// 

        static void Main(string[] args) {

        //start
        Console.WriteLine("Bem vindo a este programa! Onde quer ir? \n");
        Console.WriteLine("1 - Login \n");
        Console.WriteLine("2 - Register \n");
        //

        //user input
        userInput = Console.ReadLine();
        Console.WriteLine(userInput);
        Connect();
        //
        }

        private static void Connect() {
            if(userInput == "1") {
                Console.WriteLine("You're going to Login");
                logininstance.LoginPage();
            }
            else if (userInput == "2") {
                Console.WriteLine("You're going to Register");
                registerinstance.RegisterPage();
            }
            else {
                Console.WriteLine("What??? Try Again");
            }
        }
    }
}
