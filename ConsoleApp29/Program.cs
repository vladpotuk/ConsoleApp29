class Program
{
    static void Main()
    {
        // Завдання 1 - Відображення квадрата
        Console.Write("Введіть довжину сторони квадрата: ");
        int sideLength = int.Parse(Console.ReadLine());
        Console.Write("Введіть символ для відображення квадрата: ");
        char symbol = char.Parse(Console.ReadLine());
        Console.WriteLine("Відображення квадрата:");
        SquareDisplay.DisplaySquare(sideLength, symbol);

        // Завдання 2 - Перевірка на паліндром
        Console.Write("Введіть число для перевірки на паліндром: ");
        int number = int.Parse(Console.ReadLine());
        bool isPalindrome = PalindromeChecker.IsPalindrome(number);
        Console.WriteLine($"{number} {(isPalindrome ? "є" : "не є")} паліндромом.");

        // Завдання 3 - Фільтрація масиву
        Console.Write("Введіть елементи оригінального масиву (через пробіл): ");
        int[] originalArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.Write("Введіть елементи масиву для фільтрації (через пробіл): ");
        int[] filterArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] resultArray = ArrayFilter.FilterArray(originalArray, filterArray);

        Console.WriteLine("Результат роботи методу фільтрації:");
        Console.WriteLine(string.Join(" ", resultArray));
    }
}
