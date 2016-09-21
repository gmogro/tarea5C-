
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
            /* CONSTANTE */
            const string FILE_NAME = "ABMLibreriaTest.dat";

            /* ATRIBUTOS  */
            byte op;

            /* Instanciamos un Objeto de la Clase Libreria */
            Libreria MiLibreria = new Libreria();

            do
            { 
                op = Menu();
                switch (op)
                {
                    case 1:
                        /* Ingresamos los datos por la consola */
                        Console.WriteLine(" ====================== CARGA DE DATOS ==================================");
                        Console.Write("Ingrese el Codigo: "); string sCod = Console.ReadLine();
                        Console.Write("Ingrese el Nombre: "); string sNom = Console.ReadLine();
                        Console.Write("Ingrese el Marca: "); string sMarca = Console.ReadLine();
                        Console.Write("Ingrese el Nombre de Proveedor: "); string sNomProv = Console.ReadLine();
                        Console.Write("Ingrese el Precio Minorista : $ "); double dPrecMin = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el Precio Mayorista : $ "); double dPrecMay = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el Stock: "); int iStock = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine(" ========================================================================");
                        /* Instanciamos un Objeto de la Clase Libros*/
                        Libros Libro = new Libros(sCod,sNom,sMarca,sNomProv,dPrecMin,dPrecMay,iStock);
                        /* Guardamos los datos */
                        MiLibreria.agregarLibro(Libro);

                        /* Si el Archivo no existe creamos uno nuevo */
                        if (!File.Exists(FILE_NAME))
                        {
                            
                            /* Asignamos el Stream y cargamos los datos binarios al Archivo. */
                            FileStream FSNew = new FileStream(FILE_NAME, FileMode.CreateNew, FileAccess.Write);
                            using (BinaryWriter bw = new BinaryWriter(FSNew))
                            {
                                bw.Write(sCod);
                                bw.Write(sNom);
                                bw.Write(sMarca);
                                bw.Write(sNomProv);
                                bw.Write(dPrecMin);
                                bw.Write(dPrecMay);
                                bw.Write(iStock);
                            }
                            Console.WriteLine("El Archivo {0} se creo con Exito.", FILE_NAME);
                            Console.WriteLine("Los datos fueron cargados!!");
                        }
                        else
                        {
                            /* Si el Archivo ya existe continuamos cargando datos dentro del mismo. */
                            /* Asignamos el Stream y cargamos los datos binarios al Archivo. */
                            FileStream FSAp = new FileStream(FILE_NAME, FileMode.Append, FileAccess.Write);
                            using (BinaryWriter bw = new BinaryWriter(FSAp))
                            {
                                bw.Write(sCod);
                                bw.Write(sNom);
                                bw.Write(sMarca);
                                bw.Write(sNomProv);
                                bw.Write(dPrecMin);
                                bw.Write(dPrecMay);
                            }
                            Console.WriteLine("Los datos fueron cargados!!");
                        }                  				
                        break;
				    case 2:
				
				         break;
				    case 3:
                        /* Creamos variables para cargar los datos del archivo */
                        string sCodigo;
                        string sNombre;
                        string sMarcaLibro;
                        string sNombreProveedor;
                        double dPrecioMin;
                        double dPrecioMay;
                        int iStockNow;
                        /* Controlamos que el Archivo Exista y lo abrimos */
                        if (File.Exists(FILE_NAME))
                        {
                            FileStream f = new FileStream(FILE_NAME, FileMode.Open,FileAccess.Read, FileShare.Read);
                            using (BinaryReader reader = new BinaryReader(f))
                            {
                                /* Mientras no sea el final del Archivo, leemos las lineas */
                                while (reader.PeekChar() > -1 )
                                {
                                    /* Asignamos los datos contenidos en el archivo a las variables para luego mostrarlas */
                                    sCodigo = reader.ReadString();
                                    sNombre = reader.ReadString();
                                    sMarcaLibro = reader.ReadString();
                                    sNombreProveedor = reader.ReadString();
                                    dPrecioMin = reader.ReadDouble();
                                    dPrecioMay = reader.ReadDouble();
                                    iStockNow = reader.ReadInt16();
                                    Console.WriteLine(" ====================== VISUALIZAR DATOS DEL ARCHIVO ==================================");
                                    Console.WriteLine("Codigo: " + sCodigo);
                                    Console.WriteLine("Nombre: " + sNombre);
                                    Console.WriteLine("Marca: " + sMarcaLibro);
                                    Console.WriteLine("Nombre de Proveedor: " + sNombreProveedor);
                                    Console.WriteLine("Precio Minorista: $" + dPrecioMin);
                                    Console.WriteLine("Precio Mayorista: $" + dPrecioMay);
                                    Console.WriteLine("Stock: "+iStockNow);
                                    Console.WriteLine(" ======================================================================================");
                                    Console.WriteLine();
                                    Console.WriteLine("Presione una Tecla para continuar....");
                                    Console.ReadKey();
                                }                                    
                            }
                        }
                        break;
					case 4:
                        List<Libros> Lista = MiLibreria.ListLibros;
				         break;
					case 0:
				         
				         break;				         
				  	default:
				         Console.WriteLine("La Opción no es Valida.");
				         break;
				}
                Console.Clear();
            }
			while(op != 0);
		}
		
		/* Menu de Opciones del Programa */
		static byte Menu()
		{
			Console.WriteLine(" ====================== LIBRERIA ==================================");
			Console.WriteLine("1 - Cargar un Libro.");
			Console.WriteLine("2 - Modificar Datos.");
			Console.WriteLine("3 - Visualizar los datos de Arhivo.");
			Console.WriteLine("4 - Visualizar los datos.");
			Console.WriteLine("0 - Salir.");
			Console.Write("Elija su Opción: ");
            string sOpcion = Console.ReadLine();
			/* Convertimos el String a un valor numerico Byte*/
			byte bOpcion;
            return bOpcion = Convert.ToByte(sOpcion);
		}
		   
	}
}