namespace ExampleProjTortoiseAndHareAlgorithm
{
    /* ------ Tortoise and Hare Algorithm ------ */

    internal class Program
    {
        public static bool FloydCycleDetection<T>(LinkedList<T> list)
        {
            if(list.Count <= 2)
            {
                return false;
            }

            LinkedListNode<T> tortoise = list.First.Next;
            LinkedListNode<T> hare = list.First.Next;

            while(tortoise == hare)
            {
                if(tortoise == hare)
                {
                    return true;
                }

                if(hare.Next != null)
                {
                    hare = hare.Next.Next;
                }

                tortoise = tortoise.Next;
            }

            return false;
        }

        

        static void Main(string[] args)
        {
            
        }
    }
}