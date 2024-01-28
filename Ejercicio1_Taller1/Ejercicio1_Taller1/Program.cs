Console.WriteLine("Ingrese las dimensiones de la matriz (nxm):");
Console.Write("Número de filas (n): ");
int filas = int.Parse(Console.ReadLine());

Console.Write("Número de columnas (m): ");
int columnas = int.Parse(Console.ReadLine());

int[,] matriz = new int[filas, columnas];

// Llenar la matriz
Console.WriteLine("Ingrese los elementos de la matriz:");
for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        Console.Write($"Elemento [{i + 1},{j + 1}]: ");
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}

// Mostrar la matriz original
Console.WriteLine("\nMatriz Original:");
MostrarMatriz(matriz);

// Transformar elementos negativos en su opuesto positivo
for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        if (matriz[i, j] < 0)
        {
            matriz[i, j] = Math.Abs(matriz[i, j]);
        }
    }
}



Console.WriteLine("\nMatriz con elementos negativos transformados:");
MostrarMatriz(matriz);

void MostrarMatriz(int[,] matriz)
{
    int filas = matriz.GetLength(0);
    int columnas = matriz.GetLength(1);

    for (int i = 0; i < filas; i++)
    {
        for (int j = 0; j < columnas; j++)
        {
            Console.Write(matriz[i, j] + " ");
        }
        Console.WriteLine();
    }
}
