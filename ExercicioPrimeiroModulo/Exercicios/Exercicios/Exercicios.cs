using System;
using System.Security.AccessControl;

namespace Exercicios
{
    public class Exercicios()
    {
        public byte Exercicio { get; set; }
        static void Main(string[] args)
        {
                         
            Exercicios menu = new Exercicios();
            menu.Menu();
            menu.Exercicio = byte.Parse(Console.ReadLine());


            switch (menu.Exercicio)
            {
                case 1: Ex_01 ex_01 = new Ex_01();
                    Console.WriteLine("Digite o nome a ser impresso:");
                    ex_01.Nome = Console.ReadLine();
                    ex_01.ChamarNome(ex_01.Nome);
                    menu.Finalizacao();
                    break;
                case 2: Ex_02 ex_02 = new Ex_02();
                    Console.WriteLine("Digite o nome: ");
                    ex_02.Nome = Console.ReadLine();
                    Console.WriteLine("Digite o sobrenome");
                    ex_02.Sobrenome = Console.ReadLine();
                    ex_02.MontarNome(ex_02.Nome, ex_02.Sobrenome);
                    menu.Finalizacao();
                    break;
                case 3: Ex_03 ex_03 = new Ex_03();
                    Console.WriteLine("Digite o primeiro valor: ");
                    ex_03.Valor1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo valor: ");
                    ex_03.Valor2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Qual equacao deseja realizar?");
                    menu.MenuEquacoes();
                    string equacao = Console.ReadLine().ToLower();
                    double result = 0.0;
                    if (equacao == "soma")
                    {
                        result = ex_03.Soma(ex_03.Valor1, ex_03.Valor2);
                    }else if (equacao == "subtracao")
                    {
                        result = ex_03.Subtracao(ex_03.Valor1, ex_03.Valor2);
                    }else if (equacao == "divisao")
                    {
                        result = ex_03.Divisao(ex_03.Valor1, ex_03.Valor2);
                    }else if (equacao == "multiplicacao")
                    {
                        result = ex_03.Multiplicacao(ex_03.Valor1, ex_03.Valor2);
                    } else if (equacao == "media")
                    {
                        result = ex_03.Media(ex_03.Valor1, ex_03.Valor2);
                    } else { Console.WriteLine("Operador não identificado!"); }
                    Console.WriteLine($"O resultado da {equacao.ToUpper()} é: {result}");
                    break;
                case 4: Ex_04 ex_04 = new Ex_04();
                    Console.WriteLine("Digite um texto/palavra para contagem de caracteres: ");
                    ex_04.Texto = Console.ReadLine();
                    result = ex_04.ContarCarecteres(ex_04.Texto);
                    Console.WriteLine($"A quantidade de caracteres é: {result}");
                    break;

                case 5: Ex_05 ex_05 = new Ex_05();
                    Console.WriteLine("Digite a placa do veículo para validação: ");
                    ex_05.Placa = Console.ReadLine();
                    ex_05.ValidaPlaca(ex_05.Placa);
                    if (true)
                    {
                        Console.WriteLine("Placa dentro dos padrões");
                    } else {Console.WriteLine("Placa fora dos padrões"); }
                    break;
                case 0: 
                    break;
                default: Console.WriteLine("Você não informou o exercício! "); break;
            }



        }

        public void Menu()
        {
            Console.WriteLine("|---------------------------------------------------------------------------------|");
            Console.WriteLine("|--Digite o exercício que deseja executar(nrs de 1 a 6) ou 0 para sair:-----------|");
            Console.WriteLine("|---------------------------------------------------------------------------------|");                  
        }

        public void MenuEquacoes()
        {
            Console.WriteLine("|---------------------------------------------------------------------------------|");
            Console.WriteLine("|Escreva o nome da equação que deseja realizar:-----------------------------------|");
            Console.WriteLine("|Escreva: SOMA / SUBTRACAO / DIVISAO / MULTIPLICACAO / MEDIA----------------------|");
            Console.WriteLine("|---------------------------------------------------------------------------------|");
        }

        public void Finalizacao()
        {
            Console.WriteLine("|---------------------------------------------------------------------------------|");
            Console.WriteLine("|-----------------------------Programa finalizado!--------------------------------|");
            Console.WriteLine("|---------------------------------------------------------------------------------|");
        }
        
    }
}