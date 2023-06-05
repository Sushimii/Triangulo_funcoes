using System;
//Puxando todas as bibliotecas basicas
using System.Globalization;

namespace Course
{
    //criando classe
    public class Program
    {


        public static void Main(string[] args)
        {
            //Criando um array para medidas de X
            double[] medidasX = LerMedidasTriangulo("X");
            //Criando um array para medidas de Y
            double[] medidasY = LerMedidasTriangulo("Y");

            //Criando variavel para area do triangulo X
            double areaX = CalcularAreaTriangulo(medidasX);
            //Criando variavel para area do triangulo Y
            double areaY = CalcularAreaTriangulo(medidasY);

            //Menagem para o usuario mostrando o valor da área do triângulo X para o usuario
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            //Menagem para o usuario mostrando o valor da área do triângulo Y para o usuario
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            //Condição se o valor da variavel "areaX" for maior que valor da variavel "areaY" 
            if (areaX > areaY)
            {
                //Mensagem caso a condição acima for cumprida
                Console.WriteLine("Maior área: X");
            }
            //Condição se não
            else
            {
                //Mensagem caso a condição acima for cumprida
                Console.WriteLine("Maior área: Y");
            }

        }

        //Criando metodo para ler os valores que o usuario vai digitar
        public static double[] LerMedidasTriangulo(string nomeTriangulo)
        {
            //Criando variavel generica para armazenar os dados digitados pelo usuario , a variavel é um array e tem tamanho de 3 espaços
            double[] medidas = new double[3];

            //Mensagem para o usuario entrar com os valores que vao ser armazenados
            Console.WriteLine("Entre com as medidas do triângulo " + nomeTriangulo + ":");
            //Função "para" , que vai funcionar para o usuario conseguir armazenar 3 valores a variavel
            for (int i = 0; i < 3; i++)
            {
                //ler os valores que o usario digitou
                medidas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }
            //Parar a execução do metodo e retornar o valor a variavel "medidas"
            return medidas;
        }

        //Metodo para calcular a area do triangulo
        public static double CalcularAreaTriangulo(double[] medidas)
        {
            //criando uma variavel tipo double que vai armazenar o valor da variavel "medidas" da coluna 0
            double a = medidas[0];
            //criando uma variavel tipo double que vai armazenar o valor da variavel "medidas" da coluna 1
            double b = medidas[1];
            //criando uma variavel tipo double que vai armazenar o valor da variavel "medidas" da coluna 2
            double c = medidas[2];

            //criando uma variavel que ira armazenar o valor das 3 variaveis somadas e divididas por 2
            double p = (a + b + c) / 2.0;
            //Calculando a are do triangulo atraves da formula de Heron
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            //Parar a execução do programa e retornar o valor a variavel area
            return area;
        }
    }    
}



