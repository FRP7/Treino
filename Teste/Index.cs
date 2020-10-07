using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Teste
{
    class Index {

        //variáveis
        static string userInput; //onde vai alojar o input do user
        static Login logininstance = new Login(); //aceder à classe Login
        static Register registerinstance = new Register(); //aceder à classe Register
        /// 

        //começa aqui
        static void Main(string[] args) { 
            Start(); //chama o método start
        }

        //é aqui a raiz deste index
        public static void Start() {
            //start
            Console.WriteLine("Bem vindo à Pagina Inicial ! Onde quer ir? \n");
            Console.WriteLine("1 - Login \n");
            Console.WriteLine("2 - Register \n");
            //
            //input do user
            userInput = Console.ReadLine();
            Connect();
            //
        }

        //método para verificar os inputs
        private static void Connect() {

            //enviar o user pa classe login se ele escrever 1
            if(userInput == "1") {
                Console.WriteLine("\n Vais para o Login \n\n\n");
                logininstance.LoginPage();
            }

            //enviar o user pa classe register se ele escrever 2
            else if (userInput == "2") {
                Console.WriteLine("\n Vais para o Register \n\n\n");
                registerinstance.RegisterPage();
            }

            //chamar o método start de novo em caso de erro (para parecer um restart)
            else {
                Console.WriteLine("\n What??? Tente de novo \n\n\n");
                Start();
            }
        }

        //em caso de querer voltar quando estou noutras classes
        public void Return() {
            Start();
        }
    }
}
