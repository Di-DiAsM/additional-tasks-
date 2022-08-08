// Есть программа с бесконечным циклом. Когда пользователь вводит exit программа заканчивается

while(1 < 2)
{
    string? a = Console.ReadLine();
    if(a == "exit")
    {
        Console.WriteLine("Выход из цикла");
        break;
    }
}

