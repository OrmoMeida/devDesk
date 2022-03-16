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

	public exercicios()
	{
	}
}
