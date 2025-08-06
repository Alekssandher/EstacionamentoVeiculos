
using EstacionamentoVeiculos.Models;
using EstacionamentoVeiculos.Services;
using EstacionamentoVeiculos.Utils;

namespace EstacionamentoVeiculos.Handlers
{
    public class Handler
    {
        private readonly Estacionamento es = new();
        internal void Cadastro()
        {
            var veiculo = CriarVeiculoViaUsuario();

            if (veiculo != null)
            {
                es.AdicionarVeiculo(veiculo);
                return;
            }
        }

        internal void Listar()
        {
            es.ListarVeiculos();
        }

        internal void Remover(string placa)
        {
            es.RemoverVeiculo(placa);
        }
        
    private static Veiculo? CriarVeiculoViaUsuario()
        {
            Console.Write("Digite a placa: ");
            var placa = Console.ReadLine()?.ToUpper().Replace("-", "").Replace(" ", "");
            
            if (!ValidadorPlaca.Validar(placa))
            {
                Console.WriteLine("Placa de Formato Inválido");
                return null;
            }


            Console.Write("Digite o tipo do veículo (carro/moto/bicicleta): ");
            var tipoStr = Console.ReadLine();

            if (Enum.TryParse<Tipo>(tipoStr, ignoreCase: true, out var tipo))
            {
                return new Veiculo { Placa = placa!, VeiculoTipo = tipo };
            }
            else
            {
                Console.WriteLine("Tipo inválido.");
                return null;
            }
        }
    }
}