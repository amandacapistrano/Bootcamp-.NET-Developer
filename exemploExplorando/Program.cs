using System.Runtime;
using exemploExplorando.Models;
using System.Globalization;

//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");


decimal valorMonetario = 82.40M;
//Console.WriteLine($"{valorMonetario:C}");
//Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
Console.WriteLine(valorMonetario.ToString("C1")); //c2 indica 2 casas decimais
//Valor numero mas com ajuste das casas decimais n1, n2, n3:
Console.WriteLine(valorMonetario.ToString("N1"));
//porcentagem:
double porcentagem = .3421;
Console.WriteLine(porcentagem.ToString("P"));
//formatação de valores:
int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));


// int numero1 = 10;
// string numero2 = "20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);




// Pessoa p1 = new Pessoa();
// p1.Nome = "Amanda";
// //p1.Idade = 24;
// p1.Sobrenome = "Pereira";
// //p1.Apresentar();

// // Pessoa p2 = new Pessoa("Maria", "Santos" ); ou:
// Pessoa p2 = new Pessoa(nome: "Maria", sobrenome: "Santos" );

// Curso cursoBiologia = new Curso();
// cursoBiologia.Nome = "Biologia";
// cursoBiologia.Alunos = new List<Pessoa>();

// cursoBiologia.AdicionarAluno(p1);
// cursoBiologia.AdicionarAluno(p2);
// cursoBiologia.ListarAlunos();

