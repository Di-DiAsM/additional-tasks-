// Есть программа с бесконечным циклом. Когда пользователь вводит exit программа заканчивается
bool exit = false;
while(exit = true)
{
    string? a = Console.ReadLine();
    if(a == "exit")
    {
        Console.WriteLine("Выход из цикла");
        return;
    }
}

