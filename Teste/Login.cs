using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Teste
{
    class Login
    {
        static Index indexinstance = new Index(); //aceder à classe Index
        static Register registerinstance = new Register(); //aceder à classe Register
        static string firstInput; //guardar o primeiro input do user
        static string username; //guardar o input do user name
        static string password; //guardar o input da password
        static bool isUserCorrect = false; //bool pa verificar se o username está correcto
        static bool isPassCorrect = false; //bool pa verificar se a password está correcta

        //começa aqui
        public void LoginPage() { 
            Start(); //chama o método start
        }

        //aqui é a primeira página do login
        private void Start() {
            //start
            Console.WriteLine("\n Página de Login \n");
            Console.WriteLine("Deseja fazer login ou voltar para a página inicial ou registar? \n");
            Console.WriteLine("1 - Login \n");
            Console.WriteLine("2 - Pagina inicial \n");
            Console.WriteLine("3 - Registar \n");
            //
            //input do user
            firstInput = Console.ReadLine();
            FirstChoice();
            //
        }

        //método para verificar o input do start
        private void FirstChoice() {

            //enviar o user para o login mesmo
            if(firstInput == "1") {
                Console.WriteLine("\n Vai começar o login \n");
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
                Console.WriteLine("\n What? Tenta de novo \n");
                Start();
            }
        }

        /// método onde vai pedir o input do user
        private void LoginInput() {
            Console.WriteLine("\n Qual é o teu username? \n");
            username = Console.ReadLine();
            Console.WriteLine("\n Qual é a tua password? \n");
            password = Console.ReadLine();
            LoginAnalysis(); //chamar o método para analisar o input
        }

        //método para analisar o input do user
        private void LoginAnalysis() {
            //nesta parte aqui vou fingir que está um robot a analisar
            //repito a mesma frase 3 vezes com o while
            int i = 0;
            while(i < 3) {
                Console.WriteLine("\n Analisar os dados bzzzz \n");
                System.Threading.Thread.Sleep(1000); //esperar 1 segundo
                i++; //incrementar
            }
            //quando o i chega a 3, aparece esta mensagem
            Console.WriteLine("\n Analisado! \n");
            //

            //verificar se o user e pass inseridos estão correctos e mudar bool se sim
            if(username == registerinstance.username) {
                isUserCorrect = true;
            }
            else {
                isUserCorrect = false;
            }

            if(password == registerinstance.password) {
                isPassCorrect = true;
            }
            else {
                isPassCorrect = false;
            }
            //

            //verificar se os bools estão correctos
            if(isUserCorrect == true && isPassCorrect == true) {
                Console.WriteLine("\n Cool! Access granted !!!! \n");
            }
            else {
                Console.WriteLine("\n Uma ou mais credenciais estão erradas. Tente de novo! \n");
                LoginInput(); //chamar o método login (assim parece que reiniciou
            }
            //
        }
    }
}
