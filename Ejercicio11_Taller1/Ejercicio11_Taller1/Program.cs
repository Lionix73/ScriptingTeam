//Ejercicio 11 (Funciones)

int num1;
int num2;

string temp;

IngresarNumeros();

void IngresarNumeros()
{
    bool bandera = true;

    while (bandera)
    {
        Console.WriteLine("Ingrese el primer numero entero:");
        temp = Console.ReadLine();
        if (int.TryParse(temp, out num1))
        {
            Console.Clear();

            Console.WriteLine("Ingrese el segundo numero entero:");
            temp = Console.ReadLine();
            if (int.TryParse(temp, out num2))
            {
                Console.Clear();
                bandera = false;

                CalculadoraMenu();
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Error en la digitacion de numeros\n");
        } 
    }
}

void CalculadoraMenu()
{
    bool salir = false;
    int respuesta = 0;

    while (salir == false)
    {
        Console.WriteLine("______MENU_____");
        Console.WriteLine("1. Sumar           2. Restar");
        Console.WriteLine("3. Multiplicar     4. Salir");
        temp = Console.ReadLine();

        if (int.TryParse(temp,out respuesta)){
            switch (respuesta)
            {
                case 1:
                    Console.Clear();
                    Sumar(num1, num2);
                    break;

                case 2:
                    Console.Clear();
                    Restar(num1, num2);
                    break;

                case 3:
                    Console.Clear();
                    Multiplicar(num1, num2);
                    break;

                case 4:
                    Console.Clear();
                    salir = true;

                    Console.WriteLine("Gracias :)");
                    break;
            }
        }
    }
}

void Sumar(int a, int b)
{
    Console.WriteLine($"La suma es: {a + b}\n");
}

void Restar(int a, int b)
{
    Console.WriteLine($"La resta es: {a - b}\n");
}

void Multiplicar(int a, int b)
{
    Console.WriteLine($"La multiplicacion es: {a * b} \n");
}

