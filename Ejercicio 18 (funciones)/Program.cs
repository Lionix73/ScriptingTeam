// See https://aka.ms/new-console-template for more information

//Ejercicio 18

using System;

Console.Write("Ingresa un número de máximo 8 cifras: ");
int numero = int.Parse(Console.ReadLine());
int resultado = SumaDeNumeros(numero);
Console.WriteLine($"La suma de los dígitos hasta obtener un solo número es: {resultado}");

int SumaDeNumeros(int num)
{
    while (num > 9)
    {
        int suma = 0;

        while (num > 0)
        {
            suma += num % 10;
            num /= 10;
        }

        num = suma;
    }

    return num;
}

