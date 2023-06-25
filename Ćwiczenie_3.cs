internal class Program
{
    private static void Main(string[] args)
    {
        double podajMediane(double[] tablicaPodana)
        {    
            if (tablicaPodana == null || tablicaPodana.Length == 0)
                throw new ArgumentException("Tablica jest pusta.");

            double[] tablicaPosortowana = (double[])tablicaPodana.Clone();
            Array.Sort(tablicaPosortowana);

            int rozmiar = tablicaPosortowana.Length;
            int srodek = rozmiar / 2;

            if (rozmiar % 2 != 0)
                return tablicaPosortowana[srodek];

            dynamic value1 = tablicaPosortowana[srodek];
            dynamic value2 = tablicaPosortowana[srodek - 1];
            return (value1 + value2) / 2;
        }

        Console.WriteLine("Podaj wielkość tablicy: ");
        int wielkoscTablicy = int.Parse(Console.ReadLine());
        double[] tablica = new double[wielkoscTablicy];

        for (int i = 0; i < tablica.Length; i++)
        {
            Console.WriteLine($"Pozycja {i + 1} ma się równać: ");
            tablica[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Mediana dla tablicy to: {podajMediane(tablica)}");
    }
}