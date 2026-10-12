# Robust inköpslista

## Felrapport

### Fel 1: 
Vad hände: totalsumman blev för låg. tre varor exempelvis 10 + 10 + 50 blev 60kr istället för 70kr.

Varför: loopen i metoden total i shoppinglist.cs började med int i = 1. Då hoppar den över första varan. den börjar inte på index 0.

lösning: jag ändrade int i = 1 till int i = 0. då hoppar den inte över första varan i listan.

### Fel 2:

### Fel 3:

### Fel 4:

### Fel 5:

### Fel 6:

## Designval

## Klassdiagram


