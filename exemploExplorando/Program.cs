using System.Runtime;
using exemploExplorando.Models;
using System.Globalization;
using System.Reflection.Metadata;

//Data e hora DateTime:
//DateTime data = DateTime.Now;
//  Console.WriteLine(data);


// //Console.WriteLine(data.ToString("dd/MMMM/yyyy HH:mm"));
// Console.WriteLine(data.ToShortDateString()); //exibe só data
// Console.WriteLine(data.ToShortTimeString()); //exibe só hora

string dataString = "2022-13-17 18:00";
///Validação da data
bool sucess = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", 
                                        CultureInfo.InvariantCulture, 
                                        DateTimeStyles.None, 
                                        out DateTime data);

//DateTime data = DateTime.Parse(dataString);
if (sucess){
    Console.WriteLine(data);
}else
    Console.WriteLine($"{dataString} não é uma data válida");






// //CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");


// decimal valorMonetario = 82.40M;
// //Console.WriteLine($"{valorMonetario:C}");
// //Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
// Console.WriteLine(valorMonetario.ToString("C1")); //c2 indica 2 casas decimais
// //Valor numero mas com ajuste das casas decimais n1, n2, n3:
// Console.WriteLine(valorMonetario.ToString("N1"));
// //porcentagem:
// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("P"));
// //formatação de valores:
// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));








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

