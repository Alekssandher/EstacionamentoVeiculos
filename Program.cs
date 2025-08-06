
using EstacionamentoVeiculos.Handlers;
using EstacionamentoVeiculos.Utils;

namespace EstacionamentoVeiculos
{
    public partial class Program
    {
        public static void Main(string[] args)
        {
            bool exibirMenu = true;
            var h = new Handler();

            while (exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine("1 - Cadastrar veículo");
                Console.WriteLine("2 - Remover veículo");
                Console.WriteLine("3 - Listar veículos");
                Console.WriteLine("4 - Encerrar");

                switch (Console.ReadLine())
                {
                    case "1":
                        h.Cadastro();
                        break;

                    case "2":
                        Console.Write("Digite a placa: ");
                        var entrada = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(entrada))
                        {
                            Console.WriteLine("Placa inválida: valor vazio.");
                            break;
                        }

                        var placa = entrada.ToUpper();                        

                        if (!ValidadorPlaca.Validar(placa))
                        {
                            Console.WriteLine("Placa inválida: formato incorreto.");
                            break;
                        }

                        h.Remover(placa.Replace("-", "").Replace(" ", ""));
                
                        break;

                    case "3":
                        h.Listar();
                        break;

                    case "4":
                        exibirMenu = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("Pressione uma tecla para continuar");
                Console.ReadLine();
            }

            Console.WriteLine("O programa se encerrou");
        }
        
    }
    
}