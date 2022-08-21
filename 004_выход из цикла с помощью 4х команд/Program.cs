// Есть программа с бесконечным циклом. Когда пользователь вводит exit или любые другие 4 команды, программа заканчивается
Console.Clear();

Console.WriteLine("Введите слово для выхода из цикла: exit, WriteName, WritePassword, Help");


// bool exit = false;
// while(exit = true)
// {
//     string? a = Console.ReadLine();
//     if(a == "exit" || a == "SetName" || a == "Help" || a == "SetPassword")
//     {
//         Console.WriteLine("Выход из цикла");
//         return;
//     }
    
// }
//**************************************************************************************
// я неправильно понял условие походу?


bool exit = false;
while(exit = true)
{
    string? a = Console.ReadLine();
    if(a == "exit")
    {
        Console.WriteLine("Выход из цикла");
        return;
    }
    else if(a == "WriteName")
    {
        Console.WriteLine("Введите имя");
        string? b = Console.ReadLine();
        Console.WriteLine($"Красивое имя, удачи {b}!");
        return;
    }
    else if(a == "WritePassword")
    {
        Console.Write("Введите пароль: ");
        string? b = Console.ReadLine();
        Console.Write("Удивительно но пароль верный");
        return;
    }
    else if(a == "Help")
    {
        Console.WriteLine("К сожалению никто не поможет, только exit");
        string? b = Console.ReadLine();
        Console.WriteLine("я серьезно!");
        
    }
}





