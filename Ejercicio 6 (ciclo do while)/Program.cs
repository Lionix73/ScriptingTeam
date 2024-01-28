// See https://aka.ms/new-console-template for more information

int suma = 0;
int numero = 1;

Console.Write("Ingrese el valor de n: ");
int n = int.Parse(Console.ReadLine());
int numerosRestantes = n;

do
{
    suma += numero;
    numero += 2;
    numerosRestantes--;
} while (numerosRestantes > 0);

Console.WriteLine($"La suma de los primeros {n} números impares es: {suma}");
