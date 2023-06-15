// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
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