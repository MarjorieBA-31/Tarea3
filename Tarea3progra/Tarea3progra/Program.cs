using System;


namespace Tarea3progra
{
    class Program
    {
        static int size = 5;
        static int i = 0;
        static int usuario = 0;
        static int contador1 = 0;
        static int contador2 = 0;
        static int menores1 = 0;
        static int jovenes1 = 0;
        static int adultos1 = 0;
        static int size1 = 0;
        [Flags]
        enum rangos_edad
        {

            menores = -18,
            jovenes = 19 - 29,
            Adultos = 30,

        };
        struct caracteristicas
        {
            public int codigo;

            public string nombre;
            public string sexo;
            public int edad;
            public double edades;


        };
        static caracteristicas[] caracteristica;

        static void Agregar_Estudiantes()
        {
            int r = 0;
            while (r != 1)
            {
                Console.Clear();
                if (i < caracteristica.Length)
                {

                    Console.WriteLine("-* Estudiantes de la Universidad Hispanoamericana *-*");
                    Console.WriteLine("Ingreso de Estudiantes          ");
                    Console.Write("Digite el ID:                       ");
                    caracteristica[i].codigo = int.Parse(Console.ReadLine());
                    Console.Write("Digite el NOMBRE del estudiante:   ");
                    caracteristica[i].nombre = Console.ReadLine();
                    Console.Write("Digite el SEXO del estudiante:     ");
                    caracteristica[i].sexo = Console.ReadLine();
                    Console.Write("Digite La EDAD del estudiante:     ");
                    caracteristica[i].edad = int.Parse(Console.ReadLine());



                    if (caracteristica[i].sexo == "fem")
                    {
                        contador1++;

                    }
                    if (caracteristica[i].sexo == "mas")
                    {
                        contador2++;
                    }

                    if (caracteristica[i].edad <= 18)
                    {
                        menores1++;

                    }
                    if (caracteristica[i].edad >= 19 && caracteristica[i].edad <= 29)
                    {
                        jovenes1++;
                    }
                    if (caracteristica[i].edad >= 30)
                    {
                        adultos1++;

                    }


                    Console.WriteLine("Desea agregar otro libro 0-Sí 1-No");
                    r = int.Parse(Console.ReadLine());
                    i++;
                }
                else
                {
                    Console.WriteLine("Registro de libros lleno..");
                    r = 1;
                    Console.ReadKey();
                }
            }

        }

        static void lista_Estudiantes()
        {
            int reg = 0;
            Console.Clear();
            Console.WriteLine("-* Imforme de Universidad Hispanoamericana *-*");
            Console.WriteLine("Listado de estudiantes             ");
            for (i = 0; i < caracteristica.Length; i++)
            {
                reg = i + 1;
                Console.WriteLine("Registro: " + reg);
                Console.WriteLine("ID:       " + caracteristica[i].codigo);
                Console.WriteLine("Nombre:   " + caracteristica[i].nombre);
                Console.WriteLine("Sexo:     " + caracteristica[i].sexo);
                Console.WriteLine("Edad:     " + caracteristica[i].edad);
            }
            Console.ReadKey();
        }

