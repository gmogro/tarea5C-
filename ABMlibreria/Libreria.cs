/*
 * Created by SharpDevelop.
 * User: Brian
 * Date: 21/09/2016
 * Time: 0:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

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
			lista.add(l);
		}
		
//		public void eliminarLibro(){
//			if(buscarLibro())
//		}
		
		public Libros buscarLibro(int codig){
			int i=0;
			while(i<lista.Count)
			{
				if(lista[i].codigo == codig)
				{
					return lista[i];
				}
				i++;
			}
			return null;
			
		}
	}
}
