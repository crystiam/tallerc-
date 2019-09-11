/*
 * Created by SharpDevelop.
 * User: Cristian
 * Date: 05/09/2019
 * Time: 08:11 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ejer2
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int opcion, b,h;
			double circulo,rectangulo,triangulo,r,bt,ht;
			
			Console.WriteLine("Digite 1 para el area del circulo");
			Console.WriteLine("Digite 2 para el area del rectangulo");
			Console.WriteLine("Digite 3 para el area del triangulo");
			
			Console.Write("Digite su opcion: ");
			opcion= int.Parse(Console.ReadLine());
			
			if(opcion==1){
				Console.Write("Ingresar radio del circulo: ");
				r=double.Parse(Console.ReadLine());
				circulo=3.14*Math.Pow(r,2);
				Console.WriteLine("El area del circulo es: "+circulo);
			}else if(opcion==2){
				Console.Write("Ingresar base del rectangulo: ");
				b=int.Parse(Console.ReadLine());
				Console.Write("Ingresar altura del rectangulo: ");
				h=int.Parse(Console.ReadLine());
				rectangulo=b*h;
				Console.WriteLine("El area del rectangulo es: "+rectangulo);
			}else if(opcion==3){
			    Console.Write("Ingresar base del triangulo: ");
				bt=double.Parse(Console.ReadLine());
				Console.Write("Ingresar altura del triangulo: ");
				ht=double.Parse(Console.ReadLine());
				triangulo=(bt*ht)/2;
				Console.WriteLine("El area del triangulo es: "+triangulo);
			}else
				Console.WriteLine("Numero no registrado");
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}