using System;

class SubsetSumofK
{
    static bool bitCheck(int number, int position)
    {
        int mask = 1 << position;
        int numberNmask = number & mask;
        int bit = numberNmask >> position;
        if (bit == 1) return true;
        else return false;
    }
    static void Main()
    {
        Console.WriteLine("How many numbers? ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter number: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Sum? ");
        int desiredSum = int.Parse(Console.ReadLine());
        Console.WriteLine("How many numbers in subset?");
        int k = int.Parse(Console.ReadLine());
        int masklength = (Convert.ToString(n, 2)).Length;
        int mask = 0;
        int sum=0;
        int flag = 0;
        for (int i = 0; i < n; i++)
        {
            mask += (int)Math.Pow(2, i);
        }
        for (int i = 1; i <= mask; i++)
        {
            flag = 0;
            sum = 0;
            for (int bitpos = 0; bitpos <= n; bitpos++)
            {
                if (bitCheck(i,bitpos))
                {
                    sum += arr[bitpos];
                    flag++;
                }               
            }
            if (sum == desiredSum && flag == k)
            {
                Console.Write("yes: ");
                for (int bitpos = 0; bitpos <= n; bitpos++)
                {
                    if (bitCheck(i, bitpos))
                    {
                        Console.Write(arr[bitpos]+" ");
                    }
                }
                Console.WriteLine();
            }
        }        
    }
}
