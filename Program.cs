using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Console.Write("Informe a quantidade de dias reservados: ");
int diasReservados = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe a quantidade de hóspedes: ");
int quantidadeHospedes = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < quantidadeHospedes; i++)
{
    Console.WriteLine($"Hóspede {i + 1}");
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Sobrenome: ");
    string sobrenome = Console.ReadLine();

    Pessoa hospede = new Pessoa(nome, sobrenome);

    hospedes.Add(hospede);
}

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 1, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");