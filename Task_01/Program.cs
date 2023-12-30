// Напишите программу, которая будет принимать
//  на вход число и возвращать сумму его цифр. 
//  Указание Использовать рекурсию.


int number = Convert.ToInt32(Console.ReadLine());

int sumOfDigits(int num)
{
    if(num < 10)
        return num;

    int sum = (num % 10) + sumOfDigits(num / 10);
    
    return sum;
}

Console.WriteLine(sumOfDigits(number));