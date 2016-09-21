
using System;
using System.IO;

namespace ABMlibreria
{
	/// <summary>
	/// Description of Program.
	/// </summary>
	public class Program
	{
		static void Main(string[] args)
		{
			byte op;
			do
			{
				op = Menu();
				switch(op) 
				{
				    case 1:
				        Console.WriteLine(" ====================== CARGA DE DATOS ==================================");
				        Console.Write("Ingrese el Codigo: ");string sCod;Console.ReadLine(sCod);
				        Console.Write("Ingrese el Nombre: ");string sNom;Console.ReadLine(sNom);
				        Console.Write("Ingrese el Marca: ");string sMarca;Console.ReadLine(sMarca);
				        Console.Write("Ingrese el Nombre de Proveedor: ");string sNomProv;Console.ReadLine(s);
				        Console.Write("Ingrese el Precio Minorista $: ");double sPrecMin= double.Parse(Console.ReadLine(sMarca);
				        Console.Write("Ingrese el Marca: ");double sPrecMay = double.Parse(Console.ReadLine(sMarca);
				        
				        /* Carga de los datos al archivo Binario */
				        FileStream fs = new FileStream(“binario.txt”, FileMode.Create);
						BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8);
						Long codigoCliente = 5487846;
						Int edad = 22;
						bool puntual = false;
						bw.Write(codigoCliente);
						bw.Write(edad);
						bw.Write(puntual);

				         break;
				    case 2:
				
				         break;
				    case 3:
				         
				         break;
					case 4:
				        
				         break;
					case 0:
				         
				         break;				         
				  	default:
				         Console.WriteLine("La Opción no es Valida.");
				          break;
				}	
			}
			while(op == 0);
			
		    Libros Books = new Libros();
			string fileName = "temp.txt";
		    FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
		    StreamWriter writer = new StreamWriter(stream);
		
		    writer.WriteLine("Esta es la primera línea del archivo.");
		    writer.Close();
		    
		    FileStream streamR = new FileStream(fileName, FileMode.Open,
		    FileAccess.Read);
		    StreamReader reader = new StreamReader(streamR);
		
		    while (reader.Peek() > -1) 
		      {
		         Console.WriteLine(reader.ReadLine());
		         Console.ReadKey();
		      }
		    reader.Close();
		}
		
		/*  */
		static byte Menu()
		{
			string sOpcion;
			Console.WriteLine(" ====================== LIBRERIA ==================================");
			Console.WriteLine("1 - Cargar un Libro.");
			Console.WriteLine("2 - Modificar Datos.");
			Console.WriteLine("3 - Ver Lista de Libros.");
			Console.WriteLine("4 - Buscar un Libro.");
			Console.WriteLine("0 - Salir.");
			Console.Write("Elija su Opción: ");Console.ReadLine(sOpcion);
			/* Convertimos el String a un valor numero Int */
			byte bOpcion;
			return bOpcion = sOpcion.ToString;
		}
		   
	}
}