

Console.WriteLine("Podaj  swój wzrost: ");

int height = Int32.Parse(Console.ReadLine());

if (height <= 110)
{
    Console.WriteLine($"Jeżeli masz {height} Jeteś wielki jak Krasnolud ");
}
else if (height <= 150)
{
    Console.WriteLine($"Jeżeli masz {height} Jesteś jak Hobbit");
}
else if (height <= 180)
{
    Console.WriteLine($"Jeżeli masz {height} Jesteś Wielki");
}
else if (height > 180) 
{
    Console.WriteLine($"Jesteś olbrzymem");
};
