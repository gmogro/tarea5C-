
using System;

namespace ABMlibreria
{
	/// <summary>
	/// Description of Libro.
	/// </summary>
	public class Libros
	{
		/* Atributos */
		private string codigo;
		private string nombre;
		private string marca;
		private string nombre_proveedor;
		private double precioMin;
		private double precioMay;
		private int stock;
		
		
		/* Constructor */
		public Libros(string codigo,string nombre,string marca,string nom_proveedor,double precioUn,double precioMa,int stock)
		{
			this.codigo=codigo;
			this.nombre=nombre;
			this.marca=marca;
			this.nombre_proveedor=nom_proveedor;
			this.precioMin=precioUn;
			this.precioMay=precioMa;
			this.stock=stock;
		}
		
		/* Métodos */
		/* Los unicos atributos modificables son estos */
		public string NombreProveedor
		{
			get{return nombre_proveedor;}
			set{ nombre_proveedor=value;}
		}
		public double PrecioMinorista
		{
			get{return precioUnitario;}
			set{precioUnitario=value;}
		}
		
		public double PrecioMayorista
		{
			get{return precioMayor;}
			set{precioMayor=value;}
		}
		public int Stock{
			get{return this.stock;}
			set{this.stock=value;}
		}
		
	}
}
