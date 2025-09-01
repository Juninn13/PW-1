
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace jr2ds.cs
{
    internal class Pessoa
    {
        private double peso; //criar variavel  //double, string ... = tipo da variavel
        public double altura;
        public double imc;
        private string nome;
        public string sexo;

        public void pedirsexo()
        {
            Console.WriteLine("Digite seu sexo");
            sexo = Console.ReadLine();
        }
        public void exibirsexo()
        {
            Console.WriteLine("Sexo: {0}\n", sexo);
        }
        public void pedirnome()
        {
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
        }
        public void exibirnome()
        {
            Console.WriteLine("Nome: {0}\n", nome);
        }
        public void pedirpeso() //variavel que que puxo do codigo
        {
            Console.WriteLine("Digite seu peso");
            peso = double.Parse(Console.ReadLine()); //Guardo a informacão
        }
        public void pediraltura()
        {
            Console.WriteLine("Digite sua altura");
            altura = double.Parse(Console.ReadLine());
             while (altura < 0.20)
            {
                Console.WriteLine("Altura Invalída");
                Console.WriteLine("Digite sua altura");
                altura = double.Parse(Console.ReadLine());
            }
        }
        public void calcularIMC()
        {
            imc = peso / (altura * altura); //calculo ()isola a opercão // ou cria uma variavel altura2, altura2 = math.pow (altura, 2 "2 nivel de elevação");
        }
        public void exibirIMC()
        { 
            Console.WriteLine("Seu IMC é:{0}\n", imc);//exibição para o usuario
        }
        public void tipoIMC()
        { 
            if (imc <= 18.5) //condição
            {
                Console.WriteLine("Você está a baixo do peso");
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine("você está saúdavel");
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("Você está acima do peso");
            }
            else if (imc >= 30 &&  imc <= 34.9)
            {
                Console.WriteLine("Você está no nível de obesidade grau I");
            }
            else if (imc >=35 && imc <= 39.9)
            {
                Console.WriteLine("Você está no nível de obesidade grau II");
            }
            else 
                Console.WriteLine("Você está no nível de obesidade grau III");
        }
    }
}
