// Пользователь вводит с клавиатуры *М* чисел. Посчитайте,
// сколько чисел больше *0* ввел пользователь.




int[] InputNum(int quantity)
{
    int Length = quantity;
    int[] numbers = new int[Length];
    for (int i = 0; i < numbers.Length; i++)
    {
        System.Console.Write($"Введите число номер {i+1}: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    return numbers;
}


int QuantityPositive(int[] num)
{
    int count = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] > 0)
        {
            count++;
        }
    }
    return count;
}


System.Console.Write("Сколько чисел вы хотите ввести: ");
int quantity = Convert.ToInt32(Console.ReadLine());

int[] num = InputNum(quantity);


int result = QuantityPositive(num);
System.Console.WriteLine($"Количество введенных чисел больше нуля равно: + {result}");



