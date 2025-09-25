// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;
using System.Reflection.Metadata;
using Bootcamp_AVANADE___.Net___IA___2025.Models; // para instanciar um objeto tem que trazer o namespace. estou usando a classe pessoa desse namespace.

//var pessoa = new PessoaCrianca();
//pessoa.Nome = "Ana";
//pessoa.Idade = 2;
//pessoa.Apresentar();

// Draft - aula na DIO

// DateTime dataAtual = DateTime.Now;
// Console.WriteLine(dataAtual);

Calculadora calc = new Calculadora(); // instaciei calculadora

// calc.Somar(10, 30); //ações que fiz na minha calculadora
// calc.Subtrair(10, 50);
// calc.Multiplicar(5, 5);
// calc.Dividir(2, 2);
//calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);

// tabuada de um número com laços de repetição
// com FOR
// int numero = 5;

// for (int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");

// com WHILE - cuidado para não entrar no loop infinito

// int numero = 5;
// int contador = 1;

// while (contador <= 10)
// {
//     Console.WriteLine($"{numero} X {contador} = {numero * contador}");
//     contador++;//preciso colocar se não vai dar loop infinito.

//     if (contador == 5)
//     {
//         break; //vai sair do contador mesmo que essa condição seja verdadeira ainda.
//     }

// DO WHILE

// int soma= 0, numero = 0; //posso declarar variáveis juntas do mesmo tipo e valor;

// do
// {
//     Console.WriteLine("Digite um número (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine()); //precisei fazer conversão porque ele iria pegar uma string, mas eu tô pedindo um int.

//     soma += numero;// pretendo somar o valor de soma+ valor que usuário digitar.

// } while (numero != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");

// menu interativo utilizando o while

// string opcao;

// while (true)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3- Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;

//         case "2":
//             Console.WriteLine("Busca de cliente");
//             break;

//         case "3":
//             Console.WriteLine("Apagar clientee");
//             break;

//         case "4":
//             Console.WriteLine("Encerrar");
//             Environment.Exit(0);//para encerrar o programa
//             break;

//         default:
//             Console.WriteLine("Opção inválida");
//             break;

//     }
// }
// int[] arrayInteiros = new int[4]; //estou declarando array. ele é do tipo int e tem 3 posiçãoes.

// arrayInteiros[0] = 10;
// arrayInteiros[1] = 20; //estou colocando os valores de cada elemento.
// arrayInteiros[2] = 30;
// arrayInteiros[3] = 40;

// //percorrendo os elementos do array usando o for 
// Console.WriteLine("Percorrendo o array com o FOR");
// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição número {contador} - {arrayInteiros[contador]}");
// }

// // percorrendo os elementos do array com o foreach. como não tenho acesso ao contador, vou precisar gerenciar ele por fora. então, estou fazendo isso dentro do Console.WriteLine
// Console.WriteLine("Percorrendo o array com o FOREACH");
// foreach (int valor in arrayInteiros)
// {
//     Console.WriteLine(valor);
// }

// int[] arrayInteiros = new int[4];

// arrayInteiros[0] = 10;
// arrayInteiros[1] = 20; //estou colocando os valores de cada elemento.
// arrayInteiros[2] = 30;
// arrayInteiros[3] = 40;

// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2); // posso usar esta classe para aumentar o meu array

// foreach (int valor in arrayInteiros)
// {
//     Console.WriteLine(valor);
// }

//copiando elemento de array antigo para novo array

// int[] arrayInteiros = new int[4];

// arrayInteiros[0] = 10;
// arrayInteiros[1] = 20; //estou colocando os valores de cada elemento.
// arrayInteiros[2] = 30;
// arrayInteiros[3] = 40;

// //minha solução//
// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição primeiro array  número {contador} - {arrayInteiros[contador]}");
//     Console.WriteLine($"Posição segundo array número {contador} - {arrayInteirosDobrado[contador]}");
// }

//comparando com a solução do Chat:

// Console.WriteLine("Array original: ");
// for (int i = 0; i < arrayInteiros.Length; i++)
// {
//     Console.WriteLine($"Posição {i} - {arrayInteiros[i]}");

// }

// Console.WriteLine("Cópia do array originial: ");
// for (int i = 0; i < arrayInteirosDobrado.Length; i++) {
//     Console.WriteLine($"Posição {i} - {arrayInteirosDobrado[i]}");
// }

List<string> estouCriandoListaDeString = new List<string>(); //() vazia, não passie capacidade máxima pra ela, não precisa.
estouCriandoListaDeString.Add("SP");
estouCriandoListaDeString.Add("BA");
estouCriandoListaDeString.Add("MG");

// // percorrendo a lista com o FOR 
// Console.WriteLine("Percorrendo com o FOR");
// for (int contador = 0; contador < estouCriandoListaDeString.Count; contador++) // usando o count, vai retornar a quantidade de elementos do meu array 
// {
//     Console.WriteLine($"1o estado: {contador} - {estouCriandoListaDeString[contador]}");
// }

// // percorrendo a lista com o FOR 
// Console.WriteLine("Percorrendo com o FOREACH");
// int contadorDoForeach = 0;
// foreach (string item in estouCriandoListaDeString) //o foreach vai pegar os elementos da minha lista e jogar na variável q criei.
// {
//     Console.WriteLine($"1o estado: {contadorDoForeach} - {item}");
//     contadorDoForeach++;

// }
//sem contador
// Console.WriteLine("Percorrendo com o FOREACH");
// foreach (string item in estouCriandoListaDeString) //o foreach vai pegar os elementos da minha lista e jogar na variável q criei.
// {
//     Console.WriteLine($"{item}");
// }