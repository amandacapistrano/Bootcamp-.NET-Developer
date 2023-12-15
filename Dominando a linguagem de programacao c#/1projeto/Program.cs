using _1projeto.Models;


//###################### CLASSE PESSOA #######
// Pessoa p = new Pessoa();

// p.Nome = "teste";
// p.Idade = 24;
// p.Apresentar();


//###################### CLASSE CALCULADORA #######
// Calculadora calculadora = new Calculadora();
// calculadora.RaizQuadrada(9);
// calculadora.Somar(10,47);
// calculadora.Subtrair(10,5);
// calculadora.Multiplicar(40,20);
// calculadora.Dividir(47,2);
// calculadora.Potencia(3,3);
// calculadora.Seno(30);
// calculadora.Coseno(30);
// calculadora.Tangente(30);

//###################### EXEMPLO DE INCRMENTO E DECREMENTO #######
// int numero = 10;
// Console.WriteLine(numero);
// //Console.WriteLine("Incrementando o 10");
// //numero = numero + 1;
// //numero++;
// // teste ++numero;
// //Console.WriteLine(numero);
// Console.WriteLine("Decrementando o 10");
// numero--;
// Console.WriteLine(numero);

//################## LAÇOS DE REPETIÇÃO ####################

//int numero = 5;
// int contador = 0;
// for (contador = 0; contador <= 10; contador++){
//      Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }

// while(contador <= 10){
//      Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//      contador++;
//  }

// do{
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador++;
// }while(contador <= 10);

//     int soma =0;
// do{
//     Console.WriteLine("Digite um numero. (0 para parar) ");
//     numero = Convert.ToInt32(Console.ReadLine());
//     soma += numero;

// }while(numero != 0);
// Console.WriteLine($"A soma é: {soma}");

// ########## EXEMPLO MENU#############
// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         string opcao;
//         Boolean exibirMenu = true;

//         while (exibirMenu)
//         {
//             Console.WriteLine("Digite a sua opção");
//             Console.WriteLine("1 - Cadastrar Cliente");
//             Console.WriteLine("2 - Buscar Cliente");
//             Console.WriteLine("3 - Apagar Cliente");
//             Console.WriteLine("4 - Sair");

//             opcao = Console.ReadLine();

//             switch (opcao)
//             {
//                 case "1":
//                     Console.WriteLine("Cadastrar Cliente");
//                     break;
//                 case "2":
//                     Console.WriteLine("Buscar Cliente");
//                     break;
//                 case "3":
//                     Console.WriteLine("Apagar Cliente");
//                     break;
//                 case "4":
//                     Console.WriteLine("Sair");
//                     //Environment.Exit(0);
//                     exibirMenu = false;
//                     break;
//                 default:
//                     Console.WriteLine("Opção inválida");
//                     break;

//             }
//         }
//         Console.WriteLine("Menu encerrado");
//     }
// }

// ############ EXEMPLO ARRAY E LISTAS
int[] arrayInteiros = new int[3];
arrayInteiros[0] = 2;
arrayInteiros[1] = 1;
arrayInteiros[2] = 0;
//####### imprimir array
// for(int contador = 0; contador < arrayInteiros.Length; contador++){
//     Console.WriteLine($" Posição {contador}, valor: {arrayInteiros[contador]}");
// }
// Console.WriteLine("\nPercorrendo array com foreach");
//int contadorForeach = 0;
// foreach(int inteiro in arrayInteiros){
//     Console.WriteLine($"Posição: {contadorForeach}, valor: {inteiro}, ");
//     contadorForeach++;
// }

//########AUMENTAR TAMANHO DO ARRAY
//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// COPIAR UM ARRAY PARA OUTRO
//int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
//Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// ########## TRABALHANDO COM LISTAS ######
List<string> listaString = new List<string>();
listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");

// for(int contador = 0; contador < listaString.Count; contador++){
//     Console.WriteLine($"Posição {contador}, valor: {listaString[contador]}");

// }
// Console.WriteLine("Percorrendo com foreach");
// foreach(string estado in listaString){
//     Console.WriteLine(estado);
// }
Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("ES");
Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Remove("SP");
Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");
listaString.Add("MA");
listaString.Add("GO");
Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");
listaString.Remove("ES");
listaString.Remove("MA");
listaString.Remove("BA");
Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");
