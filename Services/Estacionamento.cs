using EstacionamentoVeiculos.Models;

namespace EstacionamentoVeiculos.Services
{
    public class Estacionamento
    {
        private readonly List<Veiculo> veiculos = [];

        internal void AdicionarVeiculo(Veiculo veiculo)
        {
            if (veiculos.Any(v => v.Placa == veiculo.Placa))
            {
                Console.WriteLine("Veículo já está estacionado.");
                return;
            }

            veiculos.Add(veiculo);
            
            Console.WriteLine("Veículo adicionado com sucesso.");
        }

        public void RemoverVeiculo(string placa)
        {            
            var veiculo = veiculos.FirstOrDefault(v => v.Placa == placa);

            if (veiculo == null)
            {
                Console.WriteLine("Veículo não encontrado.");
                return;
            }

            veiculos.Remove(veiculo);

            Console.WriteLine("Veículo removido.");
        }

        public void ListarVeiculos()
        {
            if (veiculos.Count == 0)
            {
                Console.WriteLine("Nenhum veículo estacionado.");
                return;
            }

            Console.WriteLine("Veículos estacionados:");
            foreach (var v in veiculos)
            {
                Console.WriteLine($"- {v.Placa} ({v.VeiculoTipo})");
            }
        }
    }
}