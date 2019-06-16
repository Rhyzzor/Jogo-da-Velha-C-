using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc6
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux;
            int rodadas = 0;
            int jogador1 = 0;
            int jogador2 = 0;
            char[,] tabuleiroCasa = new char[3, 3];
            

            tabuleiroCasa[0, 0] = '1';
            tabuleiroCasa[0, 1] = '2';
            tabuleiroCasa[0, 2] = '3';

            tabuleiroCasa[1, 0] = '4';
            tabuleiroCasa[1, 1] = '5';
            tabuleiroCasa[1, 2] = '6';

            tabuleiroCasa[2, 0] = '7';
            tabuleiroCasa[2, 1] = '8';
            tabuleiroCasa[2, 2] = '9';

            do
            {


                Console.WriteLine("  {0}  |  {1}  |  {2}  ", tabuleiroCasa[0, 0], tabuleiroCasa[0, 1], tabuleiroCasa[0, 2]);
                Console.WriteLine("  {0}  |  {1}  |  {2}  ", tabuleiroCasa[1, 0], tabuleiroCasa[1, 1], tabuleiroCasa[1, 2]);
                Console.WriteLine("  {0}  |  {1}  |  {2}  ", tabuleiroCasa[2, 0], tabuleiroCasa[2, 1], tabuleiroCasa[2, 2]);

                if (rodadas % 2 == 0)
                {
                    Console.Write("É a vez do Jogador 1 (X). Digite o número desejado: ");
                    jogador1 = int.Parse(Console.ReadLine());
                    aux = jogador1;
                    Console.Clear();

                }
                else
                {


                    Console.Write("É a vez do Jogador 2 (O). Digite o número desejado: ");
                    jogador2 = int.Parse(Console.ReadLine());
                    aux = jogador2;
                    Console.Clear();
                }

                //Funções do Jogador 1
                if (aux < 1 || aux > 9)
                {
                    Console.WriteLine("Jogada inválida. Tente novamente.");
                    rodadas--;
                    Console.ReadKey();
                    Console.Clear();
                }
                else if(jogador1 == 1 && tabuleiroCasa[0,0] == '1')
                {
                    tabuleiroCasa[0, 0] = 'X';
                }
                else if (jogador1 == 2 && tabuleiroCasa[0, 1] == '2')
                {
                    tabuleiroCasa[0, 1] = 'X';
                }
                else if (jogador1 == 3 && tabuleiroCasa[0, 2] == '3')
                {
                    tabuleiroCasa[0, 2] = 'X';
                }
                else if (jogador1 == 4 && tabuleiroCasa[1, 0] == '4')
                {
                    tabuleiroCasa[1, 0] = 'X';
                }
                else if (jogador1 == 5 && tabuleiroCasa[1, 1] == '5')
                {
                    tabuleiroCasa[1, 1] = 'X';
                }
                else if (jogador1 == 6 && tabuleiroCasa[1, 2] == '6')
                {
                    tabuleiroCasa[1, 2] = 'X';
                }
                else if (jogador1 == 7 && tabuleiroCasa[2, 0] == '7')
                {
                    tabuleiroCasa[2, 0] = 'X';
                }
                else if (jogador1 == 8 && tabuleiroCasa[2, 1] == '8')
                {
                    tabuleiroCasa[2, 1] = 'X';
                }
                else if (jogador1 == 9 && tabuleiroCasa[2, 2] == '9')
                {
                    tabuleiroCasa[2, 2] = 'X';
                }

                //Validação de Casa Ocupada por O
                 if  (jogador1 == 1 && tabuleiroCasa[0, 0] == 'O')
                {
                    Console.WriteLine("A casa está ocupada. Digite novamente.");
                    rodadas--;
                }
                else if (jogador1 == 2 && tabuleiroCasa[0, 1] == 'O')
                {
                    Console.WriteLine("A casa está ocupada. Digite novamente.");
                    rodadas--;
                }
                else if (jogador1 == 3 && tabuleiroCasa[0, 2] == 'O')
                {
                    Console.WriteLine("A casa está ocupada. Digite novamente.");
                    rodadas--;
                }
                else if (jogador1 == 4 && tabuleiroCasa[1, 0] == 'O')
                {
                    Console.WriteLine("A casa está ocupada. Digite novamente.");
                    rodadas--;
                }
                else if (jogador1 == 5 && tabuleiroCasa[1, 1] == 'O')
                {
                    Console.WriteLine("A casa está ocupada. Digite novamente.");
                    rodadas--;
                }
                else if (jogador1 == 6 && tabuleiroCasa[1, 2] == 'O')
                {
                    Console.WriteLine("A casa está ocupada. Digite novamente.");
                    rodadas--;
                }
                else if (jogador1 == 7 && tabuleiroCasa[2, 0] == 'O')
                {
                    Console.WriteLine("A casa está ocupada. Digite novamente.");
                    rodadas--;
                }
                else if (jogador1 == 8 && tabuleiroCasa[2, 1] == 'O')
                {
                    Console.WriteLine("A casa está ocupada. Digite novamente.");
                    rodadas--;
                }
                else if (jogador1 == 9 && tabuleiroCasa[2, 2] == 'O')
                {
                    Console.WriteLine("A casa está ocupada. Digite novamente.");
                    rodadas--;
                }

                //Combinações para Ganhar na Horizontal- Jogador 1

                if(tabuleiroCasa[0,0] == 'X' && tabuleiroCasa[0,1] == 'X' && tabuleiroCasa[0,2] == 'X')
                {
                    Console.WriteLine("Parabéns, o Jogador 1 VENCEU!");
                    break;
                }
                else if (tabuleiroCasa[1, 0] == 'X' && tabuleiroCasa[1, 1] == 'X' && tabuleiroCasa[1, 2] == 'X')
                {
                    Console.WriteLine("Parabéns, o Jogador 1 VENCEU!");
                    break;
                }
                else if (tabuleiroCasa[2, 0] == 'X' && tabuleiroCasa[2, 1] == 'X' && tabuleiroCasa[2, 2] == 'X')
                {
                    Console.WriteLine("Parabéns, o Jogador 1 VENCEU!");
                    break;
                }

                //Combinações para Ganhar na Vertical- Jogador 1

                if (tabuleiroCasa[0, 0] == 'X' && tabuleiroCasa[1, 0] == 'X' && tabuleiroCasa[2,0] == 'X')
                {
                    Console.WriteLine("Parabéns, o Jogador 1 VENCEU!");
                    break;
                }
                else if (tabuleiroCasa[0, 1] == 'X' && tabuleiroCasa[1, 1] == 'X' && tabuleiroCasa[2, 1] == 'X')
                {
                    Console.WriteLine("Parabéns, o Jogador 1 VENCEU!");
                    break;
                }
                else if (tabuleiroCasa[0, 2] == 'X' && tabuleiroCasa[1, 2] == 'X' && tabuleiroCasa[2, 2] == 'X') 
                {
                    Console.WriteLine("Parabéns, o Jogador 1 VENCEU!");
                    break;
                }

                //Combinações para Ganhar na Diagonal - Jogador 1

                if(tabuleiroCasa[0,0] == 'X' && tabuleiroCasa[1,1] == 'X' && tabuleiroCasa[2,2] == 'X')
                {
                    Console.WriteLine("Parabéns, o Jogador 1 VENCEU!");
                    break;
                }
                if (tabuleiroCasa[0, 2] == 'X' && tabuleiroCasa[1, 1] == 'X' && tabuleiroCasa[2, 0] == 'X')
                {
                    Console.WriteLine("Parabéns, o Jogador 1 VENCEU!");
                    break;
                }

                //Funções para o Jogador 2
                
                else if (jogador2 == 1 && tabuleiroCasa[0, 0] == '1')
                {
                    tabuleiroCasa[0, 0] = 'O';
                }
                else if (jogador2 == 2 && tabuleiroCasa[0, 1] == '2')
                {
                    tabuleiroCasa[0, 1] = 'O';
                }
                else if (jogador2 == 3 && tabuleiroCasa[0, 2] == '3')
                {
                    tabuleiroCasa[0, 2] = 'O';
                }
                else if (jogador2 == 4 && tabuleiroCasa[1, 0] == '4')
                {
                    tabuleiroCasa[1, 0] = 'O';
                }
                else if (jogador2 == 5 && tabuleiroCasa[1, 1] == '5')
                {
                    tabuleiroCasa[1, 1] = 'O';
                }
                else if (jogador2 == 6 && tabuleiroCasa[1, 2] == '6')
                {
                    tabuleiroCasa[1, 2] = 'O';
                }
                else if (jogador2 == 7 && tabuleiroCasa[2, 0] == '7')
                {
                    tabuleiroCasa[2, 0] = 'O';
                }
                else if (jogador2 == 8 && tabuleiroCasa[2, 1] == '8')
                {
                    tabuleiroCasa[2, 1] = 'O';
                }
                else if (jogador2 == 9 && tabuleiroCasa[2, 2] == '9')
                {
                    tabuleiroCasa[2, 2] = 'O';
                }

                //Validação de Casa Ocupada por X
                if (jogador2 == 1 && tabuleiroCasa[0, 0] == 'X')
                {
                    Console.WriteLine("A casa está ocupada. Digite novamente.");
                    rodadas--;
                }
                else if (jogador2 == 2 && tabuleiroCasa[0, 1] == 'X')
                {
                    Console.WriteLine("A casa está ocupada. Digite novamente.");
                    rodadas--;
                }
                else if (jogador2 == 3 && tabuleiroCasa[0, 2] == 'X')
                {
                    Console.WriteLine("A casa está ocupada. Digite novamente.");
                    rodadas--;
                }
                else if (jogador2 == 4 && tabuleiroCasa[1, 0] == 'X')
                {
                    Console.WriteLine("A casa está ocupada. Digite novamente.");
                    rodadas--;
                }
                else if (jogador2 == 5 && tabuleiroCasa[1, 1] == 'X')
                {
                    Console.WriteLine("A casa está ocupada. Digite novamente.");
                    rodadas--;
                }
                else if (jogador2 == 6 && tabuleiroCasa[1, 2] == 'X')
                {
                    Console.WriteLine("A casa está ocupada. Digite novamente.");
                    rodadas--;
                }
                else if (jogador2 == 7 && tabuleiroCasa[2, 0] == 'X')
                {
                    Console.WriteLine("A casa está ocupada. Digite novamente.");
                    rodadas--;
                }
                else if (jogador2 == 8 && tabuleiroCasa[2, 1] == 'X')
                {
                    Console.WriteLine("A casa está ocupada. Digite novamente.");
                    rodadas--;
                }
                else if (jogador2 == 9 && tabuleiroCasa[2, 2] == 'X')
                {
                    Console.WriteLine("A casa está ocupada. Digite novamente.");
                    rodadas--;
                }

                //Combinações para Ganhar na Horizontal- Jogador 2

                if (tabuleiroCasa[0, 0] == 'O' && tabuleiroCasa[0, 1] == 'O' && tabuleiroCasa[0, 2] == 'O')
                {
                    Console.WriteLine("Parabéns, o Jogador 2 VENCEU!");
                    break;
                }
                else if (tabuleiroCasa[1, 0] == 'O' && tabuleiroCasa[1, 1] == 'O' && tabuleiroCasa[1, 2] == 'O')
                {
                    Console.WriteLine("Parabéns, o Jogador 2 VENCEU!");
                    break;
                }
                else if (tabuleiroCasa[2, 0] == 'O' && tabuleiroCasa[2, 1] == 'O' && tabuleiroCasa[2, 2] == 'O')
                {
                    Console.WriteLine("Parabéns, o Jogador 2 VENCEU!");
                    break;
                }

                //Combinações para Ganhar na Vertical- Jogador 2

                if (tabuleiroCasa[0, 0] == 'O' && tabuleiroCasa[1, 0] == 'O' && tabuleiroCasa[2, 0] == 'O')
                {
                    Console.WriteLine("Parabéns, o Jogador 2 VENCEU!");
                    break;
                }
                else if (tabuleiroCasa[0, 1] == 'O' && tabuleiroCasa[1, 1] == 'O' && tabuleiroCasa[2, 1] == 'O')
                {
                    Console.WriteLine("Parabéns, o Jogador 2 VENCEU!");
                    break;
                }
                else if (tabuleiroCasa[0, 2] == 'O' && tabuleiroCasa[1, 2] == 'O' && tabuleiroCasa[2, 2] == 'O')
                {
                    Console.WriteLine("Parabéns, o Jogador 2 VENCEU!");
                    break;
                }

                //Combinações para Ganhar na Diagonal - Jogador 2

                if (tabuleiroCasa[0, 0] == 'O' && tabuleiroCasa[1, 1] == 'O' && tabuleiroCasa[2, 2] == 'O')
                {
                    Console.WriteLine("Parabéns, o Jogador 2 VENCEU!");
                    break;
                }
                if (tabuleiroCasa[0, 2] == 'O' && tabuleiroCasa[1, 1] == 'O' && tabuleiroCasa[2, 0] == 'O')
                {
                    Console.WriteLine("Parabéns, o Jogador 2 VENCEU!");
                    break;
                }

                rodadas++;
            } while (rodadas < 9);
               if(rodadas == 9)
            {
                Console.WriteLine("Empate! ");
            }
            Console.WriteLine("Aperte alguma tecla para sair...");
            Console.ReadKey();
            
        }
    }
}