        static void modificar_Estudiantes()
        {
            int option = 0;
            int user = 0;
            int reg = 0;
            int r = 0;
            bool found = false;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("*-* Registro de Universidad Hispanoamericana *-*");
                Console.WriteLine("Modificación de los Estudiantes");
                Console.WriteLine("Digite el ID del estudiante");
                user = int.Parse(Console.ReadLine());
                for (i = 0; i < caracteristica.Length; i++)
                {
                    if (user == caracteristica[i].codigo)
                    {
                        reg = i + 1;


                        Console.WriteLine("ID:       " + caracteristica[i].codigo);
                        Console.WriteLine("Nombre:   " + caracteristica[i].nombre);
                        Console.WriteLine("Sexo:     " + caracteristica[i].edad);
                        Console.WriteLine("Edad:     " + caracteristica[i].edades);
                        found = true;



                        {
                            while (option != 5)
                            {
                                Console.Clear();

                                Console.WriteLine("Ingrese la opcion que desea cambiar");
                                Console.WriteLine("1.Nombre");
                                Console.WriteLine("2.Sexo");
                                Console.WriteLine("3.Edad");
                                Console.WriteLine("4.Ver cambios");
                                Console.WriteLine("5.Salir");

                                option = int.Parse(Console.ReadLine());
                                switch (option)
                                {
                                    case 1:
                                        Console.Clear();
                                        Console.WriteLine("Digite el nuevo nombre");
                                        caracteristica[i].nombre = Console.ReadLine();

                                        break;
                                    case 2:
                                        Console.Clear();
                                        Console.WriteLine("Digite el nuevo Sexo");
                                        caracteristica[i].sexo = Console.ReadLine();
                                        break;
                                    case 3:
                                        Console.Clear();
                                        Console.WriteLine("Rangos  el nuevo Rango de las edades del estudiante");
                                        Console.Write(rangos_edad.menores + ":" + (int)rangos_edad.menores + "\n" +
                                                      rangos_edad.jovenes + ":" + (int)rangos_edad.jovenes + "\n" +
                                                       rangos_edad.Adultos + ":" + (int)rangos_edad.Adultos + "\n");
                                        caracteristica[i].edades = double.Parse(Console.ReadLine());
                                        break;
                                    case 4:
                                        {
                                            //Buscar por registro
                                            Console.Clear();
                                            Console.WriteLine("-* Registro de Universidad Hispanoamericana*-*");
                                            Console.WriteLine("Registro actualizado           ");

                                            if (user == caracteristica[i].codigo)
                                            {
                                                reg = i + 1;
                                                Console.WriteLine("Registro: " + reg);
                                                Console.WriteLine("ID:       " + caracteristica[i].codigo);
                                                Console.WriteLine("Nombre:   " + caracteristica[i].nombre);
                                                Console.WriteLine("Sexo:     " + caracteristica[i].sexo);
                                                Console.WriteLine("Edad:     " + caracteristica[i].edad);
                                                Console.WriteLine("Edadess:  " + caracteristica[i].edades);
                                                found = true;
                                            }
                                            Console.WriteLine("Desea buscar otro libro 0-Sí 1-No");
                                            r = int.Parse(Console.ReadLine());
                                        }





                                        break;
                                    case 5:
                                        break;
                                }

                            }
                            if (!found)
                            {
                                Console.WriteLine("No se encontro ese ID");
                                found = false;
                            }
                            Console.WriteLine("Desea buscar otro libro 0-Sí 1-No");
                            r = int.Parse(Console.ReadLine());
                        }
                    }
                }
            }
        }

        static void borrado_estudiantes()
        {

            int ID = 0;
            int reg = 0;
            int r = 0;
            bool found = false;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("-* Registro de Universidad Hispanoamericana*-*");
                Console.WriteLine("Registros de Estudiantes que se desean borrar           ");
                Console.WriteLine("Digite el ID del estudiantes");
                ID = int.Parse(Console.ReadLine());
                for (i = 0; i < caracteristica.Length; i++)
                {
                    if (ID == caracteristica[i].codigo)
                    {
                        Console.Clear();

                        reg = i + 1;
                        reg = 0;


                    }

                }

                caracteristica[i].codigo = 0;
                caracteristica[i].nombre = "";
                caracteristica[i].sexo = "";
                caracteristica[i].edad = 0;
                Console.WriteLine("Registro:  " + reg);
                Console.WriteLine("ID:        " + caracteristica[i].codigo);
                Console.WriteLine("Nombre:    " + caracteristica[i].nombre);
                Console.WriteLine("Sexo:      " + caracteristica[i].sexo);
                Console.WriteLine("Edad:      " + caracteristica[i].edad);
                Console.WriteLine("Edadess:   " + caracteristica[i].edades);
                found = true;
            }

