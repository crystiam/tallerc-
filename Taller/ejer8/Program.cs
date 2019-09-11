/*
 * Created by SharpDevelop.
 * User: Cristian
 * Date: 10/09/2019
 * Time: 03:19 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ejer8
{
	class Program
	{
		public static void Main(string[] args)
		{
			int precio;
			double descuento, total;
			
			Console.Write("Ingresar costo del articulo: ");
			precio= int.Parse(Console.ReadLine());
			
			if(precio>=200){
				descuento= precio*0.15;
				total= precio-descuento;
				Console.WriteLine("El valor a pagar con descuento es: "+total);
			}else if(precio>100){
			    descuento= precio*0.12;
				total= precio-descuento;
				Console.WriteLine("El valor a pagar con descuento es: "+total);
			}else if(precio<100){
			    descuento= precio*0.10;
				total= precio-descuento;
				Console.WriteLine("El valor a pagar con descuento es: "+total);
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}