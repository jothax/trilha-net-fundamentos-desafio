using System.Security.Cryptography.X509Certificates;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<Car> veiculos = new List<Car>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            //Adiciona na lista
            veiculos.Add(new Car(placa));
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            Car placa = new Car(Console.ReadLine());

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.LicensePlate.ToUpper() == placa.LicensePlate.ToUpper()))
            {
                
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                
                int horas = int.Parse(Console.ReadLine());

                decimal valorTotal = precoInicial + precoPorHora * horas;

                //Remove a placa digitada da lista de veículos
                veiculos.RemoveAll(x => x.LicensePlate == placa.LicensePlate);

                Console.WriteLine($"O veículo {placa.LicensePlate} foi removido e o preço total foi de: R$ {valorTotal}");           
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                //Realiza um laço de repetição, exibindo os veículos estacionados
                foreach (var item in veiculos)
                {
                    Console.WriteLine(item.LicensePlate);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
