/*
 * Created by SharpDevelop.
 * User: Cristian
 * Date: 06/09/2019
 * Time: 11:21 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ejer5
{
	class Program
	{
		public static void Main(string[] args)
		{
			string letra;
			
			Console.WriteLine("Digite una letra");
			letra= Console.ReadLine();
			
			if(letra=="a" || letra=="e" || letra=="i" || letra=="o" || letra=="u"){
				Console.WriteLine("Usted ha digitado una vocal");
			} else
				Console.WriteLine("Usted ha digitado una consonante");
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}