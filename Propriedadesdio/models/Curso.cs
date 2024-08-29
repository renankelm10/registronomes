using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Propriedadesdio.models.Pessoa;

namespace Propriedadesdio.models.cursos

{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoas> Alunos { get; set; }
        public List<string> alunoss = new List<string>();
        
        public void AdicionarAluno(){ 
            
             string novoaluno = Console.ReadLine();
            
            alunoss.Add(novoaluno);
        }

        
        public int ObterQuantiddadeDeAlunosMatriculados(){

            int quantidade = Alunos.Count;
            return quantidade;

        }
        
        public void RemoverAluno(){
            Console.WriteLine("nome do aluno que deseja remover");
            string removerAlunos = Console.ReadLine();
            if (alunoss.Any(x => x.ToUpper() == removerAlunos .ToUpper()))
            {
                
                alunoss.Remove(removerAlunos);
                Console.WriteLine($"O aluno {removerAlunos} foi removido da lista ");
            }
            else
            {
                Console.WriteLine("Desculpe, esse Aluno não está no Registrogeral. Confira se digitou o nome corretamente");
            }
         
          
           
            
             
        }
        
        
        public void ListarAlunos(){
            

                for (int count =  0; count < alunoss.Count; count++){

                    //string texto = "N-" + count + "	- " + alunoss[count];
                    string texto = $"N_ {count + 1 } - {alunoss[count]}";  
                    Console.WriteLine(texto);
                }
                
                
            
        }

    }}
