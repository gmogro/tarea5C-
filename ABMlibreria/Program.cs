/*
 * Created by SharpDevelop.
 * User: Brian
 * Date: 21/09/2016
 * Time: 0:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ABMlibreria
{
	/// <summary>
	/// Description of Program.
	/// </summary>
	public class Program
	{
		public static void Main(string[] args)
		{
			string fileName = @"c:\Libreria";
			string fileName2 = @"c:\Libreria\Libros.txt";
        	string sourcePath = System.IO.Path.Combine(fileName);
        	
			//List<Libros> libros =  new List<Libros>();
			Libros l1 = new Libros("123","La Tregua","Persan","Libros Salta S.A",125.5,120.00,20);
			
			Libreria Lib = new Libreria();
			Lib.agregarLibros(l1);
			
			Lib.CreateEmptyDirectory(sourcePath);
			Lib.CreateEmptyFile(fileName2);
			
			Console.ReadKey(true);
		}
	}
}
