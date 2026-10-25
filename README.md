# Robust inköpslista

## Felrapport

### Fel 1: 
- Vad hände: totalsumman blev för låg. tre varor exempelvis 10 + 10 + 50 blev 60kr istället för 70kr.

- Varför: loopen i metoden total i shoppinglist.cs började med int i = 1. Då hoppar den över första varan. den börjar inte på index 0.

- Lösning: jag ändrade int i = 1 till int i = 0. då hoppar den inte över första varan i listan.

### Fel 2: 
krasch vid felaktig inmatning
- Vad hände: programmet kraschade med FormatException om man skrev något annat än ett tal i menyn, priset eller numret.

- Varför: Koden använde int.Parse för att göra inmatningen till ett tal. Om det inte går när man exempelvis skriver bokstäver blir det FormatException.

- Lösning: jag ändrade till int.TryParse, som returnerar false istället för att krascha, programmet skriver ett meddelande och går tillbaka till menyn. 

### Fel 3:
- Vad hände:

- Varför:

- Lösning:

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


