int n,x,y;
Console.WriteLine("Enter size of matrices");
n = Convert.ToInt32(Console.ReadLine());
int[,] a = new int[n,n];
int[,] b = new int[n,n];
int[,] c = new int[n,n];
Console.WriteLine("Filling matrices");
Random rnd = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; i < n; j++)
    {
        a[i,j] = 1;
    }
}
Console.WriteLine("Matrice 1");
foreach(int i in a)
{ Console.Write("{0} ", i); }
Console.WriteLine("");
Console.WriteLine("Matrice 2");
foreach (int i in b)
{ Console.Write("{0} ", i); }


Console.WriteLine("");
Console.WriteLine("Matrice 3");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int k = 0; k < n; k++)
        {
            c[i,j] += a[i,k] * b[k,j];
        }
    }
}

foreach (int i in c)
{ Console.Write("{0} ", i); }