            if (!found)
            {
                Console.WriteLine("No se encontro ese ID");
                found = false;
            }
            Console.WriteLine("Desea buscar otro libro 0-Sí 1-No");
            r = int.Parse(Console.ReadLine());
        }


        static void imprecion_edad_sexo()
        {
            Console.Clear();


            Console.WriteLine("====================================================================\n" +

                                                "                  " + "Informe Clasificación estudiantil UH\n" +
                             "=====================================================================");
            Console.WriteLine(" ");

            Console.WriteLine("                               Universidad UH");
            Console.WriteLine(" ");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Clasificación por edad    ||   Clasificación por Género ");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Menores de edad:      " + menores1 + "        " + "||" + "     " + "Hombres:   " + contador2);
            Console.WriteLine("Jóvenes: " + "        " + jovenes1 + "        " + "||" + "     " + "Mujeres:   " + contador1);
            Console.WriteLine("Adultos: " + "        " + adultos1 + "        " + "||");
            Console.WriteLine(" ");
            Console.WriteLine("======================================================================");
            Console.WriteLine("Fin del informe");
            Console.WriteLine();
            Console.WriteLine("Presione la tecla INTRO para volver al menú");


            Console.ReadKey();
        }


        static void imformacion()
        {

            int r = 0;

            while (r != 1)
            {
                Console.Clear();
                if (i < caracteristica.Length)
                {
                    Console.WriteLine("Universidad UH");
                    Console.WriteLine("Ingreso de Estudiantes.             ");
                    Console.WriteLine();
                    Console.Write("Digite el código:                  ");
                    caracteristica[i].codigo = int.Parse(Console.ReadLine());
                    Console.Write("Digite el nombre del estudiante:    ");
                    caracteristica[i].nombre = Console.ReadLine();
                    Console.Write("Ingrese el sexo:     ");
                    caracteristica[i].sexo = Console.ReadLine();
                    if (caracteristica[i].sexo == "fem")
                    {
                        contador1++;

                    }
                    if (caracteristica[i].sexo == "mas")
                    {
                        contador2++;
                    }
                    Console.Write("Ingrese la edad:");
                    caracteristica[i].edad = int.Parse(Console.ReadLine());
                    if (caracteristica[i].edad <= 18)
                    {
                        menores1++;

                    }
                    if (caracteristica[i].edad >= 19 && caracteristica[i].edad <= 29)
                    {
                        jovenes1++;
                    }
                    if (caracteristica[i].edad >= 30)
                    {
                        adultos1++;

                    }


                    Console.WriteLine("Desea agregar otro estudiante 0-Sí 1-No");
                    r = int.Parse(Console.ReadLine());
                    i++;
                }
                else
                {
                    Console.WriteLine("Registro de estudiantes lleno...");
                    r = 1;
                    Console.ReadKey();
                }
            }


        }

        static void Imformacion_clasificada()
        {
            int reg = 00000;
            Console.Clear();


            Console.WriteLine("=======================================================================\n" +

                                                "                     " + "Listado Estudiantil\n" +
                           "==========================================================================");
            Console.WriteLine(" ");

            Console.WriteLine("Universidad UH");
            Console.WriteLine(" ");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Reg          Código         Nombre          Sexo           Edad    ");
            for (i = 0; i < caracteristica.Length; i++)
            {
                reg = i + 1;
                Console.WriteLine("  " + reg + "               " + caracteristica[i].codigo + "               " + caracteristica[i].nombre + "              " + caracteristica[i].sexo + "                " + caracteristica[i].edad + "   ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("============================================================================");
            Console.WriteLine("Fin del informe");

            Console.ReadKey();
        }
        static void Buscar_Estudiantes()
        {

            int ID = 0;
            int reg = 0;
            int r = 0;
            bool found = false;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("-* Librería el Buen Lector  *-*");
                Console.WriteLine("Búsquedad de libros.           ");
                Console.WriteLine("Digite el ID del libro a buscar");
                ID = int.Parse(Console.ReadLine());
                for (i = 0; i < caracteristica.Length; i++)
                {
                    if (ID == caracteristica[i].codigo)
                    {
                        reg = i + 1;
                        Console.WriteLine("Registro: " + reg);
                        Console.WriteLine("ID:       " + caracteristica[i].codigo);
                        Console.WriteLine("Nombre:   " + caracteristica[i].nombre);
                        Console.WriteLine("Sexo:     " + caracteristica[i].sexo);
                        Console.WriteLine("edad:     " + caracteristica[i].edad);
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese ID");
                    found = false;
                }
                Console.WriteLine("Desea buscar otro libro 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());
            }
        }

        static void Main()
        {
            caracteristica = new caracteristicas[size];

            do
            {
                Console.Clear();
                Console.WriteLine("Digite la cantidad de estudiantes a ingresar");
                size1 = int.Parse(Console.ReadLine());

                if (size1 < size)
                {
                    Console.Clear();
                    Console.WriteLine("Digite minimo 5 estudiantes");
                    Console.ReadKey();


                }

                else
                {


                    caracteristica = new caracteristicas[size1];
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("1.Ingreso de Estudiantes");
                        Console.WriteLine("2.Modificaciones de Estudiantes");
                        Console.WriteLine("3.Borrado de estudiantes");
                        Console.WriteLine("4.Busqueda de Estudiantes");
                        Console.WriteLine("5.Listado de Estudiantes");
                        Console.WriteLine("6.Imforme de clasificaion de Estudiantes");
                        Console.WriteLine("7.Salir");
                        usuario = int.Parse(Console.ReadLine());

                        switch (usuario)
                        {

                            case 1:
                                {
                                    Agregar_Estudiantes();
                                    imprecion_edad_sexo();
                                }
                                break;
                            case 2:
                                {
                                    modificar_Estudiantes();
                                }
                                break;
                            case 3:
                                {
                                    borrado_estudiantes();
                                }
                                break;
                            case 4:
                                {
                                    Buscar_Estudiantes();
                                }
                                break;
                            case 5:
                                {
                                    lista_Estudiantes();
                                }
                                break;
                            case 6:
                                {
                                    Imformacion_clasificada();
                                }
                                break;
                            case 7:
                                {

                                }
                                break;
                            default:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Seleccione una opción válida...");
                                    Console.ReadKey();
                                    break;
                                }

                        }

                    } while (size1 >= size && usuario != 7);
                }

            } while (usuario != 7);


        }
    }
}

