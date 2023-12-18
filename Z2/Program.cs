Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
int result = AckermannFunction(m, n);
Console.WriteLine($"Ackermann({m}, {n}) = {result}");
     int AckermannFunction(int M, int N)
    {
        if (M == 0)
        {
            return N + 1;
        }
        else if (N == 0)
        {
            return AckermannFunction(M - 1, 1);
        }
        else
        {
            return AckermannFunction(M- 1, AckermannFunction(M, N - 1));
        }
    }