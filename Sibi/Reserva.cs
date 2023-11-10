using System;
using System.Collections.Generic;

public partial class Reserva
{
    public string? NomeHospede { get; set; }

    public string? IdHospede { get; set; }

    public string? CpfHospede { get; set; }
  

    public static List<Reserva> reservas = new List<Reserva>();

    /*public static void MostrarReservas()
    {
        Console.WriteLine("Reservas Registradas:");
        foreach (var reserva in reservas)
        {
            Console.WriteLine($"Hóspede: {reserva.NomeHospede}, CPF: {reserva.CpfHospede}, Id: {reserva.IdHospede}");
        }
    }*/

    public static void ConsultarReservaPorId()
    {
        Console.Write("Digite o ID da reserva a ser consultada: ");
        string idConsulta = Console.ReadLine();

        Reserva reservaEncontrada = reservas.Find(reserva => reserva.IdHospede == idConsulta);

        if (reservaEncontrada != null)
        {
            Console.WriteLine($"Reserva encontrada para o ID {idConsulta}:");
            Console.WriteLine($"Hóspede: {reservaEncontrada.NomeHospede}, CPF: {reservaEncontrada.CpfHospede}");

            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Editar Reserva");
            Console.WriteLine("2. Excluir Reserva");
            Console.WriteLine("3. Retornar ao Menu Inicial");

            Console.Write("Escolha uma opção (1-3): ");
            int opcaoMenuReserva;
            if (int.TryParse(Console.ReadLine(), out opcaoMenuReserva))
            {
                switch (opcaoMenuReserva)
                {
                    case 1:
                        EditarReserva(reservaEncontrada);
                        break;
                    case 2:
                        ExcluirReserva(reservaEncontrada);
                        break;
                    case 3:
                        // Retorna ao Menu Inicial, não precisa fazer nada aqui
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Retornando ao Menu Inicial.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Por favor, digite um número válido. Retornando ao Menu Inicial.");
            }
        }
        else
        {
            Console.WriteLine($"Nenhuma reserva encontrada para o ID {idConsulta}.");
        }
    }

    // Adicione os seguintes métodos à classe Reserva
    public static void EditarReserva(Reserva reserva)
    {
        Console.WriteLine("Editar Reserva:");
        Console.Write("Novo Nome do Hóspede: ");
        reserva.NomeHospede = Console.ReadLine();
        Console.Write("Novo CPF do Hóspede: ");
        reserva.CpfHospede = Console.ReadLine();
        Console.WriteLine("Reserva editada com sucesso!");
    }

    public static void ExcluirReserva(Reserva reserva)
    {
        reservas.Remove(reserva);
        Console.WriteLine("Reserva excluída com sucesso!");
    }

    public void CadastrarReserva()
    {
        Reserva novaReserva = new Reserva();
        Console.Write("Id do Hóspede: ");
        novaReserva.IdHospede = Console.ReadLine();
        Console.Write("Nome do Hóspede: ");
        novaReserva.NomeHospede = Console.ReadLine();
        Console.Write("CPF do Hóspede: ");
        novaReserva.CpfHospede = Console.ReadLine();
        // Pode adicionar lógica para as outras propriedades
        reservas.Add(novaReserva);
        Console.WriteLine("Reserva cadastrada com sucesso!");
    }
}
