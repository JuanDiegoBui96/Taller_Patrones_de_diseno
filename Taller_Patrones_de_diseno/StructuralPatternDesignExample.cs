using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_Patrones_de_diseno
{
	partial class Program
	{
		private static void BeginStructuralPatternDesignExample()
		{
			Console.WriteLine("\n**** Patrón Stuctural: ADAPTER ****\n");
			
			GeometricShape[] geometricShapes =
			{
				new LineAdapter(new Line()),
				new RectangleAdapter(new Rectangle())
			};
			int x = 30, y = 40, a = 25, b = 50;
			for (int i = 0; i < geometricShapes.Length; i++)
				geometricShapes[i].characteristics(x,y,a,b);
		}
	}

	interface GeometricShape
	{
		void characteristics(int x, int y, int a, int b);
	}

	class Line
	{
		public void characteristics (int x1, int y1, int x2, int y2)
		{
			Console.WriteLine("Coordenada de iniciación: " + "(" + x1 + "," + y1 + ")");
			Console.WriteLine("longitud de la linea: " + Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
			Console.WriteLine("Área de la linea: --");
		}
	}

	class Rectangle
	{

		public void characteristics(int x, int y, int width, int height)
		{
			Console.WriteLine("Coordenada de iniciación: "+ "(" + x + "," + y + ")");
			Console.WriteLine("longitud del rectangulo: " + (width * 2 + height * 2));
			Console.WriteLine("Área del rectangulo: " + (width * height));
		}
	}

	class LineAdapter : GeometricShape
	{
		public Line lineAdapter { get; private set; }

		public LineAdapter(Line lineAdapter)
		{
			this.lineAdapter = lineAdapter;
		}

		public void characteristics(int x, int y, int a, int b)
		{
			this.lineAdapter = new Line();
			this.lineAdapter.characteristics(x, y, a, b);
		}
	}

	class RectangleAdapter : GeometricShape
	{
		public Rectangle rectangleAdacter { get; private set; }

		public RectangleAdapter(Rectangle rectangleAdacter)
		{
			this.rectangleAdacter = rectangleAdacter;
		}

		public void characteristics (int x, int y, int a, int b)
		{
			this.rectangleAdacter = new Rectangle();
			this.rectangleAdacter.characteristics(x, y, a, b);
		}
	}
}
