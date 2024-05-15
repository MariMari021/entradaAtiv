using System;

namespace entradaDados
{
    class Entrada
    {
        static void Main(string[] args)
        {
            /*-----------------------------------------------------------*/

            /*------------------------EXERCICIO 1------------------------*/

            /*Console.WriteLine("Número do funcionário: ");

            int n_funcionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Número de horas trabalhadas: ");

            int horas_trabalhadas = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor que recebe por hora: ");

            int por_hora = int.Parse(Console.ReadLine());

            double salario = horas_trabalhadas * por_hora;

            Console.WriteLine("Nº do funcionário: " + n_funcionario + "\nSalário: R$" + salario);*/

            /*-----------------------------------------------------------*/

            /*------------------------EXERCICIO 2------------------------*/

            /* peça 1 *//*
            Console.WriteLine("Código da peça: ");
            int peca1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade: ");
            int pecaQuant1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Preço unitário: ");
            double pecaPreco1 = int.Parse(Console.ReadLine());


            *//* peça 2 *//*
            Console.WriteLine("Código da peça: ");
            int peca2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade: ");
            int pecaQuant2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Preço unitário: ");
            double pecaPreco2 = int.Parse(Console.ReadLine());

            double precoTotal1 = pecaPreco1 * pecaQuant1;
            double precoTotal2 = pecaPreco2 * pecaQuant2;

            Console.WriteLine("Total a pagar da peça " + peca1 + ": R$" + precoTotal1);
            Console.WriteLine("Total a pagar da peça " + peca2 + ": R$" + precoTotal2);*/

            /*-----------------------------------------------------------*/

            /*------------------------EXERCICIO 3------------------------*/

            /*Console.WriteLine("Qual o valor de A?");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor de B?");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor de C?");
            float c = float.Parse(Console.ReadLine());

            double area_triangulo = (a * c) / 2.0;
            double area_circulo = 3.14159 * (c * c);
            double area_trapezio = (a + b) / (2.0 * c);
            double area_quadrado = b * b;
            double area_retangulo = a * b;

            Console.WriteLine("Triângulo: " + area_triangulo +
                             "\nCírculo: " + area_circulo +
                             "\nTrapézio: " + area_trapezio +
                             "\nQuadrado: " + area_quadrado +
                             "\nRetângulo: " + area_retangulo);*/

            /*-----------------------------------------------------------*/

            /*-----------------------EXERCICIO 3.5-----------------------*/

            /*Console.WriteLine("Login: ");
            string login = Console.ReadLine();

            Console.WriteLine("Senha: ");
            int senha = int.Parse(Console.ReadLine());

            if (login == "admin" && senha == 1234)
            {
                Console.WriteLine("Pode acessar.");
            }
            else
            {
                Console.WriteLine("Login ou senha incorretos.");
            }*/

            /*-----------------------------------------------------------*/

            /*------------------------EXERCICIO 4------------------------*/

            /*Console.WriteLine("Blusas do estoque: ");
            int quantEstoque = int.Parse(Console.ReadLine());

            if (quantEstoque < 20)
            {
                Console.WriteLine("Estoque crítico.");
            }
            else if (quantEstoque >= 20 && quantEstoque <= 40)
            {
                Console.WriteLine("Atenção ao estoque.");
            }
            else
            {
                Console.WriteLine("Estoque ok.");
            }*/

            /*-----------------------------------------------------------*/

            /*-----------------------EXERCICIO 4.5-----------------------*/

            /*Console.WriteLine("Qual sua idade?");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual seu salário?");
            double salario = double.Parse(Console.ReadLine());

            if (idade >= 18 && salario >= 2000)
            {
                Console.WriteLine("Pode viajar.");
            }
            else
            {
                Console.WriteLine("Não pode viajar.");
            }*/

            /*-----------------------------------------------------------*/

            /*------------------------EXERCICIO 5------------------------*/

            /*Console.WriteLine("Digite 1 ou 2 para Desenho e Pintura." +
                "\nDigite 3 ou 4 para Discurso e Debate." +
                "\nOutro número para Dança.");
            int enquete = int.Parse(Console.ReadLine());

            if (enquete == 1 || enquete == 2) 
            {
                Console.WriteLine("Você escolheu:" +
                    "\nDESENHO E PINTURA.");
            }
            else if (enquete == 3 || enquete == 4) 
            {
                Console.WriteLine("Você escolheu:" +
                    "\nDISCURSO E DEBATE.");
            }
            else
            {
                Console.WriteLine("Você escolheu:" +
                    "\nDANÇA.");
            }*/

            /*-----------------------------------------------------------*/

            /*-----------------------EXERCICIO 5.5-----------------------*/

            /*Console.WriteLine("Escreva um número: ");
            float numero = float.Parse(Console.ReadLine());

            if (numero > 0 && numero >= 100)
            {
                Console.WriteLine("Número espacial.");
            }
            else
            {
                Console.WriteLine("Fora do intervalo.");
            }*/
        }
    }

}
