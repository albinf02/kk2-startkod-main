# Robust inköpslista

## Felrapport

### Fel 1: Totalsumma för låg
- Vad hände: totalsumman blev för låg. tre varor exempelvis 10 + 10 + 50 blev 60kr istället för 70kr.

- Varför: 
loopen i metoden total i shoppinglist.cs började med int i = 1. Då hoppar den över första varan. den börjar inte på index 0.

- Lösning: jag ändrade int i = 1 till int i = 0. då hoppar den inte över första varan i listan.

### Fel 2: krasch vid felaktig inmatning

- Vad hände: programmet kraschade med FormatException om man skrev något annat än ett tal i menyn, priset eller numret.

- Varför: Koden använde int.Parse för att göra inmatningen till ett tal. Om det inte går när man exempelvis skriver bokstäver blir det FormatException.

- Lösning: jag ändrade till int.TryParse, som returnerar false istället för att krascha, programmet skriver ett meddelande och går tillbaka till menyn. 

### Fel 3: Krasch vid ogiltigt nummer

- Vad hände: Om man valde "ta bort vara" och skrev ett nummer som inte fanns i listan, som exempelvis 0 -1 eller 999 kraschade programmet med ArgumentOutOfRangeException.

- Varför: Metoden RemoveAt i ShoppingList.cs anropade items.RemoveAt(number - 1 ) utan att kontrollera att numret fanns i listan. Därför blev det ArgumentOutOfRangeException.

- Lösning: RemoveAt kontrollerar nu att numret ligger mellan 1 och antalet varor. Annars retunerar den false istället för att ta bort något. Program.cs kollar det nu och matar ut "Det finns ingen vara med det numret"

### Fel 4:
- Vad hände:

- Varför:

- Lösning:
### Fel 5:
- Vad hände:

- Varför:

- Lösning:
### Fel 6:
- Vad hände:

- Varför:

- Lösning:
## Designval

## Klassdiagram


