import random as r


l = [r.randint(-25, 25)for i in range(15)]

osszeg = 0
for i in l:
    osszeg += i

darab = 0
for i in l:
    if i == 0:
        darab += 1

max, min = l[0], l[0]
for i in l:
    if i < min: min = i
    if i > max: max = i

van = False
index = 0
hol = 0
while not van and index <len(l):
    if l[index] == 10:
        van = True
        hol = index
    index += 1 

print(l)
print(f"Összeg: {osszeg};\n{darab} Darab 0 van a listában;\nA legkisebb szám:{min};\nA legnagyobb szám: {max}")

if van:
    print(f"A listában van 10es szám. A {hol}. helyen.")
else:
    print("A listában nincs 10es szám.")