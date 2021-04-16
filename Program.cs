using System;

namespace forca
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] valores = new string[10];
            valores[0] = "cavalo";
            valores[1] = "rinoceronte";
            valores[2] = "leopardo";
            valores[3] = "jaguatirica";
            valores[4] = "jabuti";
            valores[5] = "tubarao";
            valores[6] = "jacaré";
            valores[7] = "macaco";
            valores[8] = "pantera";
            valores[9] = "guaxinim";

            Random rand = new Random();
            int indice = rand.Next(0,10);

            string valorGeradoIA = valores[indice];

            char chuteDoJogador; 
            int tentativas = 0;
            char[] palavraAux = new char[valorGeradoIA.Length];


            for (int i = 0; i < valorGeradoIA.Length; i++)
            {
                palavraAux[i] = '*';
            }

            while(tentativas < 6)
            {
                Console.WriteLine("Estou pensando em um animal...poderia adivinhar?");

                Console.WriteLine(palavraAux);

                chuteDoJogador = Console.ReadLine()[0]; 

                for(int i = 0; i < valorGeradoIA.Length; i++)
                {
                    if(chuteDoJogador == valorGeradoIA[i] && chuteDoJogador != palavraAux[i])
                    {
                        palavraAux[i] = chuteDoJogador;
                        tentativas --;
                    }

                }
                tentativas++;

                if(checaVitoria())
                {
                    tentativas = 6;
                    Console.WriteLine(palavraAux);
                }

            }
            for(int i = 0; i < palavraAux.Length; i++)
            {
                if(palavraAux[i] == '*')
                {
                    Console.WriteLine("ERRADO!!! a palavra era "  + valores[indice]);
                    return;
                }
                
            }
            Console.WriteLine("ACERTOU!!!");

            bool checaVitoria()
            {
                for(int i = 0; i < palavraAux.Length; i++)
                {
                    if(palavraAux[i] == '*')
                    {
                        return false;
                    }
                    
                }
                return true;
            }
        }
    }
}
