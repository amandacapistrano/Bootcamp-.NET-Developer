using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public /*sealed*/ class Professor : Pessoa // sealed faz professor ser uma classe selada que não poder ser herdada
    {
        public Professor(){
            
        }
        public Professor(string nome) : base(nome) //para atender o construtor da classe pai Pessoa
        {

        }
        public decimal Salario { get; set; }

        public /*sealed*/ override void Apresentar(){ //POLIMORFISMO // O SEALED FAZ QUE CLASSES FILHAS NÃO POSSAM SOBRESCREVER O MÉTODO.
            Console.WriteLine($" Sou professor, meu nome é {Nome} e meu salário é de: {Salario:C}");
        }

    }
    

}