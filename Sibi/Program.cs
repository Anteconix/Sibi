using System;

class Program
{
    static void Main()
    {
        int escolha;

        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Cadastro de Reservas/Hospedes");
            Console.WriteLine("2. Controle de reservas/hospedagem");
            Console.WriteLine("3. Controle de estoque");
            Console.WriteLine("4. Serviços");
            Console.WriteLine("5. Pagamentos");

            Console.Write("Escolha uma opção (1-5): ");

            if (int.TryParse(Console.ReadLine(), out escolha))
            {
                Console.Clear(); // Limpa a tela

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Cadastro de Reservas/Hospedes: ");
                        Reserva reserva = new Reserva();
                        reserva.CadastrarReserva();
                        break;
                    case 2:
                        Console.WriteLine("Controle de Reservas/Hospedagem: ");
                        Reserva.ConsultarReservaPorId();
                        break;
                    // Adicione os cases para as outras opções aqui
                    case 5:
                        Console.WriteLine("Saindo do programa. Até mais!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear(); // Limpa a tela antes de mostrar o próximo menu
            }
            else
            {
                Console.WriteLine("Por favor, digite um número válido.");
            }

        } while (escolha != 5);
    }
}
