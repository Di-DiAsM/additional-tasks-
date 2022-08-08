// Игра угадайка. Программа загадывает случайное число. Пользователь его угадывает.
// Если пользователь дает неправильный ответ, то программа сообщает, больше загаданное 
// число или меньше. На отгадывание дается три попытки.

int randomNumber = new Random().Next(1,11);
Console.WriteLine("Угадайте числ от 1 до 10, у Вас три попытки: ");
int numberOfAttempts = 2;

while(true)
{
    int number = Convert.ToInt32(Console.ReadLine());
    
    if(number == randomNumber)
    {
       Console.WriteLine("Верно, вы угадали, это чило: " + randomNumber); 
       break;
    }
    else if(number > randomNumber)
    {
        Console.WriteLine("Не угадали, число " + number + " больше загаданного числа. Можете попробовать еще " + numberOfAttempts + " раз.");
    }
    else if(number < randomNumber)
    {
        Console.WriteLine("Не угадали, число " + number + " меньше загаданного числа. Можете попробовать еще " + numberOfAttempts + " раз.");
    }
    if(numberOfAttempts == 0)
    {
        Console.WriteLine("Вы не угадали, загаданное число " + randomNumber);
        break;
    }
    numberOfAttempts--;
}
