//Leer 25 edades y realizar lo siguiente, 1. Ingresar edades, 2. mostrar edades, 3. Mostrar mayores de edad, 4. mostrar menores de edad.

int[] edades = new int[25];

//1. Ingresar edades




//2. mostrar edades



//3. Mostrar mayores de edad
Console.WriteLine("Mayores de edad: ");
for (int i=0; i < edades.Length; i++)
{
    if (edades[i] >= 18)
    {
        Console.WriteLine(edades[i]);
    }
}

//4. mostrar menores de edad



