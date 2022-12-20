from random import randint as r


l = [r(-25,25) for i in range(15)]

print(l)

osszeg = 0

for i in l:
	osszeg += i

print(f"A lista összege: {osszeg}.")

darab = 0
for i in l:
	if i%2 == 0:
		darab+=1

print(f"A listában {darab}db páros szam található.")

max, min = l[0], l[0]

for i in l:
	if i<min: min = i
	if i>max: max = i

print(f"A lista legkisebb értéke: {min}.\nA lista legnagyobb értéke: {max}.")

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
