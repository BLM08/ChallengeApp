Console.WriteLine("podaj liczbę: ");
string number = Console.ReadLine();
char[] letters = number.ToArray();

for (int i = 0; i < 10; i++)
{
    var result = 0;
    foreach (char letter in letters)
    {
        int charToNumber = letter - '0';
        if (charToNumber == i)
        {
            result++; 
        }
    }
    Console.WriteLine("W liczbie: " + number + "cyfra " + i + "występuje " + result + "razy.");
}