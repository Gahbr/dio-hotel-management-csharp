// See https://aka.ms/new-console-template for more information

using Hotel_Management_DIO;

List<Pessoa> hospedes = new List<Pessoa>();
Pessoa p1 = new Pessoa(nome: "Passaro", "suke ");
Pessoa p2 = new Pessoa(nome: "Papa", "gaio ");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite("Premium", capacidade:3,valorDiaria:30);

Reserva reserva = new Reserva(10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");

Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");