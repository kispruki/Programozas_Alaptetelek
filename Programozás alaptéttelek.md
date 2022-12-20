Programozási alaptételből 4et tanultunk:
	-Összegzés (1)
	-Megszámlálás (2)
	-Szélsőérték kiválasztás (3)
	-Keresés (4)

    -Tölts fel egy 15 elemű listát véletlen számokkal [-25,25] és irjuk ki.

```c#
List<int> l = new List<int>();
Random r = new Random();

for (int i =0; i<15; i++){
l.Add(r.Next(-25,26));
}

foreach (int i in l){
Console.Write($"{i}, ");}
Console.WriteLine();
```

```Python
from random import randint as r


l = [r(-25,25) for i in range(15)]

print(l)

```

1. Összegzés

    - A feladat az, hogy a listán lévő számok összegét írjuk ki.

```csharp
int osszeg = 0;

foreach (int i in l){
osszeg += i;
}

Console.WriteLine($"A lista összege: {osszeg}.");
```

```python
osszeg = 0

for i in l:
	osszeg += i

print(f"A lista összege: {osszeg}.")
```


2. Megszamlálás

    - A feladat az, hogy számoljuk meg a hány darab páros szám van a listán.

```csharp
int darab = 0;

foreach (int i in l){
if (i%2 == 0){darab++;};
}
Console.WriteLine($"A listában {darab}db páros szam található.");
```

```python
darab = 0
for i in l:
	if i%2 == 0:
		darab+=1

print(f"A listában {darab}db páros szam található.")
```


3. Szélsőérték kiválasztás

    -  A feladat az, hogy kiírjuk a lista legkisebb és legnagyobb értékét.

```csharp
int max = l[0];
int min = l[0];

foreach (int i in l){
if (i<min){min = i;}
if (i>max){max = i;}}

Console.WriteLine($"A lista legkisebb értéke: {min}.\nA lista legnagyobb értéke: {max}.");
```

```python
max, min = l[0], l[0]

for i in l:
	if i<min: min = i
	if i>max: max = i

print(f"A lista legkisebb értéke: {min}.\nA lista legnagyobb értéke: {max}.")
```

4. Keresés

    - A feladat megnézni, hogy van-e a listában 10es szám és ha van akkor hol.

```csharp
bool van = false;
int index = 0;
int hol = 0;

while(!van &&index < l.Count)
{
    if (l[index] == 10)
    {
        van = true;
        hol = index;
    };
    index++;
};
Console.WriteLine(van?$"A listában van 10es szám a {hol}. helyen.":"A listában nincs 10es szám.");
```

```python
van = False
index = 0
hol = 0
while not van and index <len(l):
    if l[index] == 10:
        van = True
        hol = index
    index += 1 

if van:
    print(f"A listában van 10es szám. A {hol}. helyen.")
else:
    print("A listában nincs 10es szám.")
```
