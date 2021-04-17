using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_Patrones_de_diseno
{
	partial class Program
	{
		private static void BeginCreationalPatternDesignExample()
		{
			Console.WriteLine("\n**** Patrón Creacional: BUILDER ****\n");

			OrderBuilder orderBuilder = new OrderBuilder();

			Console.WriteLine("PEDIDOS DE COMIDA A DOMICILIO: \n * haga su pedido a continuación...");
			Console.Write("Ingrese el plato principal: ");
			orderBuilder.setPrincipalFootOrder(Console.ReadLine().ToString());
			Console.Write("Ingrese el complemento: ");
			orderBuilder.setComplementOrder(Console.ReadLine().ToString());
			Console.Write("Ingrese la bebida: ");
			orderBuilder.setDrinkOrder(Console.ReadLine().ToString());
			Console.Write("Ingrese el postre: ");
			orderBuilder.setDessertOrder(Console.ReadLine().ToString());
			orderBuilder.getOrder();
		}
	}

	class OrderBuilder
	{
		public string principalFoot { get; private set; }
		public string complement { get; private set; }
		public string drink { get; private set; }
		public string dessert { get; private set; }

		public void setPrincipalFootOrder (string principalFoot)
		{
			this.principalFoot = principalFoot;
		}
		public void setComplementOrder (string complement)
		{
			this.complement = complement;
		}
		public void setDrinkOrder (string drink)
		{
			this.drink = drink;
		}
		public void setDessertOrder (string dessert)
		{
			this.dessert = dessert;
		}

		public void getOrder ()
		{
			Order order = new Order(principalFoot, complement, drink, dessert);
			Console.WriteLine(order.OrderInfo());
		}
	}

	class Order
	{
		public string principalFoot { get; private set; }
		public string complement { get; private set; }
		public string drink { get; private set; }
		public string dessert { get; private set; }

		public Order(string principalFoot, string complement, string drink, string dessert)
		{
			this.principalFoot = principalFoot;
			this.complement = complement;
			this.drink = drink;
			this.dessert = dessert;
		}

		public string OrderInfo()
		{
			return "\nInformación de la Orden:" +
				"\n Plato Principal: " + principalFoot +
				"\n Complemento: " + complement +
				"\n Bebida: " + drink + 
				"\n Postre: " + dessert;
		}
	}
}
