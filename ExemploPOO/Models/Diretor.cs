using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{ //TESTES SEALED
    public class Diretor : Professor
    {
        public override void Apresentar(){ //POLIMORFISMO
            Console.WriteLine($" Sou dIRETOR, meu nome é {Nome} e meu salário é de: {Salario:C}");
        } 
    }
}