using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa //<-- HERANÇA
    {
        public Aluno(string nome) : base(nome) //para atender o construtor da classe pai
        {

        }
        
        public double Nota { get; set; }

       public override void Apresentar(){//POLIMORFISMO
        Console.WriteLine($"Aluno : {Nome}\nNota: {Nota}");
       }
    }
}