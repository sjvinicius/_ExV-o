using System;

namespace _Viagens
{
    class Program
    {
        static void Main(string[] args)
        {

            // AGENCIA DE VIAGENS

            //Variaveis

            string pass;
            char option;
            int passeng = 5;
            string [] name = new string [passeng];
            string [] origin = new string [passeng];
            string [] dest = new string [passeng];
            int [] date = new int [passeng];

            // LOGIN

            do
            {
                Console.Write("Password: ");
                pass = Console.ReadLine();
                
            } while (pass != "12345"); 


            Console.Write("CADASTRAR PASSAGEM");

            Console.WriteLine("\nHá Quantos Passageiros?: ");
            passeng = int.Parse( Console.ReadLine() );

            // MENU
            
            do{

            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("\n[1] Cadastrar Passagem");
            Console.WriteLine("[2] Listar Passagens");
            Console.WriteLine("[0] Cancelar ");
            option = char.Parse( Console.ReadLine() );


            switch (option)
            {
                case '1':

                    
                    for (var i = 0; i < passeng; i++)
                    {

                        Console.WriteLine( $"\n\n PASSAGEIRO {i+1}");
                        Console.Write("\nNome: ");
                        name [i] = Console.ReadLine().ToUpper();
                        Console.Write("(UF) Origem: ");
                        origin [i] = Console.ReadLine().ToUpper();
                        Console.Write("(UF) Destino: ");
                        dest [i] = Console.ReadLine().ToUpper();
                        Console.Write("Data de Voo (ddmmyyyy): ");
                        date [i] = int.Parse( Console.ReadLine() );

                    }

                    break;
                    
                    case '2':
                    
                    for (var i = 0; i < passeng; i++)
                    {

                        Console.WriteLine( $"\n\n PASSAGEIRO {i+1}");
                        Console.WriteLine($"\nNome: {name[i]}");
                        Console.WriteLine($"Origem: {origin[i]}");
                        Console.WriteLine($"Destino: {dest[i]}");
                        Console.WriteLine($"Data de Voo (ddmmyyyy): {date[i]}");

                    }

                    break;

                case '0':

                    Console.Write("CANCELAR");

                    break;

                default:

                    Console.Write("CANCELAR");
                    
                    break;
            }
            
            } while (option != '0');
            
        }
    }
}
