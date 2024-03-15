namespace Exercicios
{
    public class Ex_02
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public void MontarNome(string nome, string sobrenome)
        {
            Console.WriteLine($"O nome é: {nome} {sobrenome}");
        }
    }
}
