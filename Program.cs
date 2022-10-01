// Напишите программу которая на входе принимает число и выдает его квадрат
//(число умноженое на само себя)

int prompt(string message)
{
    Console.Write( message );
    String inputString = Console.ReadLine();
    int value = Convert.ToInt32(inputString);
    return value;
}

int value = prompt("Введите число -> ");
int square = value * value;
Console.WriteLine($"Квадрат числа {value} равен {square}");
