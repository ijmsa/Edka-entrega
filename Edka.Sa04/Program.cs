using System;
using System.Collections.Generic;
using System.Linq;

namespace Edka.Sa04
{
    internal class Program
    {
        //Dados Mock (dados para teste)
        //Lista Genérica < >
        public static List<Despesa> despesas = new List<Despesa>
        {
            new Despesa{Descricao="Internet",Valor=100,Vencimento=new DateTime(2022,11,15)},
            new Despesa{Descricao="Gasolina",Valor=200,Vencimento=new DateTime(2022,11,11)},
            new Despesa{Descricao="Água",Valor=89,Vencimento=new DateTime(2022,11,02)},
            new Despesa{Descricao="Roupas",Valor=280,Vencimento=new DateTime(2022,11,20)},
            new Despesa{Descricao="Luz",Valor=120,Vencimento=new DateTime(2022,11,07)},

        };
        static void Main(string[] args)
        {
            //Filtro LINQ
            //from
            //in
            //select

            var despesasAbaixodeCem = from d in despesas //onde?
                                      where d.Valor < 300 //condição
                                      //orderby d.Vencimento //crescente
                                      orderby d.Vencimento descending
                                      select d;//selecione
            foreach (var item in despesasAbaixodeCem)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
