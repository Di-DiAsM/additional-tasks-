Console.WriteLine("Введите пароль");
string aa = "Для Вас секретная информация: 'Сложнее всего начать действовать, все остальное зависит только от упорства!'";
string bb = "123"; // сначала делал без этой переменной, просто if(a == 123), но в условии написано 2 переменных поэтому добавил сюда
int currentcount = 2;

while(currentcount >= 0)
{
    string a = Console.ReadLine();
    if(a == bb)
    {
        Console.WriteLine(aa);
        break;
    }
    else
    {
        Console.WriteLine("Неправильный ввод пароля, попробуйте снова, попыток осталось " + currentcount);
        if(currentcount == 0)
        {
           Console.WriteLine("Доступ запрещен");
           break; 
        }
    }
    currentcount--;
}
// примерно так получилось