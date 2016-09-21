/*
 * Created by SharpDevelop.
 * User: Brian
 * Date: 21/09/2016
 * Time: 0:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.IO;
namespace ABMlibreria
{
	/// <summary>
	/// Description of Libreria.
	/// </summary>
	public class Libreria
	{
		
		private List<Libros> lista ;
		
		public Libreria()
		{
			lista=new List<Libros>();
			
		}
		public List<Libros> Libros
		{//Getter y Setter del atributo Lista de Libros
			get{return lista;}
			set{lista=value;}
		}
		
		public void agregarLibros(Libros l){
			lista.Add(l);
		}
		
//		public void eliminarLibro(){
//			if(buscarLibro())
//		}
		
		public Libros buscarLibro(string codig){
			int i=0;
			while(i<lista.Count)
			{
				if(lista[i].Codigo == codig)
				{
					return lista[i];
				}
				i++;
			}
			return null;
			
		}
		
		
		
		
		//Crea un fichero vacio fichero vacio
        //</summary>
        public void CreateEmptyFile(string fullPath)
        {
            if (!System.IO.File.Exists(fullPath))
            {
                using (System.IO.File.Create(fullPath)) { }
            }
        }
        
         // Crear un directorio vacio
        //</summary>
        public  void CreateEmptyDirectory(string fullPath)
        {
            if (!System.IO.Directory.Exists(fullPath))
            {
                System.IO.Directory.CreateDirectory(fullPath);
            }
        }
        
        //Escribe en el fichero todos los libros de la lista de libros de la libreria
        public void CargarLibrosArchivo(string ruta)
        {
        	int i=0;
        	try 
			{
				//Pasamos  filepath y ruta al constructor del StreamWriter 
				StreamWriter sw = new StreamWriter(ruta);

				while(i<Libros.Count)
				{
					sw.WriteLine("Codigo: "+Libros[0].Codigo);
					sw.WriteLine("Nombre: "+Libros[0].Nombre);
					sw.WriteLine("Marca: "+Libros[0].Marca);
					sw.WriteLine("Nombre Proveedor: "+Libros[0].NombreProveedor);
					sw.WriteLine("Precio Mayorista: $ "+Libros[0].precioM);
					sw.WriteLine("Precio Unitario : $ "+(Libros[0].precioU));
					sw.WriteLine("Stock :"+Libros[0].Stock+" Unid.");
					i++;
				}
				
				//Cerramos el Archivo
				sw.Close();
			}
			catch(Exception e)
			{
				Console.WriteLine("Exception: " + e.Message);
			}
			finally 
			{
				Console.WriteLine("Executing finally block.");
			}
        }
	}
}
