// See https://aka.ms/new-console-temusing System;

class Program
{
    static int Get_rec(int n)
    {
        int x = n;
        while (x % 2 == 0)
        {
            x /= 2;
        }
        while (x % 5 == 0)
        {
            x /= 5;
        }
        if (x == 1)
        {
            return 0;
        }
        int r = 10;
        for (int i = 1; i < x; i++)
        {
            r = r % x;
            if (r == 1)
            {
                return i;
            }
            r = r * 10;
        }
        return 0;
    }
    static void Main()
    {
        int Max = 0;
        int ans = 0;
        for (int i = 2; i < 1000; i++)
        {
            if (Get_rec(i) > Max)
            {
                Max = Get_rec(i);
                ans = i;
            }
        }
        Console.Write(ans);

    }
}

