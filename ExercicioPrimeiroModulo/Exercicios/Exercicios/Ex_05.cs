using System.Text.RegularExpressions;

namespace Exercicios
{
    public class Ex_05
    {
        public string Placa { get; set; }

        public bool ValidaPlaca(string placa)
        {
            var caract = placa.Length;
            string str = placa.Substring(0, 3);
            var str2 = Regex.IsMatch(str, @"^[a-zA-Z]+$");
            string num = placa.Substring(3, 10);
            var num2 = Regex.IsMatch(num, @"^[0-9]+$");

            if (caract == 7 && str2 == true && num2 == true)
                {

                return true;
            
            }
            return false;
        }

    }

}
