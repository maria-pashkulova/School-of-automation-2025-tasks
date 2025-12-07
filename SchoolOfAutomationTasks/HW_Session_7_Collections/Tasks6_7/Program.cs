namespace Tasks6_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Ani");
            names.Add("Borislav");
            names.Add("Maria");
            names.Add("Nikola");
            names.Add("Ivan");

            Console.Write("Initial names in list: ");
            PrintNames(names);


            //when we add or remove elements, especially if they are not in the end of the array,
            //we have to shift the rest of the elements and this is a slow operation.
            names.Remove("Ani");

            Console.Write($"{Environment.NewLine}Updated list: ");
            PrintNames(names);


        }

        static void PrintNames(List<string> names)
        {
            foreach (var name in names)
            {
                Console.Write($"{name} ");
            }
        }
    }
}
