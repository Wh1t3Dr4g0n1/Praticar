// Crie um progama que solicite do usuario os seguintes dados:
// - nome
// - rg
// - cpf
// - idade
// - sexo
// - estado civil
// - salario bruto
//
// Calcule:
// - Desconto de 11% de INSS
// - Desconto de 5% de Conv. Médico
// - Desconto de Vale Transporte
// - Salário Línquido
//
// Obs: Se o funcinário do sexo "Masculino" 
// acrescente 1000,00 no Salário Línquido, caso 
// contrário acrescente 800,00 no Salário Línquido.
//
// Algoritmo
//
// 1. Início
// 2. var nome,rg, cpf, EC (estado civil), sexo: carater
//    var idade: inteiro
//    var SB (Salário Bruto),INSS, CM (Conv. Médico), VT (Vale Transporte), SL (Salário Línquido): real
// 3. Leia nome
// 4. Leia  rg
// 5. Leia cpf
// 6. Leia idade
// 7. Leia EC
// 8. Leia sexo
// 9. Leia SB
// 10. INSS = SB * 0.11
// 11. Mostre INSS
// 12. CM = SB * 0.06
// 13. Mostre CM
// 14. VT = SB * 0.06
// 15. Mostre VT
// 16. SL = SB - (INSS+CM+VT)
// 17. Mostre SL
// 18. Se (sexo = "M")
//        SL = SL + 1000.00
//  	Senão
//	      SL = SL + 800.00






using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace meu_lindo
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

            Console.WriteLine("Bem-vindo, deseja se logar ou se registrar?");
            Console.Write("(logar/registrar");
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
                Console.Write("deseja se Registrar?");
                confirmar = Console.ReadLine();
            }

            if (confirmar == "sim" || confirmar == "Sim" || confirmar == "S" || confirmar == "s" || tentar == "s" || tentar == "sim" || tentar == "S" || tentar == "Sim" || escolha == "logar" || escolha == "Logar" || escolha == "logar-se" || escolha == "Logar-se" || escolha == "login" || escolha == "Login")
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
                Console.Write("Deseja confirmar login(S/N)?");
                confirmare = Console.ReadLine();
            }
            if (confirmare == "sim" && confirmare == "Sim" && confirmare == "S" && confirmare == "s" && emaile == email && usere == user && senhae == senha)
            {
                Console.WriteLine("Seu login foi bem sucedido, Bem-vindo!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Seu login está incorreto, deseja tente novamente?");
                Console.Write("(S/N): ");
                tentar = Console.ReadLine();
            }
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





