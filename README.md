Smart Home Hub - Designmönster i praktiken
Detta projekt demonstrerar en arkitektur för ett smart hem-system. Fokus ligger på att skapa en modulär och utökningsbar lösning med hjälp av beprövade designmönster, där logik och ansvarsområden är tydligt separerade.

🛠 Hur man kör programmet
Öppna projektet: Starta Smarthome.sln i Visual Studio.

Bygg lösningen: Tryck på Ctrl + Shift + B för att kompilera alla filer.

Starta: Tryck på F5 för att köra konsolapplikationen.

Demo: Systemet kommer automatiskt att köra en morgonrutin, byta mellan olika lägen (Eco/Party) och demonstrera historikfunktionen (Replay) i konsolfönstret.

🏗 Implementerade Designmönster
Facade 
Mönstret finns i klassen SmartHomeFacade.cs. Den fungerar som ett centralt "API" som samlar komplexa operationer, som MorningRoutine(), på ett ställe. Detta gör att Program.cs förblir ren och lättläst då den inte behöver känna till detaljerna kring hur enskilda enheter eller kommandon fungerar internt.

Command & Replay
Detta mönster hittas i interfacet ICommand.cs och de konkreta klasserna i mappen Commands. Genom att kapsla in handlingar som objekt kan vi lagra dem i en historiklista i CommandInvoker.cs. Detta möjliggör systemets Replay-funktion, där de senaste utförda kommandona kan hämtas och köras igen direkt från minnet.

Strategy
Mönstret implementeras via IModeStrategy.cs och klasserna EcoMode, NormalMode och PartyMode. Det tillåter oss att byta ut systemets regler dynamiskt under körning. Genom att sätta ett nytt mode via Facaden ändras hur enheterna beter sig (t.ex. temperaturbegränsningar) utan att vi behöver ändra kod i själva enhetsklasserna.

Singleton
Används i klassen Logger.cs. Genom en privat konstruktor och en statisk instans (Logger.Instance) säkerställer vi att hela systemet skriver till samma loggpunkt. Detta förhindrar resurskonflikter och gör loggningen tillgänglig för alla komponenter utan att vi behöver skicka runt objektet som en parameter.

Observer
Loggern implementerar även interfacet IObserver.cs. Systemets enheter notifierar denna centrala punkt när deras status ändras (t.ex. när en lampa tänds). Detta skapar en löst kopplad arkitektur där loggning sker automatiskt som en reaktion på händelser i systemet.
