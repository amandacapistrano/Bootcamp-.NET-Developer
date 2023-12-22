using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using calculadora.Services;

namespace calculadoraTestes
{
    public class ValidacoesStringsTestes
    {
        private ValidacoesString _validacoes;

        public ValidacoesStringsTestes(){
            _validacoes = new ValidacoesString();
        }

        [Fact]
        public void DeveContar3CaracteresEmOlaERetornar3(){
        //arrange
        string texto = "ola";

        //act 
        int resultado = _validacoes.ContarCaracteres(texto);
        
        //assert
        Assert.Equal(3, resultado);
        }
    }
}