using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Teste
{
    class Register
    {
        static Index indexinstance = new Index(); //aceder à classe index
        static Login loginindex = new Login(); //aceder à classe login
        static string firstInput; //primeiro input do user
        static string lastInput; //último input do user
        static string username; //guardar o username
        static string password; //guardar a password


        //começa aqui
        public void RegisterPage() {
            Start(); //chamar o método start
        }

        //aqui é a primeira página do register
        private void Start() {
            //start
            Console.WriteLine("\n Página de register \n");
            Console.WriteLine("\n Deseja registar, voltar para a página inicial ou fazer login? \n");
            Console.WriteLine("\n 1 - Registar \n");
            Console.WriteLine("\n 2 - Página Inicial \n");
            Console.WriteLine("\n 3 - Login \n");
            ///

            //input do user
            firstInput = Console.ReadLine();
            FirstChoice();
            //
        }

        //método para verificar o input do start
        private void FirstChoice() {

            //enviar o user para o register mesmo
            if(firstInput == "1") {
                RegisterInput();

            }

            //enviar o user de volta para o index
            else if (firstInput == "2") {
                indexinstance.Return();

            }

            //enviar o user para o login
            else if (firstInput == "3") {
                loginindex.LoginPage();

            }

            //chamar o método start de novo em caso de erro(para parecer um restart)
            else {
                Console.WriteLine("\n What? Tenta de novo \n");
                Start();
            }
        }

        //método onde vai pedir o input ao user
        private void RegisterInput() {
            Console.WriteLine("\n Vamos começar a registar !!!! \n");
            Console.WriteLine("\n Qual é o teu username? \n");
            username = Console.ReadLine();
            Console.WriteLine("\n Qual é a tua password? \n");
            password = Console.ReadLine();

            //nesta parte aqui vou fingir que está um robot a guardar
            //repito a mesma frase 3 vezes com o while
            int i = 0;
            while (i < 3) {
                Console.WriteLine("\n A guardar os dados bzzzz \n");
                System.Threading.Thread.Sleep(1000); //esperar 1 segundo
                i++; //incrementar
            }
            //quando o i chega a 3, aparece esta mensagem
            Console.WriteLine("\n Guardado! \n");
            System.Threading.Thread.Sleep(2000); //esperar 1 segundo
            LastInput();
            //
        }

        //método onde vai pedir o último input ao user
        private void LastInput() {
            Console.WriteLine("\n Onde deseja ir agora? \n");
            Console.WriteLine("\n 1 - Página Inicial \n");
            Console.WriteLine("\n 2 - Login \n");

            //input do user
            lastInput = Console.ReadLine();
            //

            //analisar o input do user
            if(lastInput == "1") {
                indexinstance.Return(); //enviar o user de volta à página inicial
            }
             else if (lastInput == "2") {
                loginindex.LoginPage(); //enviar o user ao login
            }
            else {
                Console.WriteLine("\n What? Tenta de novo \n");
                LastInput(); //chamar o método start de novo em caso de erro(para parecer um restart)
            }
            //
        }
    }
}
