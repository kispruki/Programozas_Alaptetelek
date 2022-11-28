const int MAX = 15;
int[] l = new int[MAX];
Random r = new Random();

for (int i= 0; i<15; i++)
{
    l[i] = r.Next(-25, 26);
};


int osszeg = 0;
foreach (int i in l)
{
    osszeg += i;
};

int darab = 0;
foreach (int i in l)
{
    if (i == 0) { darab++; }
};

int min = l[0]; int max = l[0];

foreach (int i in l)
{
    if (i < min) { min = i; }
    if (i > max) { max = i; }
};

bool van = false;
int index = 0;
int hol = 0;

while(!van &&index < l.Length)
{
    if (l[index] == 10)
    {
        van = true;
        hol = index;
    };
    index++;
};


foreach (int i in l)
{
    Console.Write(i + ", ");
};
Console.WriteLine();
Console.WriteLine("Összeg: "+osszeg);
Console.WriteLine(darab+" Darab 0 van a listában.");
Console.WriteLine("Legkisebb: "+ min);
Console.WriteLine("Legnagyobb: "+ max);
Console.WriteLine(van?"A listában van 10es szám a "+hol+". helyen.":"A listában nincs 10es szám.");
