using System;

public class exercicios
{
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
		float pi = 3.14159;
		float raio = float.Parse(Console.ReadLine());

		float area = pi * (raio * raio);
		Console.WriteLine("A = {area:F4}");		
    }

	public void Ex3()
    {
		float precos[] = { 16, 25, 20, 6.50f, 8 };
		int opcao[] = int.Parse(Console.ReadLine().Split(' ');

		float valorTotal = precos[opcao[0]] * opcao[1];
		Console.WriteLine("Total:  R$ {valorTotal:F2}");
	}

	public exercicios()
	{
	}
}
