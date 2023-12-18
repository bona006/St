Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
NaturalNumbers(m,n);
void NaturalNumbers(int M, int N)
{
    if(M<=N)
    {
        Console.Write(M+", ");
        NaturalNumbers(M+1,N);
    }
}