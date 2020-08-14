using System;
using System.Linq;

namespace tigscod
{
    class Program
    {
		//# Exercicios "lógica de programação" 1-18
        static void Main(string[] args)
       	{
            Exercise16();
		}
		static void Exercise1()
		{
			// 1)Crie um programa que imprima:

            // a)Os números de 1 a 10 de forma crescente.
            // b)Os números de 1 a 10 de forma descrecente
            // c)Os números de 1 a 10 de forma crescente, mas apenas aqueles
            // que forem par.

			var number = 1;

			System.Console.WriteLine("crescente:");
			while (number < 11)
			{
				System.Console.WriteLine(number);
				number++;
			}

			System.Console.WriteLine("decrescente:");
			while (number > 0)
			{
				System.Console.WriteLine(number);
				number--;
			}

			number = 2;
			System.Console.WriteLine("os pares crecente:");
			while (number < 11)
			{
				if (number % 2 == 0)
				{
					System.Console.WriteLine(number);
				}
				number++;
			}
		}

		static void Exercise2()
		// 2)Imprimir a soma dos números inteiros de 1 a 100.
		{
			(int counter, int sum) numb = (1, 0);
			while (numb.counter < 101)
			{
				numb.sum += numb.counter; 	numb.counter++;
			}
			System.Console.WriteLine($"a soma dos números inteiros entre 1 e 100 é {numb.sum}");
		}

		static void Exercise3()
		//3)Imprimir todo os números ímpares menores de 200.
		{
			for (int i = 1; i < 200; i+=2)
			{
				System.Console.WriteLine(i);
			}
		}

		static void Exercise4()
		//4)Calcular a média de idade de uma turma qualquer. O algoritmo deve parar quando 
		//for digitada a idade igual a zero.
		{
			var sum = 0.0;
			var counter = 0.0;
			while (true)
			{
				System.Console.WriteLine("Digite uma idade");
				var result = Console.ReadLine();
				if (result == "0")
				{
					break;
				}
				counter++;	
				sum += Int32.Parse(result);
			}
			System.Console.WriteLine("A média da turma é:");
			System.Console.WriteLine((sum / counter).ToString("0.00"));
		}

		static void Exercise5()
		// 5)Criar um algoritmo que peça o nome e a idade de 5 mulheres. Após informar estes dados,
		// o programa deve mostrar apenas porcentagem de mulheres que estão com idade entre 18 e 35. 

		{
			var womenBetween18And35 = 0;
			for (int i = 0; i < 5; i++)
			{
				System.Console.WriteLine("Digite o nome de uma mulher e sua idade");
				Console.ReadLine();
				var age = Int32.Parse(Console.ReadLine());
				if (age > 17 && age < 36)
				{
					womenBetween18And35++;
				}
			}
			System.Console.WriteLine("A porcentagem de mulheres entre 18 e 35");
			System.Console.WriteLine(womenBetween18And35 * 100 / 5);
		}

		static void Exercise6()
		//6)Criar um algoritmo que simule uma urna eletrônica. 
		//Esta urna deve possuir dois candidatos e possui três modos.
		// O primeiro é o modo de CADASTRO, onde o sistema pergunta o nome de cada um dos dois candidatos.
		// Por medidas de segurança, para poder cadastrar um candidato na urna o sistema deve solicitar ao
		// usuário a senha para poder ter acesso (a senha do sistema é Pa$$w0rd).
		// O segundo modo é o modo de votos, onde o usuário informa 1 para votar no primeiro candidato 
		//e 2 para votar no segundo candidato. O terceiro modo, é o modo de apuração de votos,
		// onde o sistema verifica qual candidato tem mais votos. Caso o número de votos seja igual,
		// o sistema deve imprimir a mensagem "SEGUNDO TURNO",
		// caso contrário deve imprimir o nome do candidato vencedor e o número de votos que ele obteve.

