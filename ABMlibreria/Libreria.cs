
using System;
using System.Collections.Generic;

namespace ABMlibreria
{
	/// <summary>
	/// Description of Libreria.
	/// </summary>
	public class Libreria
	{
		/* Atributos */
		private List<Libros> lista ;
		
		/* Constructor */
		public Libreria()
		{
			lista=new List<Libros>();	
		}
		
		/* Métodos */
		public List<Libros> ListLibros
		{//Getter y Setter del atributo Lista de Libros
			get{return lista;}
			set{lista=value;}
		}
		
		public void agregarLibros(Libros newBook){
			lista.Add(newBook);
		}
		
//		public void eliminarLibro(){
//			if(buscarLibro())
//		}
		
		public Libros buscarLibro(int code){
			foreach (Libros Book in lista)
			{
				if (Book.Equals(code))
				{
					return Book;
				}
			}
			return null;
			
		}
	}
}
