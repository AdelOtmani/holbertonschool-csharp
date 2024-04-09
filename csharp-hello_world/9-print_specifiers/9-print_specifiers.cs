using System;

class Program
{
	static void Main(string[] args)
	{
		double percent = .7553;
		double currency = 98765.4321;
		Console.WriteLine("Percent: {0:F2}%\nCurrency: {1}", percent*100, currency.ToString("C"));
	}
}
