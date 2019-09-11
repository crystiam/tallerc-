/*
 * Created by SharpDevelop.
 * User: Cristian
 * Date: 10/09/2019
 * Time: 04:11 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ejer4
{
	class Program
	{
		public static void Main(string[] args)
		{
			int unidades;
			double carga;
			string nombre;
			
			Console.WriteLine("Ingresar nombre del cliente");
			nombre= Console.ReadLine();
			Console.WriteLine("Ingresar unidades consumidas por el cliente");
			unidades=int.Parse(Console.ReadLine());
			
			Console.WriteLine("Nombre del usuario : "+nombre);
			Console.WriteLine("Unidades consumidas : "+unidades);
			
			
			
			if(unidades>=600){
				carga=unidades*2.00;
				Console.WriteLine("Importe a pagar es:"+carga);
			}else if(unidades<200){
				carga=unidades*1.20;
				Console.WriteLine("Importe a pagar es:"+carga);
			}else if(unidades>=200){
				carga=unidades*1.50;
				Console.WriteLine("Importe a pagar es:"+carga);
			}else if(unidades>=400){
				carga=unidades*1.80;
				Console.WriteLine("Importe a pagar es:"+carga);
			}
				
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}