namespace _242251
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] test=new int[]{1,3,4,5,4,6,4,7,5,1,4,3 };
            Console.WriteLine(Search(test,4));
            
        }
        public static int Search(int[] array,int target)
        { int count=0;
            for (int i=0;i<array.Length;i++)
            { if (array[i]==target)
                {count++; }
            
            }
            if( count>0){return count;}
            else{return 0; } }
    }
}
