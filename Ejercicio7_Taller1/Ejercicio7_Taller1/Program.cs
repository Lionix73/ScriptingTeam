int cadenaNum;
string temp;
int tamanoArray;

bool bandera = true;

while (bandera)
{
    Console.WriteLine("Ingrese una cadena de numeros enteros positivos");
    temp = Console.ReadLine();

    if (int.TryParse(temp, out cadenaNum) && cadenaNum > 0)
    {
        tamanoArray = temp.Length;
        bandera = false;

        int[] arrayNum = new int[tamanoArray];

        for (int i = 0; i < tamanoArray; i++)
        {
            arrayNum[i] = int.Parse(temp[i].ToString());
        }

        Console.WriteLine("\n------------------------\n");

        Console.WriteLine("Array de números:");
        foreach (var num in arrayNum)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\n");
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Los numeros no son enteros positivos.\n");
    }
}



