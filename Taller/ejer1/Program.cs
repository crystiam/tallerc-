/*
 * Created by SharpDevelop.
 * User: Cristian
 * Date: 05/09/2019
 * Time: 07:56 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ejer1
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n1, n2, opcion;
            int adicion,sustracion,multiplicacion;
            double divicion;
            
    
            
            Console.Write("Diguite un numero: ");
            n1=int.Parse(Console.ReadLine());
            Console.Write("Diguite un segundo numero: ");
            n2=int.Parse(Console.ReadLine());
            
            Console.WriteLine("Las opciones son:");
            Console.WriteLine("1 - Adicion");
            Console.WriteLine("2 - Sustracion");
            Console.WriteLine("3 - Multiplicacion");
            Console.WriteLine("4 - Divicion");
            
            Console.Write("elegir una opcion: ");
            opcion=int.Parse(Console.ReadLine());
            
            if(opcion==1){
                adicion=n1+n2;
                Console.WriteLine("La adicion es: "+adicion);
            }else if(opcion==2){
                sustracion=n1-n2;
                Console.WriteLine("la sustracion es: "+ sustracion);
            }else if(opcion==3){
                multiplicacion=n1*n2;
                Console.WriteLine("La multiplicacion es: "+multiplicacion);
            }else if(opcion==4){
                divicion=n1/n2;
                Console.WriteLine("La divicion es: "+divicion);
            }else
                Console.WriteLine("La eleccion no existe"); 
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}