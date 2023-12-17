using ExemploPOO.Models;

// Pessoa p1 = new Pessoa();
// p1.Nome = "Amanda";
// p1.Idade = 24;

// p1.Apresentar();

// //ENCAPSULAMENTO
// ContaCorrente c1 = new ContaCorrente(123, 1000);
// c1.ExibirSaldo();
// c1.Sacar(5000);
// c1.ExibirSaldo();

// //HERANÇA
// Aluno a1 = new Aluno();
// a1.Nome ="João";
// a1.Idade = 25;
// a1.Nota = 7.5;
// a1.Apresentar(); //polimorfismo

// //POLIMORFISMO
// Professor p1 = new Professor();
// p1.Nome = "Maria";
// p1.Idade = 40;
// p1.Salario = 4000;
// p1.Apresentar();

// //ABSTRAÇÃO:
// Corrente c = new Corrente();
// c.Creditar(500);
// c.ExibirSaldo();

// //Construtor por herança:
// Pessoa p1 = new Pessoa("Amanda");
// Aluno a1 = new Aluno("Maria");
// p1.Apresentar();
// a1.Apresentar();
// Professor prof = new Professor(); // com o construtor vazio não é obrigado a passar o nome

//CLASSE OBJECT
Computador c = new Computador();
Console.WriteLine(c.ToString());