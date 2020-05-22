using System;

namespace v5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Program");


            var user = "admin";
            var pass = "abc123";
            var trys = 3;
            var trysdoit = 0;
            while (true)
            {
                Console.Write("Ingrese usuario: ");
                var testUser = Console.ReadLine();
                Console.Write("\nIngrese password: ");
                var testPass = Console.ReadLine();
                trysdoit++;
                if (trysdoit == trys)
                {
                    Console.WriteLine("Se realizaron mas de los intentos permitidos.");
                    Environment.Exit(1);
                } 
                if (testUser == user && testPass == pass)
                {
                    break;
                }
                Console.WriteLine("Intento fallido, reintente por favor.");
            }
            
            Console.Clear();
            Console.WriteLine("1. ingrese vehiculo ");
            Console.WriteLine("2. listar vehiculos ");
            Console.WriteLine("3. Salir ");
            int option;
            string input = Console.ReadLine();
            int.TryParse(input, out option);
            switch (option)
            {
                case 1:
                    Console.Write("Ingrese numero de motor: ");
                    var idMotor = Console.ReadLine();
                    Console.Write("\n");
                    while(true)
                    {
                        Console.Write("Ingrese el motor: 2- para motores de dos tiempos y 4 para motores de 4 tiempos: ");
                        TypeEngine typeEngine = Console.ReadLine();
                        if (typeEngine == "2" || typeEngine == "4")
                        {
                            
                            break;
                        }
                        Console.WriteLine("Dato no valido, intente nuevamente.");
                    }
                    TypeEngine typeEngine = typeEngine == "2" ? 
                    TypeEngine.TWO_TIMES : TypeEngine.FOUR_TIMES;
                    Console.WriteLine("Ingrese año: ");
                    
                    break;
                case 2:
                    Console.WriteLine("Lista de vehiculos: ");
                    break;                    
                case 3:
                    Environment.Exit(0);
                    break;

            }


        }

    }

}
