using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploExplorando.Models
{
    public class Pessoa
    {
        //Construtor vazio
        public Pessoa(){
            
        }
        //Construtor com parametros
        public Pessoa(string nome, string sobrenome){
            Nome = nome;
            Sobrenome = sobrenome;
            
        }


        //campos e variaveis:
        private string _nome;
        private int _idade;

//propriedades:
        public string Nome { 
            // get{
            //     return _nome.ToUpper();
            // } ou:
            get => _nome.ToUpper();

            set{
                if (value == ""){
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }
        public int Idade { 
            get => _idade; 
            set{
                if (value < 0){
                    throw new ArgumentException("A idade não pode ser menor que 0");
                }
                _idade = value;
            }
        }

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public void Apresentar(){
            Console.WriteLine($"Nome: {NomeCompleto}, idade: {Idade}");
        
        }
    }
}