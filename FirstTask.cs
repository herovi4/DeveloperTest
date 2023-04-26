namespace Library
{
    public class ZadanieOne
    {
        public void Sequence_of_numbers()
        {
            int n;
            do
            {
                Console.Write("Введите число N: ");
            } while (!int.TryParse(Console.ReadLine(), out n));
            string result = string.Join(", ", Enumerable.Range(1, n));
            Console.WriteLine(result);
        }
    }
    public class ZadanieTwo
    {
        public static void Square()
        {
            int n;
            do
            {
                Console.Write("Введите нечетное число N: ");
            } while (!int.TryParse(Console.ReadLine(), out n) || (n % 2 == 0) || (n < 3));
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    Console.Write(row == n / 2 + 1 && col == n / 2 + 1 ? " " : "#");
                }
                Console.WriteLine();
            }
        }
    }
}
