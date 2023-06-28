// Ejercicio 1
/* 
int a;
int b;
a = 10;
b = a;
Console.WriteLine("valor de a:" + a);
Console.WriteLine("valor de b:" + b);

int num;
int resto;

Console.WriteLine("Ingrese un numero: ");
string? aux2 = Console.ReadLine();
bool resultado = int.TryParse(aux2, out num);

if (resultado == true)
{
    aux2 = "";
    while (num > 0)
    {
        resto = num % 10;
        num = num / 10;
        aux2 = aux2 + String.Concat(resto);
    }
    Console.WriteLine("Numero invertido: " + aux2);
}
else
{
    Console.WriteLine("El dato ingresado no es un numero");
}
 */

// Ejercicio 4

Console.WriteLine("Ingrese un texto: ");
string? cadena = Console.ReadLine();

Console.WriteLine("longitud: " + cadena.Length);

Console.WriteLine("Ingrese otro texto: ");
string? cadena2 = Console.ReadLine();

string? concat = string.Concat(cadena, cadena2);
Console.WriteLine("Concatenacion: " + concat);

foreach (char c in concat)
{
    Console.WriteLine(c);
}

Console.WriteLine(concat.ToUpper());
Console.WriteLine(concat.ToLower());


Console.WriteLine("Ingrese palabra a buscar:");
string? palabra = Console.ReadLine();
if (concat.Contains(palabra))
{
    Console.WriteLine("SI esta contenida");
}
else
{
    Console.WriteLine("NO esta contenida");
}

int a, b;
Console.WriteLine("Ingrese una ecuacion simple:");
string? ecuacion = Console.ReadLine();

if (ecuacion.Contains("+"))
{
    string[] partes = ecuacion.Split('+');
    int.TryParse(partes[0], out a);
    int.TryParse(partes[1], out b);
    Console.WriteLine("Resultado: " + (a + b));
}
else if (ecuacion.Contains("-"))
{
    string[] partes = ecuacion.Split('-');
    int.TryParse(partes[0], out a);
    int.TryParse(partes[1], out b);
    Console.WriteLine("Resultado: " + (a - b));
}
else if (ecuacion.Contains("*"))
{
    string[] partes = ecuacion.Split('*');
    int.TryParse(partes[0], out a);
    int.TryParse(partes[1], out b);
    Console.WriteLine("Resultado: " + (a * b));
}
else if (ecuacion.Contains("/"))
{
    string[] partes = ecuacion.Split('/');
    int.TryParse(partes[0], out a);
    int.TryParse(partes[1], out b);
    Console.WriteLine("Resultado: " + (a / b));
}