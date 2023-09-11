using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerosEjercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, apellido, registro, primeraPalabra, segundaPalabra, eleccion, color, salir, siNo;
            int edad, aporte, numero, parImpar, suma, contador, referencia;


            Console.WriteLine($"Indice:\n\t" +
                $"1 Pseudocódigo (hecho en c#)\n\t" +
                $"A. Asignar, Leer y Escribir\t\t" +
                $"B. Decisión\t\t" +
                $"C. Repetición\t\t" +
                $"D. Arrays y Matrices\n");



            do
            {
                Console.WriteLine($"Elija las siguientes opciones:\n" +
                $"\t1 para el ejercicio A - 1a\n\t2 para el ejercicio A - 1b\n\t3 para el ejercicio A - 2\n" +
                $"\t4 para el ejercicio B - 1\n\t5 para el ejercicio B - 2\n\t6 para el ejercicio B - 3\n" +
                $"\t7 para el ejercicio B - 4\n\t8 para el ejercicio C - 1\n\t9 para el ejercicio C - 2\n" +
                $"\t10 para el ejercicio C - 3\n\t11 para el ejercicio C - 4\n\t12 para el ejercicio C - 5\n" +
                $"\t13 para el ejercicio C - 6\n\t14 para el ejercicio C - 7\n\t15 para el ejercicio C - 8\n" +
                $"\t16 para el ejercicio C - 9\n\t17 para el ejercicio C - 10\n\t18 para el ejercicio D - 1\n" +
                $"\t19 para el ejercicio D - 2\n\t20 para el ejercicio D - 3\n\t21 para el ejercicio D - 4\n" +
                $"\t22 para el ejercicio D - 5\n\t23 para el ejercicio D - 6");
                eleccion = Console.ReadLine();

                switch (eleccion)
                {
                    //ejercicio A 1a
                    case "1":
                        //1.Hacer un programa que solicite al usuario su nombre, apellido y número de registro,
                        //y guarde lo solicitado en variables.
                        nombre = PedirTexto("Ingrese su nombre");
                        apellido = PedirTexto("Ingrese su apellido");
                        registro = PedirTexto("Ingrese su numero de registro");
                        //a. Muestre en diferentes mensajes el nombre, apellido y número de registro del alumno/a.
                        Console.WriteLine("El nombre del alumno ingresado es: " + nombre);
                        Console.WriteLine("El apellido del alumno ingresado es: " + apellido);
                        Console.WriteLine("El numero de registro del alumno es: " + registro);
                        break;
                    //ejercicio A 1b
                    case "2":
                        //1.Hacer un programa que solicite al usuario su nombre, apellido y número de registro,
                        //y guarde lo solicitado en variables.
                        nombre = PedirTexto("Ingrese su nombre");
                        apellido = PedirTexto("Ingrese su apellido");
                        registro = PedirTexto("Ingrese su numero de registro");
                        //b.Muestre en un mismo mensaje el nombre, apellido y número de registro del alumno/a.
                        Console.WriteLine($"Los datos del alumno, (nombre) {nombre}, " +
                            $"(apellido) {apellido}, y numero de registro {registro}, " +
                            $" fueron ingresados correctamente.");
                        break;
                    //ejercicio A 2
                    case "3":
                        //2.Hacer un programa que solicite al usuario el ingreso de dos palabras.
                        //Luego, muestre en un mensaje si las palabras ingresadas son iguales.
                        primeraPalabra = PedirTexto("Ingrese la primera palabra").ToUpper();
                        segundaPalabra = PedirTexto("Ingrese la segunda palabra").ToUpper();
                        if (primeraPalabra == segundaPalabra)
                        {
                            Console.WriteLine($"Las palabras {primeraPalabra} y {segundaPalabra}  son iguales.");
                        }
                        else
                        {
                            Console.WriteLine($"Las palabras {primeraPalabra} y {segundaPalabra}  son distintas.");
                        }
                        break;
                    //ejercicio B 1
                    case "4":
                        //1.Hacer un programa que solicite la edad del usuario y muestre si es mayor
                        //o menor de edad.
                        //Una persona es mayor de edad cuando ya tiene 18 años o más.
                        do
                        {
                            edad = PedirIntero("Favor digitar su edad");
                        } while (edad < 0);


                        if (edad < 18)
                        {
                            Console.WriteLine($"Con {edad} años, eres menor de edad.");
                        }
                        else
                        {
                            Console.WriteLine($"Con {edad} años, eres mayor de edad.");
                        }
                        break;
                    //ejercicio B 2
                    case "5":
                        //2 Hacer un programa que solicite al usuario un color y muestre si es
                        //primario o no. Los colores primarios son el Rojo, Azul o Amarillo.
                        color = PedirTexto("Escriba su color favorito:").ToUpper();
                        if (color == "ROJO" || color == "AZUL" || color == "AMARILLO")
                        {
                            Console.WriteLine("Su color favorito es primario");
                        }
                        else
                        {
                            Console.WriteLine("Su color favorito es no primario");
                        }
                        break;
                    //ejercicio B 3
                    case "6":
                        //3.Hacer un programa que solicite al usuario la cantidad de años de aportes
                        //realizados para la jubilación. Luego, muestre si ya aportó lo suficiente.
                        //Si no alcanza, que muestre cuantos años le faltan.
                        //Una persona que aporta 30 o más años es suficiente.
                        do
                        {
                            aporte = PedirIntero("Indique la cantidad de aporte en años realizada para su jubilación.");
                        } while (aporte < 0);
                        if (aporte < 30)
                        {
                            Console.WriteLine("Faltan " + (30 - aporte) + " años de aporte para que tenga todos los aportes necesarios.");
                        }
                        else
                        {
                            Console.WriteLine("Ya tiene  la cantidad suficiente de aporte necesario para jubilarte.");
                        }
                        Console.WriteLine("numero de años de aportes registrados " + aporte);
                        break;
                    //ejercicio B 4
                    case "7":
                        //Hacer un programa que solicite al usuario un número y que escriba si es par o impar.
                        numero = PedirIntero("Escriba un numero por favor");
                        parImpar = numero % 2;
                        if (parImpar == 0)
                        {
                            Console.WriteLine("El numero ingresado es par");
                        }
                        else
                        {
                            Console.WriteLine("El numero ingresado es impar");
                        }
                        break;
                    //ejercicio C 1
                    case "8":
                        //Hacer un programa que solicite al usuario el ingreso de un número positivo,
                        //no deberá finalizar hasta no tener un ingreso válido.
                        do
                        {
                            numero = PedirIntero("Favor ingresar un numero entero positivo.");
                        } while (numero <= 0);
                        Console.WriteLine(numero + " fue el numero ingresado.");
                        break;
                    //ejercicio C 2
                    case "9":
                        //Hacer un programa que solo nos permita introducir los valores “S” o “N” en una variable.
                        //no deberá finalizar hasta no tener un ingreso válido.
                        do
                        {
                            siNo = PedirTexto("Ingrese S o N").ToUpper();
                        } while (siNo != "S" && siNo != "N");
                        Console.WriteLine("El valor ingresado fue: " + siNo);
                        break;
                    //ejercicio C 3
                    case "10":
                        //Hacer un programa que solicite ingreso de un nombre y lo muestre 20 veces de la siguiente manera:
                        //“Mi nombre es <ingreso>”.
                        int limite = 20;
                        nombre = PedirTexto("Favor ingresar su nombre:");

                        for (int i = 0; i < limite; i++)
                        {
                            Console.WriteLine($"{i + 1} Mi nombre es {nombre}");
                        }

                        break;
                    //ejercicio C 4
                    case "11":
                        //Hacer un programa que escriba la suma de los 100 primeros números
                        suma = 0;
                        for (int i = 0; i <= 100; i++)
                        {
                            suma += i;
                        }
                        Console.WriteLine("La suma de los numeros de 1 a 100 es: " + suma);
                        break;
                    //ejercicio C 5
                    case "12":
                        //Hacer un programa que escriba todos los números naturales que hay desde la unidad (1)
                        //hasta un número ingresado por el usuario.
                        referencia = 0;
                        do
                        {
                            numero = PedirIntero("Ingrese un numero positivo, por favor.");
                        } while (numero <= 0);

                        for (int i = 1; i <= numero; i++)
                        {
                            referencia = i;
                            Console.Write(referencia + " ");
                        }
                        Console.WriteLine("");
                        break;
                    //ejercicio C 6
                    case "13":
                        //Hacer un programa que permita introducir un número por el usuario y,
                        //escriba y cuente los múltiplos de 3 desde la unidad (1) hasta el número ingresado. 
                        contador = 0;
                        referencia = 0;
                        do
                        {
                            numero = PedirIntero("Ingrese un numero positivo, por favor.");
                        } while (numero <= 0);

                        Console.WriteLine("Los numeros multiplo de 3 es/son: ");

                        for (int i = 1; i <= numero; i++)
                        {
                            referencia = i;
                            if ((referencia % 3) == 0)
                            {
                                Console.Write(referencia + " ");
                                contador++;
                            }

                        }
                        Console.WriteLine("");
                        Console.WriteLine($"Hay {contador} multiplos de 3 hasta el numero ingresado.");
                        break;
                    //ejercicio C 7
                    case "14":
                        //Hacer un programa que solicite 20 ingresos al usuario de un número cada vez.
                        //Al finalizar, muestre cuántos números pares fueron ingresados.

                        int contadorPar = 0;
                        int contadorImpar = 0;
                        int provisorio = 0;

                        for (int i = 0; i < 20; i++)
                        {
                            provisorio = PedirIntero("Favor ingresar un numero entero. ");

                            if (provisorio % 2 == 0)
                            {
                                contadorPar++;
                            }
                            else
                            {
                                contadorImpar++;
                            }
                        }
                        Console.WriteLine("");
                        Console.WriteLine($"Hay {contadorPar} numeros pares y {contadorImpar} numero impares.");
                        break;
                    //ejercicio C 8
                    case "15":
                        //Hacer un programa que permita introducir dos números por el usuario, y escriba todos los números naturales
                        //que hay entre ambos números, incluyendolos, empezando por el menor. Además, se pide contar cuántos números
                        //hay entre ambos números, cuántos de ellos son pares y la suma de todos los impares.
                        //Mostrar los resultados calculados por pantalla. 
                        int numero1 = PedirIntero("Favor ingresar un numero entero");
                        int numero2 = PedirIntero("Favor ingresar otro numero entero");
                        int diferencia;
                        contadorPar = 0;
                        suma = 0;

                        while (numero1 < numero2)
                        {
                            diferencia = numero2 - numero1;
                            for (int i = 0; i <= diferencia; i++)
                            {
                                Console.Write(numero1 + " ");
                                if (numero1 % 2 == 0)
                                {
                                    contadorPar++;
                                }
                                else
                                {
                                    suma += numero1;
                                }
                                numero1++;
                            }
                            numero1 = numero2;

                        }
                        while (numero2 < numero1)
                        {
                            diferencia = numero1 - numero2;
                            for (int i = 0; i <= diferencia; i++)
                            {
                                Console.Write(numero2 + " ");
                                if (numero2 % 2 == 0)
                                {
                                    contadorPar++;
                                }
                                else
                                {
                                    suma += numero2;
                                }
                                numero2++;
                            }
                            numero1 = numero2;

                        }
                        Console.WriteLine("");
                        Console.WriteLine($"Hay {contadorPar} numeros pares, y la suma de los numeros impar = {suma}");

                        break;
                    //ejercicio C 9
                    case "16":
                        //Hacer un programa que solicite el ingreso de 5 números y que muestre el mayor y el menor de los ingresados.
                        int mayor = int.MinValue;
                        int menor = int.MaxValue;

                        for (int i = 0; i < 5; i++)
                        {
                            numero = PedirIntero("Ingrese un numero entero");
                            if (numero <= menor)
                            {
                                menor = numero;
                            }
                            else if (numero >= mayor)
                            {
                                mayor = numero;
                            }
                        }
                        Console.WriteLine($"De los 5 numeros ingresados, {mayor} es el mayor y {menor} es el menor");









                        break;
                    //ejercicio C 10
                    case "17":
                        //Hacer un programa que solicite el ingreso de un número y calcule el factorial.
                        int factorial = 1;
                        do
                        {
                            numero = PedirIntero("Favor ingresar un numero entero positivo");

                        } while (numero <= 0);
                        referencia = numero;
                        factorial = numero;
                        do
                        {
                            referencia--;
                            factorial *= referencia;

                        } while (referencia != 1);
                        Console.WriteLine($" El factorial de {numero} es igual a {factorial}");

                        break;
                    //enercicio D 1
                    case "18":
                        //Hacer un programa que solicite al usuario los días de la semana, los guarde en un array de 7 posiciones
                        //y los muestre de la siguiente manera: “Día <posición>: <Ingreso>”
                        String[] diasSemana = new String[7];

                        Console.WriteLine("Hola, vamos registrar los dias de la semana");

                        for (int i = 0; i < 7; i++)
                        {
                            diasSemana[i] = PedirTexto("Ingrese el dia");
                        }
                        for (int i = 0; i < 7; i++)
                        {
                            Console.WriteLine($"Día {i + 1}:{diasSemana[i]}");

                        }
                        Console.WriteLine("");
                        break;
                    //ejercicio D 2
                    case "19":
                        //Hacer un programa que solicite al usuario el largo del array. Luego, en cada posición del array,
                        //guardar la posición al cuadrado.

                        int largo = PedirIntero("Indique la candidad de elementos de su arreglo, por favor");
                        double[] doubleCuadrado = new double[largo];
                        for (int i = 0; i < doubleCuadrado.Length; i++)
                        {
                            doubleCuadrado[i] = Math.Pow(i, 2);
                        }
                        Console.WriteLine($"Los valores en su arreglo de {largo} elementos son:");
                        for (int i = 0; i < doubleCuadrado.Length; i++)
                        {
                            Console.Write($" ({doubleCuadrado[i]}) ");
                        }
                        Console.WriteLine("");

                        break;
                    //ejercicio D 3   
                    case "20":
                        //Hacer un programa que pida el tamaño de un array, y que luego lo
                        //complete pero solo permita ingresar números múltiplos de 4.
                        largo = PedirIntero("Indique la candidad de elementos de su arreglo, por favor");
                        int[] multiplosDeCuatro = new int[largo];
                        Console.WriteLine("Vamos a ingresar multiplos de 4 en el arreglo.");

                        for (int i = 0; i < multiplosDeCuatro.Length; i++)
                        {
                            do
                            {
                                numero = PedirIntero("Ingrese un numero, deve ser un multiplo de 4");

                            } while (numero % 4 != 0);
                            multiplosDeCuatro[i] = numero;
                            Console.WriteLine("Numero ingresado en la posición " + (i + 1));
                        }
                        Console.WriteLine("Su arreglo de multiplo de 4 es: ");
                        for (int i = 0; i < multiplosDeCuatro.Length; i++)
                        {
                            Console.Write($" ({multiplosDeCuatro[i]}) ");
                        }
                        Console.WriteLine("");
                        break;
                    //ejercicio D 4
                    case "21":
                        //Hacer un programa que permita ingresar 20 números enteros,
                        //calcule la suma de todos los elementos y la muestre por pantalla.
                        largo = 20;
                        int[] numeros = new int[largo];
                        suma = 0;
                        for (int i = 0; i < numeros.Length; i++)
                        {
                            numeros[i] = PedirIntero("Ingrese un numero entero para ser sumado, por favor.");
                            suma += numeros[i];
                        }
                        Console.WriteLine("");
                        for (int i = 0; i < numeros.Length; i++)
                        {
                            Console.Write($" ({numeros[i]}) ");

                        }
                        Console.WriteLine("");
                        Console.WriteLine($"La suma de todos los elementos: {suma}");
                        Console.WriteLine("");


                        break;
                    //ejercicio D 5
                    case "22":
                        //Hacer un programa que cree una matriz de 3 filas y 4 columnas,
                        //solicite números para llenar todas las posiciones y calcule y
                        //muestre la suma de todos los elementos guardados.
                        int fila = 3;
                        int columna = 4;
                        int[,] primeraMatriz = new int[fila, columna];
                        suma = 0;
                        for (int i = 0; i < fila; i++)
                        {
                            for (int j = 0; j < columna; j++)
                            {
                                primeraMatriz[i, j] = PedirIntero("Igrese un numero entero.");
                                suma += primeraMatriz[i, j];
                            }
                        }
                        for (int i = 0; i < fila; i++)
                        {
                            for (int j = 0; j < columna; j++)
                            {
                                Console.Write($"({primeraMatriz[i, j]})\t");
                            }
                            Console.WriteLine("");
                        }

                        Console.WriteLine($"La suma de todos los elementos es: {suma}");
                        Console.WriteLine("");
                        break;
                    //ejercicio D 6
                    case "23":
                        //Hacer un programa que cree una matriz de n filas y m columnas (debe solicitar los valores de n y m al usuario),
                        //solicite valores al usuario para completarla y muestre los valores de la última fila y de la última columna.
                        fila = PedirIntero("Cuantas filas tendrá su matriz?");
                        columna = PedirIntero("Cuantas columnas tendrá su matriz");
                        int[,] segundaMatriz = new int[fila, columna];
                        bool flag;
                        for (int i = 0; i < fila; i++)
                        {
                            for (int j = 0; j < columna; j++)
                            {
                                segundaMatriz[i, j] = PedirIntero("Igrese un numero entero.");

                            }
                        }
                        for (int i = 0; i < fila; i++)
                        {
                            for (int j = 0; j < columna; j++)
                            {
                                flag = true;
                                while ((segundaMatriz[i, j] == segundaMatriz[(fila - 1), (j)] || segundaMatriz[i, j] == segundaMatriz[(i), (columna - 1)]) && flag)
                                {
                                    Console.Write($"({segundaMatriz[i, j]})\t");
                                    flag = false;
                                }
                            }
                            Console.WriteLine("");
                        }

                        //Console.WriteLine($"La suma de todos los elementos es: {suma}");
                        //Console.WriteLine("");
                        break;

                    default:
                        Console.WriteLine("Opción inválida, intente nuevamente.");

                        break;

                }



                Console.WriteLine("Digite S para salir, cualquier tecla para continuar");
                salir = Console.ReadLine().ToUpper();

            } while (salir != "S");






        }

        static public string PedirTexto(String mensaje)
        {
            string valorRetorno = "";
            do
            {
                Console.WriteLine(mensaje);
                valorRetorno = Console.ReadLine();
                if (valorRetorno == "")
                {
                    Console.WriteLine("Debe ingresar un valor");
                }

            } while (valorRetorno == "");

            return valorRetorno;
        }
        static public int PedirIntero(String mensaje)
        {
            int valorRetorno;
            bool conversionExitosa;

            Console.WriteLine(mensaje);
            do
            {
                conversionExitosa = Int32.TryParse(Console.ReadLine(), out valorRetorno);
            } while (!conversionExitosa);
            return valorRetorno;
        }
    }
}
