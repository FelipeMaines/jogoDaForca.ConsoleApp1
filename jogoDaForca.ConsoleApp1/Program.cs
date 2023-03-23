namespace jogoDaForca.ConsoleApp1
{
    internal class Program
    {
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
        static string strLetra,palavra;

        static char[] PegarPalavra()
        {
            Random numeroRand = new Random();
            palavra = palavras[numeroRand.Next(0, 31)];
            letras = palavra.ToCharArray();

            return letras;

        }

        static void MensagemErro(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }
        // FAZENDO UM BOOL P VERRIFICAR SE QUER CHUTAR OU CONTINUAR
        static bool ChutarPalavra()
        {
            Console.WriteLine("Deseja chutar a palavra: (S) (N)");

            
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
            if (contador == 5)
            {
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
                InputLetra();
                VerificarAcertouLetra();
                MostrarPalavra();
                contador++;
            }
        }


        
        
        static void Main(string[] args)
        {


            Console.ResetColor();
            PegarPalavra();
            FazerJogo();

        }
    }
}