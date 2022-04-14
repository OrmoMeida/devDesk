using System;

public class exercicios 
{
	public lista_EstruturaSequencial lista1 = new lista_EstruturaSequencial();
	public lista_EstruturaCondicional lista2 = new lista_EstruturaCondicional(); 
	public lista_EstruturaRepetitiva lista3 = new lista_EstruturaRepetitiva();
}

public class lista_EstruturaSequencial {
	public void Ex1()
	{
		int cp1, qp1;
		float pu1;
		int cp2, qp2;
		float pu2, vlrPagar;

		Console.WriteLine("EXERCÍCIO 1");
		Console.WriteLine("Peça 1: \n");
		cp1 = int.Parse(Console.ReadLine());
		qp1 = int.Parse(Console.ReadLine());
		pu1 = float.Parse(Console.ReadLine());

		Console.WriteLine("Peça 2: \n");
		cp2 = int.Parse(Console.ReadLine());
		qp2 = int.Parse(Console.ReadLine());
		pu2 = float.Parse(Console.ReadLine());

		vlrPagar = (qp1 * pu1) + (qp2 + pu2);
		Console.WriteLine("Valor a ser pago: {0:F2}", vlrPagar);
	}

	public void Ex2()
    {
		float pi = 3.14159F;
		float raio = float.Parse(Console.ReadLine());

		float area = pi * (raio * raio);
		Console.WriteLine("A = {area:F4}");		
    }
}

public class lista_EstruturaCondicional {
	public void Ex1 () {
		float[] preco = { 0, 16, 25, 20, 6.50f, 8 };

		Console.Write("Digite o código do produto e a quantidade:");
		Console.WriteLine("[1] Cachorro quente			-	R$ 16,00");
		Console.WriteLine("[2] Frangão					-	R$ 25,00");
		Console.WriteLine("[3] X Bacon					- 	R$ 20,00");
		Console.WriteLine("[4] Coca	cola - lata			- 	R$ 6,50");
		Console.WriteLine("[5] Suco de laranja - 300ml	- 	R$ 8,00");
		Console.WriteLine("Opção e quantidade:  ");

		string[] compraTxt = Console.ReadLine().Split(' ');
		float[] compra = new float[2];
		compra[0] = float.Parse(compraTxt[0]);
		compra[1] = float.Parse(compraTxt[1]);
		float valorTotal = 0;

		// Opção usando arrays 
		/*
		if (compra[0] >= 1 && compra[0] <= 5) {
			valorTotal = compra[1] * preco[compra[2]]; 
		}
		*/		

		switch (compra[0]) {
			case 1:
				valorTotal = compra[1] * preco[1];
				break;
			case 2:
				valorTotal = compra[1] * preco[2];
				break;
			case 3:
				valorTotal = compra[1] * preco[3];
				break;
			case 4:
				valorTotal = compra[1] * preco[4];
				break;
			case 5:
				valorTotal = compra[1] * preco[5];
				break;
			default:
				Console.WriteLine("ERRO");
				break;
		}
		
		Console.WriteLine("Valor:  {0:F2}", valorTotal);
	}

	public void Ex2() {
		Console.WriteLine("Insira os valores de 'a', 'b' e 'c':  ");		
		string[] num = Console.ReadLine().Split(' ');
		double a = double.Parse(num[0]);
		double b = double.Parse(num[1]);
		double c = double.Parse(num[2]);
		double[] x = new double[2];

		double delta = (b * b) - 4 * a * c;

		if (a != 0 && delta > 0) {
			x[0] = (-b - Math.Sqrt(delta)) / 2 * a;
			x[1] = (-b + Math.Sqrt(delta)) / 2 * a;

			Console.WriteLine("X1 = {0:F2}", x[0]);
			Console.WriteLine("X2 = {0:F2}", x[1]);
		} else {
			Console.WriteLine("Impossível calcular!");
		}
	}
}

public class lista_EstruturaRepetitiva {
	public void Ex1() {
		Console.WriteLine("Digite sua senha:  \n\n");
		string senha = "";

		while (!senha.Equals("cotil")) {
			senha = Console.ReadLine();
			if (!senha.Equals("cotil")) {
				Console.WriteLine("Senha inválida!"); 
			} else {
				Console.WriteLine("Acesso permitido!");				
			}
		}
	}

	public void Ex2() {
		Console.Write("Digite a quantidade de números a serem lidos:  ");
		int exec = int.Parse(Console.ReadLine());
		int qntIn = 0, qntOut = 0;

		for(int count = 0; count < exec; count++) {
			int num = int.Parse(Console.ReadLine());

			// Tenho certeza que o Matioli escreveu o intervalo errado. Na tarefa está [10,10]
			if (num >= 10 && num <= 10) { 
				qntIn++;
			} else {
				qntOut++;
			}
		}

		Console.WriteLine("\n{qntIn} in");
		Console.WriteLine("{qntOut} out");
	}
}