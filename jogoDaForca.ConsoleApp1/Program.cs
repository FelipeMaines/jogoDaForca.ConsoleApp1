namespace jogoDaForca.ConsoleApp1
{
    internal class Program
    {
        // Meu irmao ta como contribuidor porque fiz pelo noot dele, ai devo ter dado push com o git dele!
        #region declarandoVariaveis
        static string[] palavras = {
"ABACATE",
"ABACAXI",
 "ACEROLA",
 "AÇAÍ",
 "ARAÇA",
 "ABACATE",
 "BACABA",
 "BACURI",
 "BANANA",
 "CAJÁ",
 "CAJÚ",
 "CARAMBOLA",
 "CUPUAÇU",
 "GRAVIOLA",
 "GOIABA",
 "JABUTICABA",
 "JENIPAPO",
 "MAÇÃ",
 "MANGABA",
 "MANGA",
 "MARACUJÁ",
 "MURICI",
 "PEQUI",
 "PITANGA",
 "PITAYA",
 "SAPOTI",
 "TANGERINA",
 "UMBU",
 "UVA",
 "UVAIA" };
        static char[] letras = new char[10], palavraFeita = new char[10];
        static int quantidadeDeTentativas = 5,contador = 0;
        static char letraDigitada;
        static string strLetra,palavra,opcao,palavraChute;
        #endregion

        static void FazerDesenhoForca()
        {
            switch (contador)
            {
                case 0:
                    Console.Clear();
                    Console.WriteLine(" _________     ");
                    Console.WriteLine("|         |    ");
                    Console.WriteLine("|         O    ");
                    Console.WriteLine("|        /|\\  ");
                    Console.WriteLine("|        / \\  ");
                    Console.WriteLine("|              ");
                    Console.WriteLine("|______________\n");
                    break;

                case 1:
                    Console.Clear();
                    Console.WriteLine(" _________     ");
                    Console.WriteLine("|         |    ");
                    Console.WriteLine("|         O    ");
                    Console.WriteLine("|        /|    ");
                    Console.WriteLine("|        / \\  ");
                    Console.WriteLine("|              ");
                    Console.WriteLine("|______________\n");
                    MostrarPalavra();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine(" _________     ");
                    Console.WriteLine("|         |    ");
                    Console.WriteLine("|         O    ");
                    Console.WriteLine("|         |    ");
                    Console.WriteLine("|        / \\  ");
                    Console.WriteLine("|              ");
                    Console.WriteLine("|______________\n");
                    MostrarPalavra();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine(" _________     ");
                    Console.WriteLine("|         |    ");
                    Console.WriteLine("|         O    ");
                    Console.WriteLine("|         |    ");
                    Console.WriteLine("|        /     ");
                    Console.WriteLine("|              ");
                    Console.WriteLine("|______________\n");
                    MostrarPalavra();
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine(" _________     ");
                    Console.WriteLine("|         |    ");
                    Console.WriteLine("|         O    ");
                    Console.WriteLine("|              ");
                    Console.WriteLine("|              ");
                    Console.WriteLine("|              ");
                    Console.WriteLine("|______________\n");
                    MostrarPalavra();
                    break;

                default:
                    MensagemErro("ERRO!");
                    break;
            }

           
        }
        static char[] PegarPalavra()
        {
            Random numeroRand = new Random();
            palavra = palavras[numeroRand.Next(0, 31)];
            letras = palavra.ToCharArray();

            return letras; 

        }

        static void MensagemErro(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }
        static bool ChutarPalavra()
        {
            Console.WriteLine("\nDeseja chutar a palavra: (S) (N)");
            opcao = Console.ReadLine();

            if (opcao == "S" || opcao == "s") {
                Console.WriteLine("Qual a palavra que voce acha que eh: ");
                palavraChute = Console.ReadLine().ToUpper();

                if (palavraChute == palavra)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Parabens voce acertou!");
                    Console.ResetColor ();
                }
                else
                {
                    MensagemErro("Infelizmente voce errou!");
                    MensagemErro($"A palavra era {palavra}");
                }

                return true;
            }

            else if (opcao == "N" ||  opcao == "n") {
                return false;
            }

            return ChutarPalavra();
        }

        static char InputLetra()
        {
            Console.WriteLine("\nQual a letra: ");
            strLetra = Console.ReadLine().ToUpper();
            letraDigitada = char.Parse(strLetra);

            return letraDigitada;
        }

        static bool verificarTentativas()
        {
            if (contador == quantidadeDeTentativas)
            {
                MensagemErro("Infelizmente voce perdeu!");
                MensagemErro($"A palabra era {palavra}");
                return false;
            }

            else
            {
                return true;
            }
        }

        static void MostrarPalavra()
        {
            for (int i = 0; i < palavraFeita.Length; i++)
            {
                Console.Write(palavraFeita[i]);
            }
        }

        static char[] VerificarAcertouLetra()
        {
            for (int i = 0; i < letras.Length; i++)
            {
                if (letras[i] == letraDigitada)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    palavraFeita[i] = letraDigitada;
                    Console.ResetColor();
                    continue;
                }

                
                else if (letras[i] != letraDigitada)

                {
                    if (palavraFeita[i] == 0)
                    {
                        palavraFeita[i] = '_';
                        continue;
                    }
                    
                    else if (letras[i] == '_')
                    {
                        continue;
                    }
                    else
                    {
                        continue;
                    }

                  

                }

            }
            return palavraFeita;

        }

        static void FazerJogo()
        {
            while(verificarTentativas())
            {
                FazerDesenhoForca();
                InputLetra();
                VerificarAcertouLetra();
                MostrarPalavra();
                if (ChutarPalavra() == true)
                {
                    break;
                }
                

                contador++;
            }
        }
        static void Main(string[] args)
        {
            FazerDesenhoForca();
            PegarPalavra();
            FazerJogo();
        }
    }
}
