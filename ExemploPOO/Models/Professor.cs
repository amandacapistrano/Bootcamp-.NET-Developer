using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public Professor(){
            
        }
        public Professor(string nome) : base(nome) //para atender o construtor da classe pai Pessoa
        {

        }
        public decimal Salario { get; set; }

        public override void Apresentar(){ //POLIMORFISMO
            Console.WriteLine($" Sou professor, meu nome é {Nome} e meu salário é de: {Salario:C}");
        }

    }
    

}