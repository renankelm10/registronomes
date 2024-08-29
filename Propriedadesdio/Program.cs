using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Reflection.Metadata;
using System.Diagnostics.Tracing;
using  Propriedadesdio.models.Pessoa;
using Propriedadesdio.models.cursos;
using System.Globalization;
using System.Data.Common;
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");


 
 
Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Englishforlife";
cursoDeIngles.alunoss = new List<string>();
DateTime data = DateTime.Now;

// P2.Sobrenome = Console.ReadLine();
// Console.WriteLine("idade");
// P1.Idade = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("IDaede");
// P2.Idade = Convert.ToInt32(Console.ReadLine()); 
bool exibirMenu = true;

 while (exibirMenu)
 {
     Console.WriteLine($"{data}");
     Console.WriteLine("");
     Console.WriteLine("Digite a sua opção:");
     Console.WriteLine("1 - Cadastrar Aluno");
    Console.WriteLine("2 - Remover Aluno");
     Console.WriteLine("3 - Listar Alunos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
       case "1":
         cursoDeIngles.AdicionarAluno();
            break;

        case "2":
             cursoDeIngles.RemoverAluno();
            break;

        case "3":
             cursoDeIngles.ListarAlunos();
             break;

         case "4":
             exibirMenu = false;
             break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

     Console.WriteLine("Pressione uma tecla para continuar");
     Console.ReadLine();
 }

 Console.WriteLine("O programa se encerrou");