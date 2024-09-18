int a = 0, b = 1, c;
Console.Write("Ingrese la cantidad de la secuencia: ");
int n = int.Parse(Console.ReadLine());

for (int i=0; i<n; i++)
{
    Console.WriteLine(a);
    c = a + b;
    a = b;
    b = c;
}