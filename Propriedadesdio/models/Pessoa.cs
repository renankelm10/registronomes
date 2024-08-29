using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Propriedadesdio.models.Pessoa
{
    public class Pessoas
    {

        public Pessoas(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;

        }

        private string _nome;
        private int _idade;
        private string _sobrenome;
        public string NomeCompleto => $" {Nome} {Sobrenome} ".ToUpper();


        public string Nome 
        { 
            get => _nome.ToUpper();
            
            
            set{
                if  (value == "")
                {
                    throw new ArgumentNullException("O nome nao pode ser vazio"); 
                }
                _nome = value; 
            } 
            
        }

        
        public string Sobrenome
        { 
            get => _sobrenome.ToUpper();
            
            
            set{
                if  (value == "")
                {
                    throw new ArgumentNullException("O nome nao pode ser vazio"); 
                }
                _sobrenome = value; 
            } 
            
        }
        public int Idade { 

            get => _idade;
                  
            
            set{
                    if (value < 0 ){
                        throw new ArgumentNullException("O nome nao pode ser vazio"); 
                    }
                _idade = value;                                  
            }
        }
        public void Apresentar(){
            Console.WriteLine($"Nome : {NomeCompleto} Idade : {Idade}");
        }
    }
}