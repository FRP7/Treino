using System;
using System.Collections.Generic;
using System.Text;

namespace Teste
{
    class Login
    {
        static Index indexinstance = new Index(); //aceder à classe Index
        static Register registerinstance = new Register(); //aceder à classe Register
        static string firstInput; //guardar o primeiro input do user


        public void LoginPage() {
            Start();
        }

        private void Start() {
            Console.WriteLine("Página de Login \n");
            Console.WriteLine("Deseja fazer login ou voltar para a página inicial ou registar? \n");
            Console.WriteLine("1 - Login \n");
            Console.WriteLine("2 - Pagina inicial \n");
            Console.WriteLine("3 - Registar \n");
            firstInput = Console.ReadLine();
            Console.WriteLine(firstInput);
            FirstChoice();
        }

        private void FirstChoice() {
            if(firstInput == "1") {
                Console.WriteLine("Vai começar o login \n");
                LoginInput();
            }
            else if(firstInput == "2") {
                indexinstance.Return();

            } else if (firstInput == "3") {
                registerinstance.RegisterPage();
            }
            else {
                Console.WriteLine("What? Tenta de novo \n");
                Start();
            }
        }

        private void LoginInput() {
            Console.WriteLine("Aqui vais meter as credenciais \n");
        }
    }
}
