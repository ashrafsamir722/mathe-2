internal class Program
{
    private static void Main(string[] args)
    {
        int num1=Convert.ToInt32(Console.ReadLine());
        int num2= Convert.ToInt32(Console.ReadLine());
        int sum;
        for(int i=num1;i<=num2;i++)
        {
            int j = 1;
            sum = 0;
            while(j<i)
            {
                if(i%j==0)
                {
                    sum = sum + j;
                }
                j++;

            }
            if(sum==i)
                Console.WriteLine("{0}",i);
        }
    }
}