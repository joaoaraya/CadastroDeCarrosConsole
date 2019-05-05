using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        public struct Carro
        {
            public string modelo, cor;
            public int ano;
        }

        static void Main(string[] args)
        {
            //VARIAVEIS
            int opcao;
            int n;

            //LOGO PERSONALIZADO
            var logo = new[]
            {
                @"                                 _________",
                @"                          _.--""'-----,   `''--.._",
                @"                       .-''   _/_      ; .'''----,`-,",
                @"                     .'      :___:     ; :      ;;`.`.",
                @"                    .      _.- _.-    .' :      ::  `..",
                @"                 __;..----------------' :: ___  ::   ;;",
                @"            .--"". '           ___.....`:=(___)-' :--'`",
                @"          .'   .'         .--''__       :       ==:    ;",
                @"      .--/    /        .'.''     ``-,   :          :   '`-.",
                @"   .''', :    /       .'-`\\       .--.\ :        :  ,   _\",
                @"  ;   ; |   ;       /:'  ;;      /__  \\:         :  :  /_\\",
                @"  |\_/  |   |      / \__//      /''--\\ \:        :  : ;|`\| ",
                @"  : '  /\  /\ ___ /   '''      /     \\ :        _:  : :|' | ",
                @"['''''''''--------........._  /      || ; __.:--'      :|//|",
                @" '------....______         ].'|      // |--''''__...-'`\ \//",
                @"   `| ETEC-DS |__;_...--'': :  \    //  |---'''      \__\_/",
                @"     ''''''''''            \ \  \_.//  /",
                @"       `---'                \ \_     _'       João Araya, 2018",
                @"                             `--`---'",

            };

            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (string logoText in logo) Console.WriteLine("   " + logoText);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n\n   ----- BEM-VINDO AO CADASTRO DE CARROS -----\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\t Quantos carros deseja cadastrar? ");
            n = int.Parse(Console.ReadLine());

            Carro[] carros = new Carro[n];

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n ------------------  MENU  ------------------ \n\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  1. Cadastrar carros ({0})\n", n);
                Console.Write("  2. Consultar carro por ano de fabricação\n");
                Console.Write("  3. Consultar carro por modelo\n");
                Console.Write("  4. Consultar carro por cor\n");
                Console.Write("  5. Exibir todos os carros cadastrados\n");
                Console.Write("  6. Alterar dados de um carro\n");
                Console.Write("  7. Excluir um carro\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("  0. Sair\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n -------------------------------------------- \n");
                Console.Write("\n\tDIGITE UMA OPÇÃO: ");
                opcao = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n");

                switch (opcao)
                {
                    case 1:
                        metodoCarroCadastrar(carros);
                        break;
                    case 2:
                        metodoCarroAno(carros);
                        break;
                    case 3:
                        metodoCarroModelo(carros);
                        break;
                    case 4:
                        metodoCarroCor(carros);
                        break;
                    case 5:
                        metodoCarroExibir(carros);
                        break;
                    case 6:
                        metodoCarroAlterar(carros);
                        break;
                    case 7:
                        metodoCarroExcluir(carros);
                        break;
                    case 0:
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tOPÇÃO INVÁLIDA!");
                        Console.Write("\tPressione uma tecla para voltar...");
                        Console.ReadKey();
                        break;
                }

            } while (opcao != 0);
        }

        static void metodoCarroCadastrar(Carro[] carros)
        {
            for (int x = 0; x < carros.Length; x++)
            {
                Console.Write("  Modelo: ");
                carros[x].modelo = Console.ReadLine();
                Console.Write("  Ano: ");
                carros[x].ano = int.Parse(Console.ReadLine());
                Console.Write("  Cor: ");
                carros[x].cor = Console.ReadLine();
                Console.Write("\n");
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  CARROS CADASTRADOS!");
            Console.Write("  Pressione uma tecla para voltar...");
            Console.ReadKey();
        }

        static void metodoCarroExibir(Carro[] carros)
        {
            for (int x = 0; x < carros.Length; x++)
            {
                if (carros[x].ano > 0)
                {
                    Console.WriteLine("  Modelo: {0}", carros[x].modelo);
                    Console.WriteLine("  Ano: {0}", carros[x].ano);
                    Console.WriteLine("  Cor: {0}", carros[x].cor);
                    Console.Write("\n");
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("  Pressione uma tecla para voltar...");
            Console.ReadKey();
        }

        static void metodoCarroAno(Carro[] carros)
        {
            int userAno;
            Console.Write("  Consultar carro pelo ano: ");
            userAno = int.Parse(Console.ReadLine());
            for (int x = 0; x < carros.Length; x++)
            {
                if (userAno == carros[x].ano)
                {
                    Console.WriteLine("\n  Modelo: {0}", carros[x].modelo);
                    Console.WriteLine("  Ano: {0}", carros[x].ano);
                    Console.WriteLine("  Cor: {0}\n", carros[x].cor);
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("  Pressione uma tecla para voltar...");
            Console.ReadKey();
        }

        static void metodoCarroModelo(Carro[] carros)
        {
            string userModelo;
            Console.Write("  Consultar carro pelo modelo: ");
            userModelo = Console.ReadLine();
            for (int x = 0; x < carros.Length; x++)
            {
                if (userModelo == carros[x].modelo)
                {
                    Console.WriteLine("\n  Modelo: {0}", carros[x].modelo);
                    Console.WriteLine("  Ano: {0}", carros[x].ano);
                    Console.WriteLine("  Cor: {0}\n", carros[x].cor);
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("  Pressione uma tecla para voltar...");
            Console.ReadKey();
        }

        static void metodoCarroCor(Carro[] carros)
        {
            string userCor;
            Console.Write("  Consultar carro pela cor: ");
            userCor = Console.ReadLine();
            for (int x = 0; x < carros.Length; x++)
            {
                if (userCor == carros[x].cor)
                {
                    Console.WriteLine("\n  Modelo: {0}", carros[x].modelo);
                    Console.WriteLine("  Ano: {0}", carros[x].ano);
                    Console.WriteLine("  Cor: {0}\n", carros[x].cor);
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("  Pressione uma tecla para voltar...");
            Console.ReadKey();
        }

        static void metodoCarroAlterar(Carro[] carros)
        {
            string altera, novoM, novoC;
            int opcao, novoA;

            Console.Write("  Modelo do carro: "); altera = Console.ReadLine();
            for (int x = 0; x < carros.Length; x++)
            {
                if (altera == carros[x].modelo)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n  Modelo: {0}", carros[x].modelo);
                    Console.WriteLine("  Ano: {0}", carros[x].ano);
                    Console.WriteLine("  Cor: {0}", carros[x].cor);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n  ---------- ALTERAR ----------\n");
                    Console.Write("    1. Modelo\n    2. Ano\n    3. Cor");
                    Console.Write("\n  ----------------------------- \n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n  DIGITE A OPÇÃO: ");
                    opcao = int.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("\n  Alterar modelo para: ");
                            novoM = Console.ReadLine();
                            carros[x].modelo = novoM;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n  MODELO ALTERADO!");
                            Console.Write("  Pressione uma tecla para voltar...");
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("\n  Alterar ano para: ");
                            novoA = int.Parse(Console.ReadLine());
                            carros[x].ano = novoA;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n  ANO ALTERADO!");
                            Console.Write("  Pressione uma tecla para voltar...");
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("\n  Alterar cor para: ");
                            novoC = Console.ReadLine();
                            carros[x].cor = novoC;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n  COR ALTERADA!");
                            Console.Write("  Pressione uma tecla para voltar...");
                            Console.ReadKey();
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\n  ----------------------------- \n");
                            Console.WriteLine("  OPÇÃO INVÁLIDA!");
                            Console.Write("  Pressione uma tecla para voltar...");
                            Console.ReadKey();
                            break;

                    }

                }
            }
        }


        static void metodoCarroExcluir(Carro[] carros)
        {
            string excluir;
            char confirmar;

            Console.Write("  Modelo do carro: ");
            excluir = Console.ReadLine();
            for (int x = 0; x < carros.Length; x++)
            {
                if (excluir == carros[x].modelo)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n  Modelo: {0}", carros[x].modelo);
                    Console.WriteLine("  Ano: {0}", carros[x].ano);
                    Console.WriteLine("  Cor: {0}", carros[x].cor);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n  Deseja excluir esse carro? S/N: ");
                    confirmar = char.Parse(Console.ReadLine());

                    if (confirmar == 's')
                    {
                        carros[x].modelo = "";
                        carros[x].ano = 0;
                        carros[x].cor = "";
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\n  CARRO EXCLUÍDO!");
                    }
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n  Pressione uma tecla para voltar...");
                Console.ReadKey();
            }
        }
    }
}
