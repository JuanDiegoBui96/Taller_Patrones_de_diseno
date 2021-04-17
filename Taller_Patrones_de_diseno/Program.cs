using System;

namespace Taller_Patrones_de_diseno
{
	partial class Program
	{
		static void Main(string[] args)
		{
			int answer;
			do
			{
				Console.Write("HOLA! Escoja el ejemplo de patrón de diseño que desea ejecutar: \n0: Creacional \n1: Estructural \n2: Comportamiento\n>");
				answer = Convert.ToInt32(Console.ReadLine());
			} while (answer < 0 && answer > 2);

			switch (answer)
			{
				case 0: BeginCreationalPatternDesignExample(); break;
				case 1: BeginStructuralPatternDesignExample(); break;
				case 2: BeginBehavioralPatternDesignExample(); break;
			}


		}
	}
}
