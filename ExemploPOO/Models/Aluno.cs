using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa //<-- HERANÇA
    {
        public double Nota { get; set; }

       public override void Apresentar(){//POLIMORFISMO
        Console.WriteLine($"Aluno : {Nome}\nNota: {Nota}");
       }
    }
}