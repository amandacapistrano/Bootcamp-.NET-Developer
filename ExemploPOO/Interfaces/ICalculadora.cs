using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int num1, int num2); // deve ser implementado na classe que usa a interface
        int Subtrair(int num1, int num2);    
        int Multiplicar(int num1, int num2);    
        int Dividr(int num1, int num2){ // metodos já impletemenados não precisam ser implementados novamente mas pode ser sobrescrito na classe que usa a interface.
            return num1 / num2;
        }        
    }
}