		{
			var candidates = new (string name, int votes)[2];

			while (true)
			{
				System.Console.WriteLine("Selecione um dos modos a seguir:");
				System.Console.WriteLine("1 - Cadastro dos candidatos");
        		System.Console.WriteLine("2 - Vote em um candidato");
        		System.Console.WriteLine("3 - Apuração dos votos");
				var mode = Console.ReadLine();

				if (mode == "1")
				{
					var password = "";

					while (password != "Pa$$w0rd")
					{
						System.Console.WriteLine("Digite a senha");
						password = Console.ReadLine();
					}

					System.Console.WriteLine("Digite o nome do primeiro candidato");
					candidates[0].name = Console.ReadLine();

					System.Console.WriteLine("Digite o nome do segundo candidato");
					candidates[1].name = Console.ReadLine();
				}

				if (mode == "2")
				{
					System.Console.WriteLine($"Insira 1 para votar no candidato {candidates[0].name}, ou 2 para votar no candidato {candidates[1].name}");
					var result = Int32.Parse(Console.ReadLine());
					candidates[result - 1].votes++;
				}

        		if (mode == "3")
				{
					if (candidates[0].votes == candidates[1].votes)
					{
						System.Console.WriteLine("Segundo turno!");
					}
					else
					{
						var winner = (candidates[0].votes > candidates[1].votes) ? candidates[0] : candidates[1];
						System.Console.WriteLine($"O vencedor é: {winner.name}");
						System.Console.WriteLine($"Com o total de: {winner.votes} votos!");
					}
					break;
				}
			}
		}
		static void Exercise7()
		//7)Calcular a quantidade de dinheiro gasta por um fumante.
		// Dados: o numero de anos que ele fuma, o nº de cigarros fumados por dia e o preço de uma carteira.
		{
			System.Console.WriteLine("7. Calcular a quantidade de dinheiro gasta por um fumante.");
            System.Console.WriteLine("Há quantos anos esta pessoa fuma?");
            var years = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Quantos cigarros ela fuma por dia?");
            var cigarretesPerDay = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Qual o valor da carteira de cigarros?");
            var price = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine($"O valor total gasto em cigarros foi R$ {cigarretesPerDay*years*365/20*price}");
        }
		static void Exercise8()
		//8)Ler dois números inteiros, X e Y, e apresentar mensagem informando se o X é múltiplo de Y.

		{
		    System.Console.WriteLine("Excreva dois números para saber se são multiplos.");
			System.Console.WriteLine("digite o primeiro número");
			var x = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("digite o segundo número");
			var y = int.Parse(System.Console.ReadLine());
			 if(x % y ==0)
			 {
				 System.Console.WriteLine($"{x} é multiplo de {y}");
			 }
			 else
			 {
				 System.Console.WriteLine("não são multiplos.");
			 }
		}

		static void Exercise9()
		//9)Fazer um algoritmo para ler 03 números reais do teclado e verificar se 
		//o primeiro é maior que a soma dos outros dois.
		{
			var numb = new int[3];
			System.Console.WriteLine("Excreva 3 números para saber se o primeiro é maior que a soma dos utlimos dois.");
			for (int i = 0; i < 3; i++)
			{
				System.Console.WriteLine("digite o primeiro número");
				numb[i] = int.Parse(System.Console.ReadLine());
			}
			if(numb[0]>numb[1]+numb[2])
			{
				System.Console.WriteLine($"{numb[0]} é maior que a soma de {numb[1]} e {numb[2]}.");
			}
			else
			{
				System.Console.WriteLine($"{numb[0]} não é maior que a soma de {numb[1]} e {numb[2]}.");
			}
		}
		static void Exercise10()
		//10)Ler 02 números reais do teclado (A e B), verificar e imprimir qual deles é maior,
		// ou a mensagem "A = B" caso sejam iguais
		{
			System.Console.WriteLine("Excreva 2 números para saber qual dele é o maior.");
			System.Console.WriteLine("digite o primeiro número");
			var x = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("digite o segundo número");
			var y = int.Parse(System.Console.ReadLine());
			if(x>y)
			{
				System.Console.WriteLine("O 1º número é maior");
			}
			else if (x<y)
			{
				System.Console.WriteLine("O 2º número é maior");
			}
			else
			{
				System.Console.WriteLine($"{x} é igual a {y}");
			}
		}
		static void Exercise11()
		//11)Ler 02 números inteiros do teclado. Se o segundo for diferente de zero, 
		//calcular e imprimir o quociente do primeiro pelo segundo.
		// Caso contrário, imprimir a mensagem: "DIVISÃO POR ZERO".
		{
			System.Console.WriteLine("Excreva 2 números para saber o quociente.");
			System.Console.WriteLine("digite o primeiro número");
			var x = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("digite o segundo número");
			var y = int.Parse(System.Console.ReadLine());
			if(y != 0)
			{
				System.Console.WriteLine($"{x/y}");
			}
			else
			{
				System.Console.WriteLine("DIVISÃO POR ZERO!");
			}
		}
		static void Exercise12()
		// 12. Ler 4 números inteiros e calcular a soma dos que forem pares e ímpares.
		{
		System.Console.WriteLine("Escreva 4 números inteiros para e calcular a soma dos que forem pares e ímpares.");
		int even = 0; int odd = 0;
		for (int i = 0; i < 4; i++)
		{
			System.Console.WriteLine("Insira um número inteiro:");
			int number = Int32.Parse(System.Console.ReadLine());
			if (number%2 == 0)
			{
				even += number;
			}
			else if (number%2 != 0)
			{
				odd += number;
			}
		}
		System.Console.WriteLine($"A soma dos números pares é {even}");
		System.Console.WriteLine($"A soma dos números ímpares é {odd}");
		}
		static void Exercise13()
		//13)Ler 10 valores e determinar o maior dentre eles.
		{
			System.Console.WriteLine("Descubra qual o maior número dentre 10.");
			var higher = int.MinValue;
			for (int i = 0; i < 10; i++)
			{
				System.Console.WriteLine("digite um número.");
				var num = int.Parse(System.Console.ReadLine());
				if(num>higher)
				{
					higher=num;
				}

			}
			System.Console.WriteLine($"O mair número é o {higher}.");
		}
		static void Exercise14()
		//14)Ler três valores e colocá-los em ordem.
		{
			var arsA = new int[3];
			for (int a = 0; a < arsA.Length; a++)
           {
                System.Console.WriteLine($"digite o um número:");
                arsA[a] = int.Parse(System.Console.ReadLine());
            }
            // colocando matrix A em ordem crescente
            for (int i = 1; i < arsA.Length; i++)
            {
                //proteção para não passar do limite do array.(x < arsA.Length - 1;)
                for (int x = 0; x < arsA.Length - 1; x++)
                {
                    if (arsA[x] > arsA[x + 1])
                    {
                        var temp = arsA[x+1]; 
                        arsA[x+1] = arsA[x];
                        arsA[x] = temp;
                    }            
                }
            }
        }
		static void Exercise15()
		//15)Ler 10 números e imprimir quantos são múltiplos de 3 e quantos são múltiplos de 5.
		{
			var mlt3 =0;
			var mlt5 =0;
			System.Console.WriteLine("dentre 10 números quantos são multiplos de 3 e quantos de 5");
			for (int i = 0; i < 10; i++)
			{
				System.Console.WriteLine("digite um número");
				var num = int.Parse(Console.ReadLine());
				if(num%3==0)
				{
					mlt3++;
				}
				else if(num%5==0)
				{
					mlt5++;
				}
			}
			System.Console.WriteLine($"Dentre os 10 valores {mlt3} são multiplos de 3 e {mlt5} de 5");
		}
		static void Exercise16()
		//16)Ler o salário de uma pessoa e imprimir o Salário Líquido de acordo
		//com a redução do imposto descrito ao lado:
		//Menor ou igual a R$ 600,00 - ISENTO
		//Maior que R$ 600,00 e menor ou igual a 100 - 20% desconto
		//Maior que R$ 1.200,00 e menor ou igual a R$2000 - 25% desconto
		//Maior que R$ 2.000,00 - 30% desconto

