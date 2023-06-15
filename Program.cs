// See https://aka.ms/new-console-template for more information
float a, b, c = 0;
int aux;
do
{
    Console.WriteLine("\nIngrese una opcion:\n0-Salir\n1-Suma\n2-Resta\n3-Multiplicacion\n4-Division");
    int.TryParse(Console.ReadLine(), out aux);
    if (aux != 0)
    {
        Console.Write("Ingrese el valor de a: ");
        float.TryParse(Console.ReadLine(), out a);

        Console.Write("Ingrese el valor de b: ");
        float.TryParse(Console.ReadLine(), out b);
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
        Console.WriteLine("Resultado: " + c);
    }
} while (aux != 0);