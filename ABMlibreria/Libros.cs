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
	/// Description of Libro.
	/// </summary>
	public class Libros
	{
		private string codigo;
		private string nombre;
		private string marca;
		private string nombre_proveedor;
		private double precioUnitario;
		private double precioMayor;
		private int stock;
		
		
		public Libros(string codigo,string nombre,string marca,string nom_proveedor,double precioUn,double precioMa,int stock)
		{
			Codigo=codigo;
			Nombre=nombre;
			Marca=marca;
			NombreProveedor=nom_proveedor;
			precioU=precioUn;
			precioM=precioMa;
			Stock=stock;
		}
		
		public string Codigo
		{
			get{return codigo;}
			set{codigo=value;}
		}
		public string Nombre
		{
			get{return nombre;}
			set{nombre=value;}
		}
		public string Marca
		{
			get{return marca;}
			set{marca=value;}
		}
		public string NombreProveedor
		{
			get{return nombre_proveedor;}
			set{ nombre_proveedor=value;}
		}
		public double precioU
		{
			get{return precioUnitario;}
			set{precioUnitario=value;}
		}
		
		public double precioM
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
