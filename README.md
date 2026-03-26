Smart Home Control Center

Hur man kör programmet
Öppna projektet i Visual Studio
Tryck på Run ▶️
Output visas i konsolen
Beskrivning

Detta projekt är ett enkelt Smart Home system där man kan styra en lampa.

Programmet visar hur olika delar i ett system kan samarbeta bakom kulisserna. Fokus ligger på struktur och designmönster, inte på grafik.

Syfte

Syftet är att visa att jag kan använda designmönster i praktiken, inte bara förstå dem teoretiskt.

Jag visar också att jag kan bygga ett system som är tydligt uppdelat och lätt att förstå och vidareutveckla.

Designmönster
Observer

Observer används i Lamp.cs tillsammans med Dashboard, Logger och AuditService.

När lampan tänds skickas ett meddelande till alla observers direkt. Detta gör att flera delar av systemet kan reagera samtidigt utan att Lamp behöver känna till dem.

Command

Command används i TurnOnCommand.cs, TurnOffCommand.cs och CommandInvoker.cs.

Istället för att köra kod direkt kapslas handlingar in i objekt. Invokern kör kommandon och sparar dem, vilket gör att vi kan köra dem igen med replay.

Facade

Facade finns i SmartHomeFacade.cs.

Den gör att Program.cs inte behöver prata med alla klasser direkt. Istället används enkla metoder som TurnOnLamp() och Replay(), vilket gör koden renare.

Singleton

Singleton används i Logger.cs.

Det säkerställer att det bara finns en logger i hela systemet. Alla delar använder samma instans, vilket gör loggningen konsekvent.

Struktur

Projektet är uppdelat efter ansvar:

Devices → Lamp
Observers → Dashboard, Logger, AuditService
Command → ICommand, Commands, CommandInvoker
Facade → SmartHomeFacade
Program.cs → startpunkt
Klassdiagram

Klassdiagram finns som PDF i projektet.

Det visar hur klasserna hänger ihop och vilka relationer de har.

Exempel output
[Dashboard] Lampan tändes
[LOG - 20:35:28]: Lampan tändes
[Audit] Lampan tändes

--- System Replay ---
[Dashboard] Lampan tändes
[LOG - 20:35:28]: Lampan tändes
[Audit] Lampan tändes
--- Replay slut ---
Reflektion

Designmönster gör koden mer strukturerad och flexibel. Det blir lättare att ändra och lägga till funktioner utan att påverka resten av systemet.

Samtidigt är det viktigt att inte överanvända dem i små projekt, eftersom det kan göra koden onödigt komplex. I detta projekt har jag försökt hålla en balans mellan enkelhet och struktur.
