
namespace EstacionamentoVeiculos.Models
{
    public class Veiculo
    {
        public required string Placa { get; set; }
        public required Tipo VeiculoTipo { get; set; }
    }

    public enum Tipo
    {
        moto,
        carro,
        bicicleta
    }
}