// Fazer um sistema de registro e login
// pedir e-mail, usuário, e senha.
// verificar se no login bate com o registrado.




    
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Fazer um sistema de registro e login
			// pedir e-mail, usuário, e senha.
			// verificar se no login bate com o registrado.







			string escolha, confirmar, confirmare, tentar;
			string user, email, senha;
			string usere, emaile, senhae;
			usere = "";
			emaile = "";
			senhae = "";
			confirmar = "";
			confirmare = "";
			tentar = "";
			email = "";
			user = "";
			senha = "";

			do
			{
				Console.WriteLine("Bem-vindo, deseja se logar ou se registrar?");
				Console.Write("(logar/registrar): ");
				escolha = Console.ReadLine();

				if (escolha == "registrar" || escolha == "Registrar" || escolha == "Registrar-se" || escolha == "registrar-se")
				{
					Console.Clear();
					Console.WriteLine("===========");
					Console.WriteLine("Registre-se");
					Console.Write("Seu user: ");
					user = Console.ReadLine();
					Console.Write("Seu email: ");
					email = Console.ReadLine();
					Console.Write("Seu senha: ");
					senha = Console.ReadLine();
					Console.WriteLine("===========");
					Console.Write("deseja se Registrar?: ");
					confirmar = Console.ReadLine();

					if (confirmar == "sim" || confirmar == "Sim" || confirmar == "S" || confirmar == "s")
					{
						Console.Clear();
						Console.WriteLine("Registro realizado com sucesso!");

					}
				}
				else if (escolha == "logar" || escolha == "Logar" || escolha == "logar-se" || escolha == "Logar-se" || escolha == "login" || escolha == "Login")
				{
					Console.Clear();
					Console.WriteLine("===========");
					Console.WriteLine("Logar-se");
					Console.Write("User: ");
					usere = Console.ReadLine();
					Console.Write("Email: ");
					emaile = Console.ReadLine();
					Console.Write("Senha: ");
					senhae = Console.ReadLine();
					Console.WriteLine("===========");
					Console.Write("Deseja confirmar login(S/N)?: ");
					confirmare = Console.ReadLine();

					if (confirmare == "sim" && confirmare == "Sim" && confirmare == "S" && confirmare == "s")
					{
						if (emaile == email && usere == user && senhae == senha)
						{
							Console.WriteLine("Seu login foi bem sucedido, Bem-vindo!");
						}
						else
						{

							Console.Clear();
							Console.WriteLine("Seu login está incorreto, deseja tente novamente?");
							Console.Write("(S/N): ");
							tentar = Console.ReadLine();


							if (tentar == "Não" || tentar == "não" || tentar == "n" || tentar == "N")
							{
								Console.Clear();
								Console.WriteLine("===========");
								Console.WriteLine("(aperte Enter até fechar...)");
								Console.WriteLine("===========");
								Console.ReadKey();
							}
						}
					}
				}
			} while (true);


		}
	}
}
