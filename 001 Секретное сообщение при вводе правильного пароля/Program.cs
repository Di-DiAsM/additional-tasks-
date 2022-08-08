// в переменной string есть секретное сообщение, во второй есть пароль. Пользователю программы дается 3 попытки
// ввести пароль и увидеть секретное сообщение 

Console.WriteLine("Введите пароль");
string secretText = "Для Вас секретная информация: 'Сложнее всего начать действовать, все остальное зависит только от упорства!'";
string Pasword = "123"; // сначала делал без этой переменной, просто if(a == 123), но в условии написано 2 переменных поэтому 
                   //добавил сюда
int currentCount = 2;

while(currentCount >= 0)
{
    string? text = Console.ReadLine();
    if(text == Pasword)
    {
        Console.WriteLine(secretText);
        break;
    }
    else
    {
        Console.WriteLine("Неправильный ввод пароля, попробуйте снова, попыток осталось " + currentCount);
        if(currentCount == 0)
        {
           Console.WriteLine("Доступ запрещен");
           break; 
        }
    }
    currentCount--;
}
// примерно так получилось

