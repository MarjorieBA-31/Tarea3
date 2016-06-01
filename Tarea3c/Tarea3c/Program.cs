using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3c
{
    class Program
    {
        static int muerte11 = 0;
        static int muerte = 0;
        static int muerte1 = 0;
        static int muerte2 = 0;
        static int muerte3 = 0;
        static int muerte4 = 0;
        static int muerte5 = 0;
        static int muerte6 = 0;
        static int muerte7 = 0;
        static int muerte8 = 0;
        static int muerte9 = 0;
        static int muerte10 = 0;
        static int muerte21 = 0;
        static int muerte22 = 0;
        static int muerte23 = 0;
        static int muerte24 = 0;
        static int muerte25 = 0;
        static int muerte26 = 0;
        static int muerte27 = 0;
        static int muerte28 = 0;
        static int muerte29 = 0;
        static int muerte30 = 0;
       
        static int vidas = 3;
        static int vida11 = 0;
        static int vida12 = 0;
        static int vida13 = 0;
        static int vida18 = 0;
        static int vida19 = 0;
        static int vida17 = 0;
        static int vida16 = 0;
        static int vida14 = 0;
        static int vida15 = 0;
        static int vida20 = 0;
        static int vida111 = 0;
        static int vida122 = 0;
        static int vida133 = 0;
        static int vida188 = 0;
        static int vida199 = 0;
        static int vida177 = 0;
        static int vida166 = 0;
        static int vida144 = 0;
        static int vida155 = 0;
        static int vida200 = 0;
        static int totalvidas = 0;

        static int totalvidas2 = 0;
        static int usuario;


        static void Binaria_octal(int vidas)
        {

            int o = 0;
            do
            {
                int integer = 0;


                bool nobinary = false;

                Console.Clear();


                Console.WriteLine("Sistemas numéricos");
                Console.WriteLine("Conversiones Binarias");
                Console.WriteLine("Seleccione la opción a convertir");

                Console.WriteLine("1. Binario a Octal");
                Console.WriteLine("2. octal a Binario");

                Console.WriteLine("3.salir");


                o = int.Parse(Console.ReadLine());
                switch (o)

                {
                    case 1:
                        {
                            Console.WriteLine("");
                            Console.WriteLine("       Preguntas a Resover ");

                            Console.WriteLine("1.Convierte el numero  52  binario");
                            Console.WriteLine("2.Convierta el numero 35 a binario");
                            Console.WriteLine("3.Convierta el numero 25 a binario");
                            Console.WriteLine("4.Convierta el numero 177 a binario");
                            Console.WriteLine("5.Convierta el numero 707 a binario");
                            Console.WriteLine("Digite el numero de la pregunta eligida");
                            int n1 = int.Parse(Console.ReadLine());
                            if (n1 == 1)
                            {
                                string binary = "";
                                back:

                                Console.WriteLine("Convierte el numero  52 a binario");

                                binary = Console.ReadLine();
                                foreach (char pos in binary)
                                {
                                    integer = (int)Char.GetNumericValue(pos);

                                    if (integer > 1)
                                    {
                                        nobinary = true;
                                    }
                                }
                                if (nobinary)
                                {
                                    Console.WriteLine("Número binario inválido");
                                    nobinary = false;
                                    goto back;
                                }

                                if (o == 1 && binary == "101010")
                                {
                                    integer = Convert.ToInt32(binary, 2);
                                    string octal = Convert.ToString(integer, 8);





                                    Console.WriteLine("Número correcto");
                                    Console.WriteLine("Octal: " + Convert.ToString(integer, 8));
                                    muerte10++;

                                }
                                else
                                {
                                    Console.WriteLine("Número incorrecto,se te restara una vida");
                                    vida11++;


                                }
                                Console.ReadLine();
                            }
                            if (n1 == 4)
                            {
                                string binary = "";
                                back:

                                Console.WriteLine("Convierte el numero  177 a binario");

                                binary = Console.ReadLine();
                                foreach (char pos in binary)
                                {
                                    integer = (int)Char.GetNumericValue(pos);

                                    if (integer > 1)
                                    {
                                        nobinary = true;
                                    }
                                }
                                if (nobinary)
                                {
                                    Console.WriteLine("Número binario inválido");
                                    nobinary = false;
                                    goto back;
                                }

                                if (o == 1 && binary == "1111111")
                                {
                                    integer = Convert.ToInt32(binary, 2);
                                    string octal = Convert.ToString(integer, 8);





                                    Console.WriteLine("Número correcto");
                                    Console.WriteLine("Octal: " + Convert.ToString(integer, 8));

                                    muerte1++;
                                }
                                else
                                {
                                    Console.WriteLine("Número incorrecto,se te restara una vida");
                                    vida16++;


                                }
                                Console.ReadLine();
                            }
                            if (n1 == 5)
                            {
                                string binary = "";
                                back:

                                Console.WriteLine("Convierte el numero  707 a binario");

                                binary = Console.ReadLine();
                                foreach (char pos in binary)
                                {
                                    integer = (int)Char.GetNumericValue(pos);

                                    if (integer > 1)
                                    {
                                        nobinary = true;
                                    }
                                }
                                if (nobinary)
                                {
                                    Console.WriteLine("Número binario inválido");
                                    nobinary = false;
                                    goto back;
                                }

                                if (o == 1 && binary == "111000111")
                                {
                                    integer = Convert.ToInt32(binary, 2);
                                    string octal = Convert.ToString(integer, 8);





                                    Console.WriteLine("Número correcto");
                                    Console.WriteLine("Octal: " + Convert.ToString(integer, 8));
                                    muerte2++;
                                }
                                else
                                {
                                    Console.WriteLine("Número incorrecto,se te restara una vida");
                                    vida17++;


                                }
                                Console.ReadLine();
                            }
                            if (n1 == 3)
                            {
                                string binary = "";
                                back:

                                Console.WriteLine("Convierte el numero  25 a binario");

                                binary = Console.ReadLine();
                                foreach (char pos in binary)
                                {
                                    integer = (int)Char.GetNumericValue(pos);

                                    if (integer > 1)
                                    {
                                        nobinary = true;
                                    }
                                }
                                if (nobinary)
                                {
                                    Console.WriteLine("Número binario inválido");
                                    nobinary = false;
                                    goto back;
                                }

                                if (o == 1 && binary == "010101")
                                {
                                    integer = Convert.ToInt32(binary, 2);
                                    string octal = Convert.ToString(integer, 8);





                                    Console.WriteLine("Número correcto");
                                    Console.WriteLine("Octal: " + Convert.ToString(integer, 8));
                                    muerte3++;
                                }
                                else
                                {
                                    Console.WriteLine("Número incorrecto,se te restara una vida");
                                    vida12++;

                                }
                                Console.ReadLine();
                            }
                            if (n1 == 2)
                            {
                                string binary = "";
                                back:

                                Console.WriteLine("Convierte el numero  35 a binario");

                                binary = Console.ReadLine();
                                foreach (char pos in binary)
                                {
                                    integer = (int)Char.GetNumericValue(pos);

                                    if (integer > 1)
                                    {
                                        nobinary = true;
                                    }
                                }
                                if (nobinary)
                                {
                                    Console.WriteLine("Número binario inválido");
                                    nobinary = false;
                                    goto back;
                                }

                                if (o == 1 && binary == "0011101")
                                {
                                    integer = Convert.ToInt32(binary, 2);
                                    string octal = Convert.ToString(integer, 8);





                                    Console.WriteLine("Número correcto");
                                    Console.WriteLine("Octal: " + Convert.ToString(integer, 8));
                                    muerte4++;
                                }
                                else
                                {
                                    Console.WriteLine("Número incorrecto,se te restara una vida");
                                    vida13++;


                                }
                                Console.ReadLine();
                            }
                            break;
                        }
                    case 2:
                        {


                            Console.WriteLine("");
                            Console.WriteLine("       Preguntas a Resover ");

                            Console.WriteLine("1.Convierte el numero  1011001011 a Hexadecimas");
                            Console.WriteLine("2.Convierta el numero 1011110001 a binario");
                            Console.WriteLine("3.Convierta el numero 111 a binario");
                            Console.WriteLine("4.Convierta el numero 110011 a binario");
                            Console.WriteLine("5.Convierta el numero 100011100 a binario");
                            Console.WriteLine("Digite el numero de la pregunta eligida");
                            int n1 = int.Parse(Console.ReadLine());
                            if (n1 == 1)
                            {
                                string consu = "";
                                back:

                                Console.WriteLine("Convierte el numero  101010 a Octal");

                                consu = Console.ReadLine();
                                foreach (char poss in consu)
                                {
                                    integer = (int)Char.GetNumericValue(poss);

                                    if (integer > 8)
                                    {
                                        nobinary = true;
                                    }
                                }
                                if (nobinary)
                                {
                                    Console.WriteLine("Número binario inválido");
                                    nobinary = false;
                                    goto back;
                                }

                                if (o == 2 && consu == "52")
                                {
                                    integer = Convert.ToInt32(consu, 8);
                                    string octal = Convert.ToString(integer, 2);


                                    Console.WriteLine("Número correcto");
                                    Console.WriteLine("Octal: " + Convert.ToString(integer, 2));
                                    muerte5++;
                                }
                                else
                                {


                                    Console.WriteLine("Número incorrecto,se te restara una vida");
                                    vida14++;

                                }
                            }
                            if (n1 == 4)
                            {
                                string consu = "";
                                back:

                                Console.WriteLine("Convierte el numero  110011 a Octal");

                                consu = Console.ReadLine();
                                foreach (char poss in consu)
                                {
                                    integer = (int)Char.GetNumericValue(poss);

                                    if (integer > 8)
                                    {
                                        nobinary = true;
                                    }
                                }
                                if (nobinary)
                                {
                                    Console.WriteLine("Número binario inválido");
                                    nobinary = false;
                                    goto back;
                                }

                                if (o == 2 && consu == "63")
                                {
                                    integer = Convert.ToInt32(consu, 8);
                                    string octal = Convert.ToString(integer, 2);


                                    Console.WriteLine("Número correcto");
                                    Console.WriteLine("Octal: " + Convert.ToString(integer, 2));
                                    muerte6++;
                                }
                                else
                                {


                                    Console.WriteLine("Número incorrecto,se te restara una vida");
                                    vida19++;
                                    muerte6++;
                                }
                            }
                            if (n1 == 5)
                            {
                                string consu = "";
                                back:

                                Console.WriteLine("Convierte el numero  100011100 a Octal");

                                consu = Console.ReadLine();
                                foreach (char poss in consu)
                                {
                                    integer = (int)Char.GetNumericValue(poss);

                                    if (integer > 8)
                                    {
                                        nobinary = true;
                                    }
                                }
                                if (nobinary)
                                {
                                    Console.WriteLine("Número binario inválido");
                                    nobinary = false;
                                    goto back;
                                }

                                if (o == 2 && consu == "434")
                                {
                                    integer = Convert.ToInt32(consu, 8);
                                    string octal = Convert.ToString(integer, 2);


                                    Console.WriteLine("Número correcto");
                                    Console.WriteLine("Octal: " + Convert.ToString(integer, 2));
                                    muerte7++;
                                }
                                else
                                {


                                    Console.WriteLine("Número incorrecto,se te restara una vida");
                                    vida20++;

                                }
                            }
                            if (n1 == 3)
                            {
                                string consu = "";
                                back:

                                Console.WriteLine("Convierte el numero  111 a Octal");

                                consu = Console.ReadLine();
                                foreach (char poss in consu)
                                {
                                    integer = (int)Char.GetNumericValue(poss);

                                    if (integer > 8)
                                    {
                                        nobinary = true;
                                    }
                                }
                                if (nobinary)
                                {
                                    Console.WriteLine("Número binario inválido");
                                    nobinary = false;
                                    goto back;
                                }

                                if (o == 2 && consu == "7")
                                {
                                    integer = Convert.ToInt32(consu, 8);
                                    string octal = Convert.ToString(integer, 2);


                                    Console.WriteLine("Número correcto");
                                    Console.WriteLine("Octal: " + Convert.ToString(integer, 2));
                                    muerte8++;
                                }
                                else
                                {


                                    Console.WriteLine("Número incorrecto,se te restara una vida");
                                    vida18++;

                                }
                            }
                            if (n1 == 2)
                            {
                                string consu = "";
                                back:

                                Console.WriteLine("Convierte el numero  1011110001 a Octal");

                                consu = Console.ReadLine();
                                foreach (char poss in consu)
                                {
                                    integer = (int)Char.GetNumericValue(poss);

                                    if (integer > 8)
                                    {
                                        nobinary = true;
                                    }
                                }
                                if (nobinary)
                                {
                                    Console.WriteLine("Número binario inválido");
                                    nobinary = false;
                                    goto back;
                                }

                                if (o == 2 && consu == "1361")
                                {
                                    integer = Convert.ToInt32(consu, 8);
                                    string octal = Convert.ToString(integer, 2);


                                    Console.WriteLine("Número correcto");
                                    Console.WriteLine("Octal: " + Convert.ToString(integer, 2));
                                    muerte9++;
                                }
                                else
                                {


                                    Console.WriteLine("Número incorrecto,se te restara una vida");
                                    vida15++;

                                }
                            }

                        }
                        break;
                    case 3:
                        {

                        }

                        Console.ReadLine();


                        break;
                    default:
                        {
                            Console.WriteLine("Seleccione inválida..");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                }
                totalvidas = vida11 + vida12 + vida13 + vida14 + vida15 + vida16 + vida18 + vida19 + vida20 + vida17;
                muerte = muerte1 + muerte2 + muerte3 + muerte4 + muerte5 + muerte6 + muerte7 + muerte8 + muerte9 + muerte10;
                vidaultimaaa();
                Console.ReadKey();
            } while (o != 3);
        }

        static void Binaria_Hexadecimal(int vidas)
        {
            int o = 0;
            int integer = 0;
            string binary = "";

            do
            {
                bool nobinary = false;

                Console.Clear();
                Console.WriteLine("Sistemas numéricos");
                Console.WriteLine("Conversiones Binarias");
                Console.WriteLine("Seleccione la opción a convertir");

                Console.WriteLine("1. Binario a Hexadecimal");
                Console.WriteLine("2. Hexadecimal a Binario");
                Console.WriteLine("3. Salir");

                o = int.Parse(Console.ReadLine());
                switch (o)

                {
                    case 1:
                        {
                            Console.WriteLine("");
                            Console.WriteLine("       Preguntas a Resover ");

                            Console.WriteLine("1.Convierte el numero   2cb   binario");
                            Console.WriteLine("2.Convierta el numero  5f  binario");
                            Console.WriteLine("3.Convierta el numero  77  binario");
                            Console.WriteLine("4.Convierta el numero  b  binario");
                            Console.WriteLine("5.Convierta el numero  5b  binario");
                            Console.WriteLine("Digite el numero de la pregunta eligida");
                            int n1 = int.Parse(Console.ReadLine());
                            if (n1 == 1)
                            {
                                back:



                                Console.WriteLine("Convierte el numero  2cb  binario");

                                binary = Console.ReadLine();
                                foreach (char pos in binary)
                                {
                                    integer = (int)Char.GetNumericValue(pos);

                                    if (integer > 1)
                                    {
                                        nobinary = true;
                                    }
                                }
                                if (nobinary)
                                {
                                    Console.WriteLine("Número binario inválido");
                                    nobinary = false;
                                    goto back;
                                }

                                if (o == 1 && binary == "1011001011")
                                {
                                    integer = Convert.ToInt32(binary, 2);
                                    string octal = Convert.ToString(integer, 16);


                                    Console.WriteLine("Número correcto");
                                    Console.WriteLine("Octal: " + Convert.ToString(integer, 16));
                                    muerte21++;
                                }
                                else
                                {
                                    Console.WriteLine("Número incorrecto,se te restara una vida");
                                    vida111++;
                                }

                                Console.ReadLine();

                            }
                            if (n1 == 4)
                            {
                                back:



                                Console.WriteLine("Convierte el numero  b  binario");

                                binary = Console.ReadLine();
                                foreach (char pos in binary)
                                {
                                    integer = (int)Char.GetNumericValue(pos);

                                    if (integer > 1)
                                    {
                                        nobinary = true;
                                    }
                                }
                                if (nobinary)
                                {
                                    Console.WriteLine("Número binario inválido");
                                    nobinary = false;
                                    goto back;
                                }

                                if (o == 1 && binary == "1011")
                                {
                                    integer = Convert.ToInt32(binary, 2);
                                    string octal = Convert.ToString(integer, 16);


                                    Console.WriteLine("Número correcto");
                                    Console.WriteLine("Octal: " + Convert.ToString(integer, 16));
                                    muerte21++;
                                }
                                else
                                {
                                    Console.WriteLine("Número incorrecto,se te restara una vida");
                                    vida166++;
                                }

                                Console.ReadLine();

                            }
                            if (n1 == 5)
                            {
                                back:



                                Console.WriteLine("Convierte el numero  5b  binario");

                                binary = Console.ReadLine();
                                foreach (char pos in binary)
                                {
                                    integer = (int)Char.GetNumericValue(pos);

                                    if (integer > 1)
                                    {
                                        nobinary = true;
                                    }
                                }
                                if (nobinary)
                                {
                                    Console.WriteLine("Número binario inválido");
                                    nobinary = false;
                                    goto back;
                                }

                                if (o == 1 && binary == "1011011")
                                {
                                    integer = Convert.ToInt32(binary, 2);
                                    string octal = Convert.ToString(integer, 16);


                                    Console.WriteLine("Número correcto");
                                    Console.WriteLine("Octal: " + Convert.ToString(integer, 16));
                                    muerte23++;
                                }
                                else
                                {
                                    Console.WriteLine("Número incorrecto,se te restara una vida");
                                    vida177++;
                                }

                                Console.ReadLine();

                            }
                            if (n1 == 3)
                            {
                                back:



                                Console.WriteLine("Convierte el numero  77  binario");

                                binary = Console.ReadLine();
                                foreach (char pos in binary)
                                {
                                    integer = (int)Char.GetNumericValue(pos);

                                    if (integer > 1)
                                    {
                                        nobinary = true;
                                    }
                                }
                                if (nobinary)
                                {
                                    Console.WriteLine("Número binario inválido");
                                    nobinary = false;
                                    goto back;
                                }

                                if (o == 1 && binary == "1110111")
                                {
                                    integer = Convert.ToInt32(binary, 2);
                                    string octal = Convert.ToString(integer, 16);


                                    Console.WriteLine("Número correcto");
                                    Console.WriteLine("Octal: " + Convert.ToString(integer, 16));
                                    muerte24++;

                                }
                                else
                                {
                                    Console.WriteLine("Número incorrecto,se te restara una vida");
                                    vida122++;
                                }


                                Console.ReadLine();
                            }
                            if (n1 == 2)
                            {
                                back:



                                Console.WriteLine("Convierte el numero  5f binario");

                                binary = Console.ReadLine();
                                foreach (char pos in binary)
                                {
                                    integer = (int)Char.GetNumericValue(pos);

                                    if (integer > 1)
                                    {
                                        nobinary = true;
                                    }
                                }
                                if (nobinary)
                                {
                                    Console.WriteLine("Número binario inválido");
                                    nobinary = false;
                                    goto back;
                                }

                                if (o == 1 && binary == "1011111")
                                {
                                    integer = Convert.ToInt32(binary, 2);
                                    string octal = Convert.ToString(integer, 16);


                                    Console.WriteLine("Número correcto");
                                    Console.WriteLine("Octal: " + Convert.ToString(integer, 16));
                                    muerte25++;

                                }
                                else
                                {
                                    Console.WriteLine("Número incorrecto,se te restara una vida");
                                    vida133++;
                                }


                                Console.ReadLine();
                            }
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("");
                            Console.WriteLine("       Preguntas a Resover ");

                            Console.WriteLine("1.Convierte el numero  101010  a Hexadecimas");
                            Console.WriteLine("2.Convierta el numero 1010111 a binario");
                            Console.WriteLine("3.Convierta el numero 0111000011 a binario");
                            Console.WriteLine("4.Convierta el numero 01011111 a binario");
                            Console.WriteLine("4.Convierta el numero 11111111 a binario");
                            Console.WriteLine("Digite el numero de la pregunta eligida");
                            int n1 = int.Parse(Console.ReadLine());
                            if (n1 == 1)
                            {
                                string consu = "";
                                back:

                                Console.WriteLine("Convierte el numero  101010 a hexadecimal");

                                consu = Console.ReadLine();
                                foreach (char poss in consu)
                                {
                                    integer = (int)Char.GetNumericValue(poss);

                                    if (integer > 8)
                                    {
                                        nobinary = true;
                                    }
                                }
                                if (nobinary)
                                {
                                    Console.WriteLine("Número binario inválido");
                                    nobinary = false;
                                    goto back;
                                }

                                if (o == 2 && consu == "52")
                                {
                                    integer = Convert.ToInt32(consu, 16);
                                    string octal = Convert.ToString(integer, 2);


                                    Console.WriteLine("Número correcto");
                                    Console.WriteLine("Octal: " + Convert.ToString(integer, 16));
                                    muerte26++;

                                }
                                else
                                {


                                    Console.WriteLine("Número incorrecto,se te restara una vida");
                                    vida177++;
                                }
                                Console.ReadLine();
                            }


                            if (n1 == 3)
                            {
                                string consu = "";
                                back:

                                Console.WriteLine("Convierte el numero  0111000011 a hexadecimal");

                                consu = Console.ReadLine();
                                foreach (char poss in consu)
                                {
                                    integer = (int)Char.GetNumericValue(poss);

                                    if (integer > 8)
                                    {
                                        nobinary = true;
                                    }
                                }
                                if (nobinary)
                                {
                                    Console.WriteLine("Número binario inválido");
                                    nobinary = false;
                                    goto back;
                                }

                                if (o == 2 && consu == "1c3")
                                {
                                    integer = Convert.ToInt32(consu, 16);
                                    string octal = Convert.ToString(integer, 2);


                                    Console.WriteLine("Número correcto");
                                    Console.WriteLine("Octal: " + Convert.ToString(integer, 16));
                                    muerte27++;

                                }
                                else
                                {


                                    Console.WriteLine("Número incorrecto,se te restara una vida");
                                    vida188++;
                                }
                                Console.ReadLine();
                            }


                            if (n1 == 4)
                            {
                                string consu = "";
                                back:

                                Console.WriteLine("Convierte el numero  01011111 a hexadecimal");

                                consu = Console.ReadLine();
                                foreach (char poss in consu)
                                {
                                    integer = (int)Char.GetNumericValue(poss);

                                    if (integer > 8)
                                    {
                                        nobinary = true;
                                    }
                                }
                                if (nobinary)
                                {
                                    Console.WriteLine("Número binario inválido");
                                    nobinary = false;
                                    goto back;
                                }

                                if (o == 2 && consu == "5f")
                                {
                                    integer = Convert.ToInt32(consu, 16);
                                    string octal = Convert.ToString(integer, 2);


                                    Console.WriteLine("Número correcto");
                                    Console.WriteLine("Octal: " + Convert.ToString(integer, 16));
                                    muerte28++;

                                }
                                else
                                {


                                    Console.WriteLine("Número incorrecto,se te restara una vida");
                                    vida199++;
                                }
                                Console.ReadLine();
                            }
                            if (n1 == 5)
                            {
                                string consu = "";
                                back:

                                Console.WriteLine("Convierte el numero  11111111 a hexadecimal");

                                consu = Console.ReadLine();
                                foreach (char poss in consu)
                                {
                                    integer = (int)Char.GetNumericValue(poss);

                                    if (integer > 8)
                                    {
                                        nobinary = true;
                                    }
                                }
                                if (nobinary)
                                {
                                    Console.WriteLine("Número binario inválido");
                                    nobinary = false;
                                    goto back;
                                }

                                if (o == 2 && consu == "ff")
                                {
                                    integer = Convert.ToInt32(consu, 16);
                                    string octal = Convert.ToString(integer, 2);


                                    Console.WriteLine("Número correcto");
                                    Console.WriteLine("Octal: " + Convert.ToString(integer, 16));
                                    muerte30++;

                                }
                                else
                                {


                                    Console.WriteLine("Número incorrecto,se te restara una vida");
                                    vida200++;
                                }
                                Console.ReadLine();
                            }

                            if (n1 == 2)
                            {
                                string consu = "";
                                back:

                                Console.WriteLine("Convierte el numero  1010111 a hexadecimal");

                                consu = Console.ReadLine();
                                foreach (char poss in consu)
                                {
                                    integer = (int)Char.GetNumericValue(poss);

                                    if (integer > 8)
                                    {
                                        nobinary = true;
                                    }
                                }
                                if (nobinary)
                                {
                                    Console.WriteLine("Número binario inválido");
                                    nobinary = false;
                                    goto back;
                                }

                                if (o == 2 && consu == "57")
                                {
                                    integer = Convert.ToInt32(consu, 16);
                                    string octal = Convert.ToString(integer, 2);


                                    Console.WriteLine("Número correcto");
                                    Console.WriteLine("Octal: " + Convert.ToString(integer, 16));
                                    muerte29++;

                                }
                                else
                                {


                                    Console.WriteLine("Número incorrecto,se te restara una vida");
                                    vida155++;
                                }
                                Console.ReadLine();
                                Console.ReadKey();
                                Console.Clear();

                            }


                            break;
                        }
                    case 3:
                        {

                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Seleccione inválida..");


                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                }

                totalvidas2 = vida111 + vida122 + vida133 + vida144 + vida155 + vida166 + vida177 + vida188 + vida199 + vida200;
                muerte11 = muerte21 + muerte22 + muerte23 + muerte24 + muerte25 + muerte26 + muerte27 + muerte27 + muerte28 + muerte29 + muerte30;
                vidaultima();
                Console.ReadKey();
            } while (o != 3);
        }


        static void cronomertro()
        {
            Console.Clear();
            Console.WriteLine("Juego de agilidad numerica");
            Console.WriteLine("Este juego consta de en que se debe contestar la pregunta de forma correcta y"
                + "Contas de 5 vidas"
                + "perdara si logra perder 5 vidas "
                + "para poder comenzar nueva mente tienes que finalizar el programa"
                + "Por cada pregunta que conteste se te mostrara cuantas vidas as perdido ");
            DateTime inicio = DateTime.Now;



            System.Threading.Thread.Sleep(0);

            DateTime final = DateTime.Now;

            System.Threading.Thread.Sleep(0);



            Console.WriteLine("\n\nTiempo de juego: {0}", final - inicio);


            Console.WriteLine();


            DateTime fecha = DateTime.Now;
            Console.WriteLine(fecha.ToLongDateString());
            Console.WriteLine(fecha.ToShortTimeString());
            Console.ReadKey();


        }

        static void vidaultimaaa()
        {
            Console.Clear();
            Console.WriteLine("===============================================================================");
            Console.WriteLine("Si La puntuacion actual es de 10,ganas el juego");
            Console.WriteLine("si las vidas perdidas son menores o iguales a 5 ya perdistes");
            Console.WriteLine("Tienes que tener las 10 preguntas buenas antes de que se pierdan 5 vidas");
            Console.WriteLine("===============================================================================");
            Console.WriteLine("");




            Console.WriteLine("\n\n Puntos Actuales:" + muerte);
            Console.WriteLine("\n\n VIDAS Perdidas:" + totalvidas);
            if (totalvidas == 5)

            {

                Console.WriteLine("\n\nAs PERDIDO el juego  :(");
                Console.WriteLine("\n\n\n Vuelve al menu principal,para jugar nuevamente");
            }
            else
            { }
            if (muerte11 == 10)

            {
                Console.WriteLine("\n\n As GANADO el juego :)");
                Console.WriteLine("\n\n\n Vuelve al menu principal,para jugar nuevamente");

            }
            Console.WriteLine("\n\n\n\n\n\n");
            DateTime fecha = DateTime.Now;
            Console.WriteLine(fecha.ToLongDateString());
            Console.WriteLine(fecha.ToShortTimeString());
            Console.WriteLine();

        }
        static void vidaultima()
        {
            Console.Clear();
            Console.WriteLine("===============================================================================");
            Console.WriteLine("Si La puntuacion actual es de 10,ganas el juego");
            Console.WriteLine("si las vidas perdidas son menores o iguales a 5 ya perdistes");
            Console.WriteLine("Tienes que tener las 10 preguntas buenas antes de que se pierdan 5 vidas");
            Console.WriteLine("===============================================================================");
            Console.WriteLine("");




            Console.WriteLine("\n\n Puntos Actuales:" + muerte11);
            Console.WriteLine("\n\n VIDAS Perdidas:" + totalvidas2);
            if (totalvidas2 == 5)

            {

                Console.WriteLine("\n\nAs PERDIDO el juego  :(");
                Console.WriteLine("\n\n\n Vuelve al menu principal,para jugar nuevamente");
            }
            else
            { }
            if (muerte == 10)

            {
                Console.WriteLine("\n\n As GANADO el juego :)");
                Console.WriteLine("\n\n\n Vuelve al menu principal,para jugar nuevamente");

            }
            Console.WriteLine("\n\n\n\n\n\n");
            DateTime fecha = DateTime.Now;
            Console.WriteLine(fecha.ToLongDateString());
            Console.WriteLine(fecha.ToShortTimeString());
            Console.WriteLine();

        }
        static void Main()

        {

            do
            {


                Console.Clear();
                Console.WriteLine("-Seleccione una clasificacion-");
                Console.WriteLine("Seleccione una clasificacion");
                Console.WriteLine("1. Binario.Octal o Octal-Binario");
                Console.WriteLine("2. Binario-Hexadecimal o Hexadecimal-Binario");
                Console.WriteLine("3. Ver Notas ");
                Console.WriteLine("4. No jugar");

                Console.WriteLine("Seleccione una opción.");
                usuario = int.Parse(Console.ReadLine());
                switch (usuario)

                {
                    case 1:
                        {

                            Binaria_octal(vidas);
                            vidaultimaaa();
                            Console.ReadKey();

                            break;
                        }
                    case 2:
                        {
                            Binaria_Hexadecimal(vidas);
                            vidaultima();
                            Console.ReadKey();

                            break;
                        }
                    case 3:
                        {

                            cronomertro();

                            vidaultimaaa();

                            break;
                        }
                    case 4:
                        {

                            break;
                        }

                    default:
                        {

                            Console.WriteLine("Seleccione inválida..");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                }




            } while (usuario != 4);


        }
    }
}