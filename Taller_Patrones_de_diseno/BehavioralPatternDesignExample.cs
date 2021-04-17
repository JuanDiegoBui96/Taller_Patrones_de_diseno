using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_Patrones_de_diseno
{
	partial class Program
	{
		private static void BeginBehavioralPatternDesignExample ()
		{
			Console.WriteLine("\n**** Patrón de Comportamiento: STATE ****\n");

			VendingMachine vendingMachine;
			string snack;
			int money;


			Console.WriteLine("Información de la maquina de venta de Snacks:" +
				"\nSnack1 -> precio: 1000" +
				"\nSnack2 -> precio: 2000" +
				"\nSnack3 -> precio: 3000" +
				"\nSnack4 -> precio: 4000" +
				"\nSnack5 -> precio: Agotado!");

			Console.Write("\nIngrese el Snack que desea comprar: ");
			snack = Console.ReadLine().ToString();
			Console.Write("Ingrese la cantidad de dinero que desea ingresar en la maquina: ");
			money = Convert.ToInt32(Console.ReadLine());
			vendingMachine = new VendingMachine(snack,money);
			Console.WriteLine("Estado de la compra: " + vendingMachine.purchaseStatus);
		}
	}

	class VendingMachine
	{
		public string chosenSnack { get; private set; }
		public int moneyDeposited { get; private set; }
		public string purchaseStatus { get; private set; }

		public VendingMachine(string chosenSnack, int moneyDeposited)
		{
			this.chosenSnack = chosenSnack;
			this.moneyDeposited = moneyDeposited;
			purchaseStatus = Status.PurchaseStatus(chosenSnack, moneyDeposited);
		}
	}

	static class Status
	{
		public static string PurchaseStatus(string chosenSnack, int moneyDeposited)
		{
			string[] snacks = { "Snack1", "Snack2", "Snack3", "Snack4", "Snack5" };
			int[] prices = { 1000, 2000, 3000, 4000, 0 };
			for (int i = 0; i < snacks.Length; i++)
			{
				if (snacks[i] == chosenSnack)
				{
					if (prices[i] == 0)
					{
						return PurchaseNotMade.Info();
					} else if (prices[i] == moneyDeposited)
					{
						return SuccessfulPurchase.Info();
					} else if (prices[i] < moneyDeposited)
					{
						return SuccessfulWithChange.Info();
					} else
					{
						return NotEnoughMoney.Info();
					}
				}
			}
			return "Stado de la compra no encontrado";
		}
	}

	static class PurchaseNotMade
	{
		public static string Info()
		{
			return "Compra no realizada debido a agotamiento del producto! dinero devuelto!";
		}
	}

	static class SuccessfulPurchase
	{
		public static string Info()
		{
			return "Compra exitosa!";
		}
	}

	static class SuccessfulWithChange
	{
		public static string Info()
		{
			return "Compra exitosa con cambio incluido!";
		}
	}

	static class NotEnoughMoney
	{
		public static string Info()
		{
			return "Dinero insuficiente para hacer la compra!";
		}
	}

}
