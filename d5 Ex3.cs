using System;

namespace has_neighbour
{
    class IfHasNeighbourTask
    {
        public static bool IfHasNeighbour(string word)
        {
            return word[0] == word[1] - 1 || word[0] == word[1] + 1 || word[2] == word[1] - 1 || word[2] == word[1] + 1;
        }

        public static void Main()
        {
            Console.WriteLine(IfHasNeighbour("derrick")); 
            Console.WriteLine(IfHasNeighbour("kevin roshan"));
            Console.WriteLine(IfHasNeighbour("cd"));
        }
    }
}
