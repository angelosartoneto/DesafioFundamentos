namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.Clear();
            Console.WriteLine("------- 1-CADASTRAR VEICULO -------\n");
            Console.Write("Digite a placa do veículo: ");
            veiculos.Add(Console.ReadLine());
            Console.WriteLine("\n**** Veiculo cadastrado! ******");
        }

        public void RemoverVeiculo()
        {
            Console.Clear();
            Console.WriteLine("------- 2-REMOVER VEÍCULO -------\n");
            string placa = "";

            Console.Write("Digite a placa do veículo: ");
            placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                int horas = 0;
                decimal valorTotal = 0;

                Console.Write("\nQuantidade de horas estacionado: ");
                horas = Convert.ToInt32(Console.ReadLine());

                valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(placa);

                Console.Write($"\nTOTAL A PAGAR: R${Math.Round(valorTotal, 2)}");

                Console.WriteLine($"\n\n*** Veículo {placa} removido com sucesso! ***");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            Console.Clear();
            Console.WriteLine("------- 3-LISTAR VEÍCULOS -------\n");
            if (veiculos.Any())
            {
                Console.WriteLine("Relatório de vagas x veículos: \n");

                int contador = 0;

                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine($"Vaga N°: {contador} | Placa/Veículo: {veiculo}");
                    contador++;
                }
            }
            else
            {
                Console.WriteLine("\nNão há veículos estacionados!");
            }
        }
    }
}