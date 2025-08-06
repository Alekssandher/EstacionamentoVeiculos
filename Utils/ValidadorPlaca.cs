using System.Text.RegularExpressions;

namespace EstacionamentoVeiculos.Utils
{
    public static partial class ValidadorPlaca
    {
        private static readonly Regex regex = MyRegex();

        public static bool Validar(string? placa)
        {
            if (string.IsNullOrWhiteSpace(placa))
                return false;

            placa = placa.ToUpper();
            return regex.IsMatch(placa);
        }

        [GeneratedRegex(@"^[A-Z]{3}[0-9][A-Z0-9][0-9]{2}$", RegexOptions.Compiled)]
        private static partial Regex MyRegex();
    }
}