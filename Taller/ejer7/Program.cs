/*
 * Created by SharpDevelop.
 * User: Cristian
 * Date: 10/09/2019
 * Time: 02:16 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ejer7
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int n1,n2,n3;
			
			Console.Write("Ingresar numero 1: ");
			n1= int.Parse(Console.ReadLine());
			Console.Write("Ingresar numero 1: ");
			n2= int.Parse(Console.ReadLine());
			Console.Write("Ingresar numero 1: ");
			n3= int.Parse(Console.ReadLine());
			
			if(n1>n2 && n1>n3){
				Console.WriteLine("El numero mayor es: "+n1);
			}else if(n2>n1 && n2>n3){
				Console.WriteLine("El numero mayor es: "+n2);
			}else
				Console.WriteLine("El numero mayor es: "+n3);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}