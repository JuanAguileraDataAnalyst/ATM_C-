namespace _07_ATM2
{
    internal class Program
    {
        static double NuevoBalanceP(double balanceInicial, double depositar)
        {
            return balanceInicial + depositar;
        }

        static double NuevoBalanceN(double balanceInicial, double retirar)
        {
            return balanceInicial - retirar;
        }

        static void Main(string[] args)
        {
            double balanceInicial = 1000;
            double retirar;
            double depositar;

            Console.WriteLine("Welcome to Scrum Fit ATM");
            Console.WriteLine("------------------------");

            // Loop
            int opcionDelUsuario = 0;
            do
            {
                Console.WriteLine("Selecione que opcion desea realizar el dia de hoy...");
                Console.WriteLine("1. Depositar");
                Console.WriteLine("2. Retirar");
                Console.WriteLine("3. Ver Balance");
                Console.WriteLine("4. Salir");
                try
                {
                    opcionDelUsuario = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Por favor, ingrese una opción válida.");
                    Console.WriteLine("-------------------------------------");

                    continue;
                }
                if (opcionDelUsuario == 1)
                {
                    // Depositar
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Que cantidad desea depositar?");
                    depositar = double.Parse(Console.ReadLine());
                    balanceInicial = NuevoBalanceP(balanceInicial, depositar);
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("Gracias por su deposito");
                    Console.WriteLine($"Su nuevo balance es de: {balanceInicial}");
                    Console.WriteLine("-----------------------------------------");

                }
                else if (opcionDelUsuario == 2)
                {
                    // Retirar
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("Que cantidad desea retirar?");
                    retirar = double.Parse(Console.ReadLine());
                    if (balanceInicial < retirar)
                    {
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("Saldo insuficiente, intente nuevamente");
                        Console.WriteLine("--------------------------------------");

                    }
                    else
                    {
                        balanceInicial = NuevoBalanceN(balanceInicial, retirar);
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("Gracias por su retiro, tenga un buen dia");
                        Console.WriteLine($"Su nuevo balance es de: {balanceInicial}");
                        Console.WriteLine("-----------------------------------------");
                    }
                }
                else if (opcionDelUsuario == 3)
                {
                    // Mostrar Balance
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine($"Su balance actual es de: {balanceInicial}");
                    Console.WriteLine("------------------------------------------");
                }
                else if (opcionDelUsuario == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Opción no válida, intente nuevamente.");
                    Console.WriteLine("-------------------------------------");

                }
            }
            while (opcionDelUsuario != 4);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Gracias! Ten un buen dia :)");
            Console.WriteLine("---------------------------");

        }
    }
}
