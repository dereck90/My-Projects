import java.io.*;
import java.util.Scanner;

public class Inventario
{
	public static double suma(double x[])//Metodo para sumar
	{
		double suma = 0;
 		
   	for(int i=0;i<x.length;i++)
		{
			suma+=x[i];
		}
		return suma;
	} 

	public static void main(String[] args)//Este es el main del programa
	{
	   Scanner keyboard = new Scanner(System.in);//Se declaran todas las variables necesarias
	   String usuario,
		       password;
		System.out.println("Usuario: ");
		usuario = keyboard.next();
		System.out.println("Password: ");
		password = keyboard.next();
		
				
		if(usuario.equals("Comp2315") && password.equals("1234"))//Esta es la parte de la contrasena para poder accerder al programa
		{
			System.out.println("Bienvenidos, Gracias por utilizar este programa");
		}
		else
		{
			System.out.println("Usuario o password equivocado");
			System.exit(-1);
		}
        
		FileReader reader;//Se declaran las variables de lectura y escritura
		Scanner fileInput,
		        leer;
		PrintWriter fileOutput;		  
		
		double precioArticulo[],//Estos son la lista de atributos de nuestro codigo
		       precioTotal[];		
		String nombreArticulo[],
				 descripcion[],
				 codigo[],
				 fechaCompra[],
				 fechaExp[],
				 strLine,
				 filename,
				 archivoSalida;
				 
		int opcion = 0,
			contador = 0,
			comprada[],
			vendida[],
			danada[],
			x=0;
			 
		System.out.print("Entre el nombre del archivo ");
		filename = keyboard.next()+".txt";

		
		try
		{
			reader = new FileReader (filename);//Abrir rl archivo
			leer = new Scanner (reader);//Leer del archivo
			while (leer.hasNextLine() && leer.nextLine() != null)//Leer el archivo linea por linea
			{
				contador++;
			}
			contador = contador / 10;
						
			leer.close();
		}
		catch (IOException e)//Se corrigen todos los posibles errores de los archivos
		{
			System.out.println("File error " + e);
		}		
		nombreArticulo = new String[contador];//Se le asignan los valores al arreglo
		descripcion = new String[contador];
		codigo = new String[contador];
		fechaCompra = new String[contador];
		fechaExp = new String[contador];
		comprada = new int[contador];
		danada = new int[contador];
		vendida = new int[contador];
		precioArticulo = new double[contador];
		precioTotal = new double[contador];
		
		try
		{
			reader = new FileReader (filename);//Abrir el archivo
			fileInput = new Scanner (reader);//Leer del archivo
						
			while (fileInput.hasNextLine())//Se lee linea por linea el archivo
			{
				strLine = fileInput.nextLine();//Se le asignan los valores que se leen del archivo
				nombreArticulo[x] = strLine;//a las variables correspondientes
				strLine = fileInput.nextLine();
				descripcion[x] = strLine;
				strLine = fileInput.nextLine();
				codigo[x] = strLine;
				strLine = fileInput.nextLine();
				fechaCompra[x] = strLine;
				strLine = fileInput.nextLine();
				fechaExp[x] = strLine;
				strLine = fileInput.nextLine();
				comprada[x] = Integer.valueOf(strLine);				
				strLine = fileInput.nextLine();
				danada[x] = Integer.valueOf(strLine);
				strLine = fileInput.nextLine();
				vendida[x] = Integer.valueOf(strLine);
				strLine = fileInput.nextLine();
				precioArticulo[x] = Double.valueOf(strLine);
				strLine = fileInput.nextLine();
				precioTotal[x] = Double.valueOf(strLine);
				x++;
			}
			fileInput.close();
			
			while (opcion != 9) //la opción 9 termina el while
			{  //esta es la parte del menu de opciones a escojer que se le muestra al usuario
				System.out.println("\n       Menu: ");
				System.out.println("\n1. Busqueda de articulo por codigo");
				System.out.println("2. Modificar articulos");
				System.out.println("3. Total de ventas");
				System.out.println("4. Mostrar Inventario");
				System.out.println("9. Salir del programa\n");
		                  
				System.out.print("Seleccione opción: ");
		
				opcion = keyboard.nextInt();
				
				switch (opcion)
				{
					case 1://esta es la opcion para buscar el articulo
					{
						String code;
						System.out.print("Entre el codigo del articulo: ");//se entra el nombre del articulo
						code = keyboard.next();//se guarda en la variable code
						
						for (int i=0; i < codigo.length; i++)//se mide el tamano del archivo
						{
							if ( code.equals(codigo[i]))//se compara para buscar por el codigo del articulo
							{
								System.out.println(nombreArticulo[i]);//Se imprime toda la informacion que tenga 
								System.out.println(descripcion[i]);   //que ver con el articulo
								System.out.println(codigo[i]);
								System.out.println(fechaCompra[i]);
								System.out.println(fechaExp[i]);
								System.out.println(comprada[i]);
								System.out.println(danada[i]);
								System.out.println(vendida[i]);
								System.out.println("$"+ precioArticulo[i]);
								System.out.println("$"+ precioTotal[i]);
							}
						}
						break;
					}
					case 2://opcion para modificar los articulos
					{
					  	String code;
					  					  
					  	System.out.println("Entre el codigo del articulo ");//se entra el codigo para buscar el articulo
					  	code = keyboard.next();// a modificar y se guarda en la variable code nuevamente
					  
						for(int i=0; i<codigo.length; i++)//se mide el tamano
						{
							if(code.equals(codigo[i]))//Se compara y se consigue el articulo a modificar
							{  //Esta son todas las opcines a modificar
								System.out.println("Nombre Actual: "+ nombreArticulo[i]);
								System.out.println("Entre el nuevo nombre del articulo ");
								nombreArticulo[i] = keyboard.next();
								System.out.println("Descripcion Actual: "+ descripcion[i]);
								System.out.println("Entre la nueva descripcion del articulo ");
								descripcion[i] = keyboard.next();
								System.out.println("Codigo Actual: "+ codigo[i]);
								System.out.println("Entre el nuevo codigo de busqueda del articulo ");
								codigo[i] = keyboard.next();
								System.out.println("Fecha de compra: "+ fechaCompra[i]);
								System.out.println("Entre la nueva fecha de compra del articulo ");
								fechaCompra[i] = keyboard.next();
								System.out.println("Fecha de expiracion: "+ fechaExp[i]);
								System.out.println("Entre la nueva fecha de expiracion del articulo ");
								fechaExp[i] = keyboard.next();
								System.out.println("Cantidad Comprada: "+ comprada[i]);
								System.out.println("Entre la nueva cantidad comprada de articulos ");
								comprada[i] = keyboard.nextInt();
								System.out.println("Cantidad Danada: "+ danada[i]);
								System.out.println("Entre la nueva cantidad danada de articulos ");
								danada[i] = keyboard.nextInt();
								System.out.println("Cantidad Vendida: "+ vendida[i]);
								System.out.println("Entre la nueva cantidad vendida de articulos ");
								vendida[i] = keyboard.nextInt();
								System.out.println("Precio del Articulo: $"+ precioArticulo[i]);
								System.out.println("Entre el nuevo precio del articulo ");
								precioArticulo[i] = keyboard.nextDouble();
								precioTotal[i] = precioArticulo[i] * vendida[i];
								System.out.println("Precio Total = $"+ precioTotal[i]);
						 	}
						}
					try//Nuevamente se abre el archivo para cambiar los valores anteriores
					{
						fileOutput = new PrintWriter (filename);//para escribir en el archivo
						for(int i=0; i<codigo.length; i++)//Se ejecuta de acuerdo el largo del arreglo
						{
							fileOutput.println(nombreArticulo[i]);//aqui se le asignan todos los nuevos valores
							fileOutput.println(descripcion[i]);//y se reescriben en el mismo archivo
							fileOutput.println(codigo[i]);
							fileOutput.println(fechaCompra[i]);
							fileOutput.println(fechaExp[i]);
							fileOutput.println(comprada[i]);
							fileOutput.println(danada[i]);
							fileOutput.println(vendida[i]);
							fileOutput.println(precioArticulo[i]);
							fileOutput.println(precioTotal[i]);
						}
						fileOutput.close();//Importante se cierra el archivo
					}
					catch (IOException e)//se capturan todos los errores que puedan ocurrir durante la lectura
					{//o escritura del archivo
						System.out.println("File error " + e);//Se muestran en pantalla los errores
					}  	
					
					break;
					}
					case 3://Esta opcion muestra el total de ventas del inventario
					{
					  //Se muestra en pantalla el total de ventas 
					  System.out.println("El Total de ventas fue: $" + suma(precioTotal));					  		
					  break;
					}
					case 4:
					{
						for (int i=0; i < codigo.length; i++)//se mide el tamano del archivo
						{
							System.out.println(nombreArticulo[i]);//Se imprime toda la informacion que tenga 
							System.out.println(descripcion[i]);   //que ver con el articulo
							System.out.println(codigo[i]);
							System.out.println(fechaCompra[i]);
							System.out.println(fechaExp[i]);
							System.out.println(comprada[i]);
							System.out.println(danada[i]);
							System.out.println(vendida[i]);
							System.out.println("$"+ precioArticulo[i]);
							System.out.println("$"+ precioTotal[i]);
							
						}
						break;
					}
					case 9:
					{
					  System.out.println("Gracias por utilizar este programa.");
						//no se hace nada ya que esta es la opcion para salir del programa se deja en blanco a proposito
						break;//para que asi se cumpla la opcion break y salga del menu
					}
					default://se utiliza por si el usuario entra una opcion que no esta en el menu
					{
						System.out.println("Opción incorrecta");
					}
					
				}
			}
		}
		catch (IOException e)//Se guardan los posibles errores en la lectura y escritura del archivo
		{
			System.out.println("File error " + e);
		}
	}
}//Se termina el programa en su totalidad