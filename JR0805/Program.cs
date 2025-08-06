using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JR0805
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //int conta;  //int (Numeros inteiros)
            //double saldo;  // double (numeoros decimais)
            //string nome;
            //string auxiliar;

            //Console.WriteLine("Digite seu nome:");
            //nome = Console.ReadLine();
            //Console.WriteLine("Digite sua conta:");
            //auxiliar = Console.ReadLine();
            //conta = int.Parse(auxiliar);
            //Console.WriteLine("Digite seu saldo:");
            //auxiliar = Console.ReadLine();
            //saldo = double.Parse(auxiliar);
            //Console.Clear();
            //Console.WriteLine("saldo: {0} da conta{1}", saldo, conta);
            //Console.WriteLine("saldo:" + saldo + "da conta" + conta);
            //Console.WriteLine("saldo: {0} da conta{1}", saldo, conta);
            //Console.WriteLine("Boa noite !"+nome);
            //Console.WriteLine("Sua conta{0} tem o saldo de :{1}" ,conta, saldo);
*/

            double peso;
            double altura;
            string nome;
            string auxiliar;
            double imc;

           // Console.WriteLine("Digite seu nome:");
           // nome = Console.ReadLine();
            Console.WriteLine("Digite seu peso:");
            auxiliar = Console.ReadLine();
            peso = double.Parse(auxiliar);
            Console.WriteLine("Digite sua altura:");
            auxiliar = Console.ReadLine();
            altura = double.Parse(auxiliar);
            Console.Clear();
            imc = peso / (altura * altura);

            Console.WriteLine("Seu IMC e de: {0}", imc);

            if (imc < 18.5)
        {
                Console.WriteLine("Abaixo do peso");
            }
                else if (imc >=18.5 && 24.9 < imc)
            {
                Console.WriteLine("Peso norlmal");
            }
                    else if (imc >= 25 && 29.9 < imc)
            {
                Console.WriteLine("Sobrepeso");
            }
                        else if (imc >= 30 && 34.9 < imc)
            {
                Console.WriteLine("Obesidade: Grau I");
            }
                            else if (imc >= 35 && 39.9 < imc)
            {  
                Console.WriteLine("Obesidade: Grau II");
            }
                                 if (imc > 35 && imc > 39.9) ;     
            {
                Console.WriteLine("Obesidade: Grau III (Obesidade GRAVE):");
            }
        }
        
        
        
    }
}
