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

        //começa aqui
        public void LoginPage() { 
            Start(); //chama o método start
        }

        //aqui é a primeira página do login
        private void Start() {
            //start
            Console.WriteLine("Página de Login \n");
            Console.WriteLine("Deseja fazer login ou voltar para a página inicial ou registar? \n");
            Console.WriteLine("1 - Login \n");
            Console.WriteLine("2 - Pagina inicial \n");
            Console.WriteLine("3 - Registar \n");
            //
            //input do user
            firstInput = Console.ReadLine();
            Console.WriteLine(firstInput);
            FirstChoice();
            //
        }

        //método para verificar o input do start
        private void FirstChoice() {

            //enviar o user para o login mesmo
            if(firstInput == "1") {
                Console.WriteLine("Vai começar o login \n");
                LoginInput();
            }

            //enviar o user de volta para o index
            else if(firstInput == "2") {
                indexinstance.Return();

            }

            //enviar o user para o register
            else if (firstInput == "3") {
                registerinstance.RegisterPage();
            }

            //chamar o método start de novo em caso de erro(para parecer um restart)
            else {
                Console.WriteLine("What? Tenta de novo \n");
                Start();
            }
        }

        /// método onde vai pedir o input do user
        private void LoginInput() {
            Console.WriteLine("Aqui vais meter as credenciais \n");
        }
    }
}
