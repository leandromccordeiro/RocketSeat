namespace Exercicios
{
    public class Ex_03
    {
        public double Valor1 { get; set; }
        public double Valor2 { get; set; }

        public double Soma(double valor1, double valor2)
        {
            return valor1 + valor2;
        }
        public double Subtracao(double valor1, double valor2)
        {
            return valor1 - valor2;
        }
        public double Multiplicacao(double valor1, double valor2)
        {
            return valor1 * valor2;
        }
        public double Divisao(double valor1, double valor2)
        {
            return (float)valor1/valor2;
        }
        public double Media(double valor1, double valor2)
        {
            return (float) (valor1 + valor2)/2;
        }
    }
}
