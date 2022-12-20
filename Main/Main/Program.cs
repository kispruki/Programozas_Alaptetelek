List<int> l = new List<int>();
Random r = new Random();

for (int i = 0; i < 15; i++)
{
    l.Add(r.Next(-25, 26));
}

foreach (int i in l)
{
    Console.Write($"{i}, ");
}
Console.WriteLine();

int osszeg = 0;

foreach (int i in l)
{
    osszeg += i;
}

Console.WriteLine($"A lista összege: {osszeg}.");

int darab = 0;

foreach (int i in l)
{
    if (i % 2 == 0) { darab++; };
}
Console.WriteLine($"A listában {darab}db páros szam található.");

int max = l[0];
int min = l[0];

foreach (int i in l)
{
    if (i < min) { min = i; }
    if (i > max) { max = i; }
}

Console.WriteLine($"A lista legkisebb értéke: {min}.\nA lista legnagyobb értéke: {max}.");

bool van = false;
int index = 0;
int hol = 0;

while (!van && index < l.Count)
{
    if (l[index] == 10)
    {
        van = true;
        hol = index;
    };
    index++;
};
Console.WriteLine(van ? $"A listában van 10es szám a {hol}. helyen." : "A listában nincs 10es szám.");
