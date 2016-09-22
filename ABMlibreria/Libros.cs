
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
        public void visualizarDatos()
        {
            Console.WriteLine(" ====================== VISUALIZAR DATOS DEL ARCHIVO ==================================");
            Console.WriteLine("Codigo: " + Codigo);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Nombre de Proveedor: " + NombreProveedor);
            Console.WriteLine("Precio Minorista: $" + PrecioMinorista);
            Console.WriteLine("Precio Mayorista: $" + PrecioMayorista);
            Console.WriteLine("Stock: " + Stock);
            Console.WriteLine(" ======================================================================================");
            Console.WriteLine();
            Console.WriteLine("Presione una Tecla para continuar....");
            Console.ReadKey();
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
		/* Los unicos atributos modificables son estos */
		public string NombreProveedor
		{
			get{return nombre_proveedor;}
			set{ nombre_proveedor=value;}
		}
		public double PrecioMinorista
		{
			get{return precioMin;}
			set{precioMin=value;}
		}
		
		public double PrecioMayorista
		{
			get{return precioMay;}
			set{precioMay=value;}
		}
		public int Stock{
			get{return this.stock;}
			set{this.stock=value;}
		}

		
	}
}
