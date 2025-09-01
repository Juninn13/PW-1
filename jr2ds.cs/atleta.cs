using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jr2ds.cs
{
    internal class atleta
    {
        static void Main(string[] args)
        {
            Pessoa atleta; //aqui onde aciono o método
            atleta = new Pessoa();
            atleta.pedirsexo();
            atleta.pedirnome();
            atleta.pediraltura();
            atleta.pedirpeso();
            atleta.calcularIMC();
            atleta.exibirnome();
            atleta.exibirsexo();
            atleta.exibirIMC();
            atleta.tipoIMC();
        }


    }
}
