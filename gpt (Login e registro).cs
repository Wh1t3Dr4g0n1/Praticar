using System;

namespace Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string escolha, confirmar, tentar;
            string user = "", email = "", senha = "";
            string usere, emaile, senhae;
            DateTime dataNascimento;
            
            Console.WriteLine("Bem-vindo, deseja se logar ou se registrar?");
            Console.Write("(logar/registrar): ");
            escolha = Console.ReadLine().ToLower();

            if (escolha == "registrar")
            {
                Console.Clear();
                Console.WriteLine("===========");
                Console.WriteLine("Registre-se");
                Console.Write("Seu usuário: ");
                user = Console.ReadLine();
                Console.Write("Seu email: ");
                email = Console.ReadLine();
                Console.Write("Sua senha: ");
                senha = Console.ReadLine();

                Console.Write("Data de nascimento (dd/mm/aaaa): ");
                while (!DateTime.TryParse(Console.ReadLine(), out dataNascimento))
                {
                    Console.Write("Data inválida. Digite novamente (dd/mm/aaaa): ");
                }
                
                if (!VerificarMaioridade(dataNascimento))
                {
                    Console.WriteLine("Desculpe, você precisa ter pelo menos 18 anos para se registrar.");
                    return;
                }
                
                Console.WriteLine("===========");
                Console.Write("Deseja se registrar? (S/N): ");
                confirmar = Console.ReadLine().ToLower();

                if (confirmar == "s")
                {
                    Console.Clear();
                    Console.WriteLine("Registro realizado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Registro cancelado.");
                    return;
                }
            }

            Console.Write("Deseja fazer login? (S/N): ");
            if (Console.ReadLine().ToLower() != "s") return;

            do
            {
                Console.Clear();
                Console.WriteLine("===========");
                Console.WriteLine("Login");
                Console.Write("Usuário: ");
                usere = Console.ReadLine();
                Console.Write("Email: ");
                emaile = Console.ReadLine();
                Console.Write("Senha: ");
                senhae = Console.ReadLine();
                Console.WriteLine("===========");

                if (emaile == email && usere == user && senhae == senha)
                {
                    Console.WriteLine("Login bem-sucedido, bem-vindo!");
                    break;
                }
                else
                {
                    Console.WriteLine("Login incorreto, deseja tentar novamente? (S/N): ");
                    tentar = Console.ReadLine().ToLower();
                }
            } while (tentar == "s");
        }

        static bool VerificarMaioridade(DateTime dataNascimento)
        {
            int idade = DateTime.Today.Year - dataNascimento.Year;
            if (dataNascimento.Date > DateTime.Today.AddYears(-idade)) idade--;
            return idade >= 18;
        }
    }
}
