// See https://aka.ms/new-console-template for more information
float a, b, c = 0;
int aux;
do
{
    Console.WriteLine("\nIngrese una opcion:\n0-Salir\n1-Suma\n2-Resta\n3-Multiplicacion\n4-Division\n5-Valor absoluto\n6-Cuadrado\n7-Raiz cuadrada\n8-Seno\n9-Coseno\n10-Parte entera\n11-Max y Min entre dos numeros");
    bool control = int.TryParse(Console.ReadLine(), out aux);
    bool control1 = true, control2 = true;

    if (control && aux > 0 && aux < 12)
    {
        if ((aux > 0 && aux < 5) || aux == 11)
        {
            // CONTROL NUMEROS INGRESADOS
            do
            {
                if (!control1 || !control2)
                {
                    Console.WriteLine("Ingrese numeros validos!");
                }
                Console.WriteLine("Ingrese el valor de a: ");
                control1 = float.TryParse(Console.ReadLine(), out a);

                Console.WriteLine("Ingrese el valor de b: ");
                control2 = float.TryParse(Console.ReadLine(), out b);
            } while (!control1 || !control2);

            switch (aux)
            {
                case 1:
                    c = a + b;
                    break;
                case 2:
                    c = a - b;
                    break;
                case 3:
                    c = a * b;
                    break;
                case 4:
                    c = a / b;
                    break;
                default:
                    break;
            }
            if (aux == 11)
            {
                Console.WriteLine("Mayor: " + Math.Max(a, b));
                Console.WriteLine("Menor: " + Math.Min(a, b));
            }
            else
            {
                Console.WriteLine("Resultado: " + c);
            }
        }
        else if (aux > 5 && aux < 11)
        {
            do
            {
                if (!control1)
                {
                    Console.WriteLine("Ingrese un numero valido!");
                }
                Console.WriteLine("Ingrese el valor de a: ");
                control1 = float.TryParse(Console.ReadLine(), out a);
            } while (!control1);

            switch (aux)
            {
                case 5:
                    c = Math.Abs(a);
                    break;
                case 6:
                    c = a * a;
                    break;
                case 7:
                    c = (float)Math.Sqrt(a);
                    break;
                case 8:
                    c = (float)Math.Sin(a);
                    break;
                case 9:
                    c = (float)Math.Cos(a);
                    break;
                case 10:
                    c = (float)Math.Truncate(a);
                    break;
                default:
                    break;
            }
            Console.WriteLine("Resultado: " + c);
        }

    }
} while (aux > 0 && aux < 12);