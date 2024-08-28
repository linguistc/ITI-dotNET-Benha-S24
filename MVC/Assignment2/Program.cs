namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n==========01==========\n");

            //1. Query to return words starting with the letter 'a' and ending with the letter 'm'
            var words = new string[] { "apple", "amazon", "arm" };
            var result1 = words.Where(w => w.ToLower().StartsWith("a")  && w.ToLower().EndsWith("m"));
           foreach (var w in result1)
                Console.WriteLine(w);

            Console.WriteLine("\n==========02==========\n");

            //2. Query to return the top 5 numbers from a list of integers in descending order
            var numbers1 = new List<int> { 4, 2, 7, 8, 10, 3, 6, 9, 5 };
            var result2 = numbers1.OrderByDescending(n => n).Take(5);

            foreach (var n in result2)
                Console.WriteLine(n);
            Console.WriteLine("\n==========03==========\n");

            // 3. Query to return a list of numbers and their squares only if the square is greater than 20
            var numbers2 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var result3 = numbers2.Select(n => new {Number = n,Square= n*n})
                                    .Where(n => n.Square > 20);

            foreach (var n in result3)
                Console.WriteLine(n);

            Console.WriteLine("\n==========04==========\n");

            //4. Query to replace the 'ea' substring with an asterisk (*) in a given list of words
            var words2 = new string[] { "clear", "real", "dear", "bear" };
            var result4 = words2.Select(w => w.Replace("ea", "*"));

            foreach (var w in result4)
                Console.WriteLine(w);

            Console.WriteLine("\n==========05==========\n");
            //5. Query to sort a list alphabetically and return the first word that contains the letter 'e'
            var words3 = new string[] { "Sameh", "Ahmed", "Emad", "Rashed"};
            var result5 = words3.OrderBy(w => w.ToLower()).FirstOrDefault(w => w.ToLower().Contains('e'));

            Console.WriteLine(result5);

            Console.WriteLine("\n==========06==========\n");

            //6.Query to return the most frequent character in a string
            string str = "Ahmad";
            char[] chars = str.ToLower().ToCharArray();

            var result06 = str.ToLower().GroupBy(c => c)
                            .OrderByDescending(g => g.Count())
                            .First()
                            .Key;

            Console.WriteLine(result06);

            Console.WriteLine("\n=========07===========\n");

            //7. Query to return a list of unique (non-duplicate) strings from a list of strings
            var strings = new List<string> { "abc", "xyz", "klm", "xyz", "abc", "abc", "rst" };
            var result07 = strings.GroupBy(s => s)
                                .Where(g => g.Count() == 1)
                                .Select(g => g.Key)
                                .ToList();

            foreach(var s in result07) Console.WriteLine(s);

            Console.WriteLine("\n==========08==========\n");
            //8. Query to return only uppercase words from a string

            var sentence = "AAA ever DEBT EbTdx sCount OUEM";
            var result8 = sentence.Split(' ')
                                 .Where(w => w.All(char.IsUpper))
                                 .ToList();

            foreach (var word in result8)
                Console.WriteLine(word);


            Console.WriteLine("\n====================\n");

        }
    }
}
