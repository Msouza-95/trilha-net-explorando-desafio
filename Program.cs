using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// lista de hospedes
List<Pessoa> hospedes = new List<Pessoa>();

// instancia de reserva 
Reserva reserva = new Reserva(diasReservados: 0);


 Suite suite = new Suite();

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Criar suite");
    Console.WriteLine("2 - Cadastrar hóspedes ");
    Console.WriteLine("3 - Realizar reserva ");
    Console.WriteLine("4 - Exibe a quantidade de hóspedes e o valor da diária");
    Console.WriteLine("5 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine("Digite o tipo da suite");
            string tipoSuite = Console.ReadLine(); 

            Console.WriteLine($"Digite a capacidade da suite {tipoSuite}");
            int capacidade = int.Parse(Console.ReadLine()); 

            Console.WriteLine($"Digite o valor da diaria da suite {tipoSuite}");
            decimal valorDiaria = decimal.Parse(Console.ReadLine());
            suite.TipoSuite = tipoSuite;
            suite.Capacidade = capacidade;
            suite.ValorDiaria= valorDiaria;
            break;

        case "2":
            Console.WriteLine("Digite a quantidade de hóspedes que deseja cadsatrar");
            int quantidade = int.Parse(Console.ReadLine());

            // Cria os modelos de hóspedes e cadastra na lista de hóspedes
            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Digite o nome do {i+1}º  hóspedes ");
                string nome = Console.ReadLine();
                Pessoa pessoa = new Pessoa(nome);  
                hospedes.Add(pessoa);  
            }
            break;

        case "3":
            Console.WriteLine("Digite a quantidade de dias deseja reservar na suite");
            int dias = int.Parse(Console.ReadLine());
            reserva.CadastrarSuite(suite);
            reserva.DiasReservados = dias; 
            reserva.CadastrarHospedes(hospedes);
            break;

        case "4":
            Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
            Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
            break;

        case "5":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}










// Exibe a quantidade de hóspedes e o valor da diária