		{
			var salr = 0.0; var tax = 0.0;
			System.Console.WriteLine("digite o valor do seu salário:");
			salr = double.Parse (System.Console.ReadLine());
			if(salr <= 600.00)
			{
				System.Console.WriteLine($"isento :{salr}");
				return;
			}
			else if(salr <= 1200.00)
			{
				tax = 0.8;
			}
			else if(salr <= 2000.00)
			{
				tax = 0.75;
			}
			else
			{
				tax = 0.7;
			}
			System.Console.WriteLine($"Seu salário líquido é R${(salr*tax).ToString("0.00")}");
		}
		static void Exercise17()
		//17)Imprimir a tabuada de qualquer número fornecido pelo usuário até que 
		//o usuário forneça o valor –1.

		{
			while(true)
			{
				System.Console.WriteLine("Escreva o número para ver sua Tabuada.");
				var input = int.Parse(System.Console.ReadLine());
				if(input <0)
				{
					break;
				}	
				else
				{
					for (int i = 1; i < 10; i++)
					{
						var result = input*i;
						System.Console.WriteLine($"{input}x{i}={result}");
					}
				}
				System.Console.WriteLine($"tabuada de {input} pronta.");

			}
			
		}
		static void Exercise18()
		//18)As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia, e R$ 1,00 se forem
		//compradas pelo menos 12. Escreva um programa que leia o número de maçãs compradas, calcule e
		//escreva o custo total da compra. 
		{
			System.Console.WriteLine("O preço da Maçã é de R$ 1,30 a unidade, apartir de 12 unidades é R$ 1,00.");
			System.Console.WriteLine("Escreva quantas Maçãs você quer:");
			var Numb = double.Parse(System.Console.ReadLine());
			if(Numb<12)
			{
				System.Console.WriteLine($"você vai comprar {Numb} Maçãs, vai custar R${(Numb*1.30).ToString("0.00")}");		
			}
			else
			{
				System.Console.WriteLine($"você vai comprar {Numb} Maçãs, vai custar R${(Numb*1.00).ToString("0.00")}");		
			}

		}
	}
}