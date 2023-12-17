using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public abstract class Conta //CLASSE ABSTRATA
    {
        protected decimal saldo; //protected classes filhas podem acessar

        public abstract void Creditar(decimal valor); //metodo abstrato - deve ser implementado na classe que herdar Conta

        public void ExibirSaldo(){
            Console.WriteLine($"O seu saldo é: {saldo}");
        }
        
    }
}