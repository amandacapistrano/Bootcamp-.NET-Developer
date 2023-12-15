using System.Runtime;
using exemploExplorando.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Amanda";
//p1.Idade = 24;
p1.Sobrenome = "Pereira";
//p1.Apresentar();

// Pessoa p2 = new Pessoa("Maria", "Santos" ); ou:
Pessoa p2 = new Pessoa(nome: "Maria", sobrenome: "Santos" );

Curso cursoBiologia = new Curso();
cursoBiologia.Nome = "Biologia";
cursoBiologia.Alunos = new List<Pessoa>();

cursoBiologia.AdicionarAluno(p1);
cursoBiologia.AdicionarAluno(p2);
cursoBiologia.ListarAlunos();

