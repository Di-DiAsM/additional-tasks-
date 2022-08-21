// 5. Конвертер валют. У пользователя есть баланс в каждой из представленных валют. 
// С помощью команд он может попросить сконвертировать одну валюту в другую. 
// Курс конвертации просто описать в программе. Программа заканчивает свою работу в
// тот момент, когда решит пользователь.

Console.Clear();

double Rub = 10000;
double USD = 1000;
double Euro = 50;

double currencyUSDRub = 60;
double currencyEuroRub = 75;
double currencyEuroUSD = 1.2;


Console.WriteLine("Добро пожаловать на свой счет в онлайн банке GB!!!");
Console.WriteLine("Выберите цифру соответствующей услуге:");
Console.WriteLine("1. Посмотреть остатки на счетах");
Console.WriteLine("2. Произвести перевод между счетами");
Console.WriteLine("3. Выйти из банка");
//int a = ReadInt("");

bool exit = true;
while (exit)
{
    double a = ReadInt("");
    if (a == 1)
    {
        Console.WriteLine($"счет: Рубли   {Rub}");
        Console.WriteLine($"счет: Доллары {USD}");
        Console.WriteLine($"счет: Евро    {Euro}");

    }
    else if (a == 2)
    {
        double firstСurrency = ReadInt("Введите валюту которую хотите конвектировать, выберите цифру соответствующей валюте: 1. - Rub, 2. - USD, 3. - Euro.");
        double quantityСurrency = ReadInt("Введите количество валюты: ");
        double secondСurrency = ReadInt("Введите валюту которую хотите пополнить, выберите цифру: 1. - Rub, 2. - USD, 3. - Euro.");
        if (firstСurrency > 3 || firstСurrency < 1 || secondСurrency > 3 || secondСurrency < 1)
        {
            Console.WriteLine("Ошибка ввода валюты, нужно выбирать цифры с 1 до 3х, поробуйте снова, нажмите 2");
        }
        if (firstСurrency == 1 && secondСurrency == 1)
        {
            Console.WriteLine("вы делаете неправильный перевод");
        }
        if (firstСurrency == 1 && secondСurrency == 2)
        {
            if (quantityСurrency > Rub)
            {
                Console.WriteLine("превышен лимит, у вас нет такого количества денег, попробуйте снова, нажмите 2");

            }
            else if (firstСurrency == 1 && secondСurrency == 2)                  // рубли в доллары
            {
                USD = USD + quantityСurrency / currencyUSDRub;
                Rub = Rub - quantityСurrency;
                Console.WriteLine("перевод успешно сделан: ");
                Console.WriteLine($"счет: Рубли   {Rub}");
                Console.WriteLine($"счет: Доллары {USD}");
                Console.WriteLine($"счет: Евро    {Euro}");
            
            }
        }
        else if (firstСurrency == 1 && secondСurrency == 3)
        {
            if (quantityСurrency > Rub)
            {
                Console.WriteLine("превышен лимит, у вас нет такого количества денег, попробуйте снова, нажмите 2");
            }
            else if (firstСurrency == 1 && secondСurrency == 3)                      // рубли в евро
            {
                Euro = Euro + quantityСurrency / currencyEuroRub;
                Rub = Rub - quantityСurrency;
                Console.WriteLine("перевод успешно сделан: ");
                Console.WriteLine($"счет: Рубли   {Rub}");
                Console.WriteLine($"счет: Доллары {USD}");
                Console.WriteLine($"счет: Евро    {Euro}");
            }
        }




        // доллары**************************************************************************

        if (firstСurrency == 2 && secondСurrency == 2)
        {
            Console.WriteLine("вы делаете неправильный перевод");
        }
        if (firstСurrency == 2 && secondСurrency == 1)
        {
            if (quantityСurrency > USD)
            {
                Console.WriteLine("превышен лимит, у вас нет такого количества денег, попробуйте снова, нажмите 2");
            }  
            else if(firstСurrency == 2 && secondСurrency == 1)                // доллары в рубли     
            {
                Rub = Rub + quantityСurrency * currencyUSDRub;
                USD = USD - quantityСurrency;
                Console.WriteLine("перевод успешно сделан: ");
                Console.WriteLine($"счет: Рубли   {Rub}");
                Console.WriteLine($"счет: Доллары {USD}");
                Console.WriteLine($"счет: Евро    {Euro}");
            }                
        }   
        else if (firstСurrency == 2 && secondСurrency == 3)
        {
            if (quantityСurrency > USD)
            {
                Console.WriteLine("превышен лимит, у вас нет такого количества денег, попробуйте снова, нажмите 2");
            }
            else if (firstСurrency == 2 && secondСurrency == 3)                    // доллары в евро
            {
                Euro = Euro + quantityСurrency / currencyEuroUSD;
                USD = USD - quantityСurrency;
                Console.WriteLine("перевод успешно сделан: ");
                Console.WriteLine($"счет: Рубли   {Rub}");
                Console.WriteLine($"счет: Доллары {USD}");
                Console.WriteLine($"счет: Евро    {Euro}");
            }

        }

    

             // евро***************************************************************************
        if (firstСurrency == 3 && secondСurrency == 3)
        {
            Console.WriteLine("вы делаете неправильный перевод");
        }
        if (firstСurrency == 3 && secondСurrency == 1)
        {
            if (quantityСurrency > Euro)
            {
                Console.WriteLine("превышен лимит, у вас нет такого количества денег, попробуйте снова, нажмите 2");
            }
            else if (firstСurrency == 3 && secondСurrency == 1)                  // евро в рубли  
            {
                Rub = Rub + quantityСurrency * currencyEuroRub;
                Euro = Euro - quantityСurrency;
                Console.WriteLine("перевод успешно сделан: ");
                Console.WriteLine($"счет: Рубли   {Rub}");
                Console.WriteLine($"счет: Доллары {USD}");
                Console.WriteLine($"счет: Евро    {Euro}");
            }
        else if (firstСurrency == 3 && secondСurrency == 2)  
        {
            if (quantityСurrency > Euro)
            {
            Console.WriteLine("превышен лимит, у вас нет такого количества денег, попробуйте снова, нажмите 2");
            }
        }               
            else if (firstСurrency == 3 && secondСurrency == 2)
            {
                USD = USD + quantityСurrency * currencyEuroUSD;
                Euro = Euro - quantityСurrency;
                Console.WriteLine("перевод успешно сделан: ");
                Console.WriteLine($"счет: Рубли   {Rub}");
                Console.WriteLine($"счет: Доллары {USD}");
                Console.WriteLine($"счет: Евро    {Euro}");
            }

        }
    }
    else if (a == 3)
    {
        Console.WriteLine("До свидания, мы будем очень рады видеть Вас у нас снова, и ценим, что Вы выбрали наш Банк!!!");
        exit = false;
    }
    else
    {
        Console.WriteLine("Не правильный ввод, попробуйте снова.");
    }
}


double ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToDouble(Console.ReadLine());
}
