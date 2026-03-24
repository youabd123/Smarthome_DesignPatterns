Smart Home Hub - Systemdokumentation
Detta projekt är en teknisk demonstration av ett smart hem-system, utvecklat med fokus på modularitet och separation av ansvar genom etablerade designmönster.

🛠 Hur man kör programmet
Öppna projektet: Starta Smarthome.sln i Visual Studio.

Bygg lösningen: Tryck på Ctrl + Shift + B för att kompilera koden och säkerställa att alla beroenden är på plats.

Exekvera: Tryck på F5 eller klicka på "Start" för att köra konsolapplikationen.

Resultat: Systemet kommer att demonstrera automatiserade rutiner, manuella kommandon och en återställning av händelseförloppet (Replay) direkt i konsolfönstret.

🏗 Implementerade Designmönster
Facade
Mönstret är implementerat i klassen SmartHomeFace.cs (eller SmartHomeFacade.cs). Den fungerar som ett förenklat gränssnitt som döljer systemets interna komplexitet för användaren. Genom metoder som MorningRoutine() kan flera enheter styras koordinerat utan att klientkoden behöver känna till detaljerna kring varje enskilt undersystem.

Command
Detta mönster hittas i interfacet ICommand.cs och de konkreta klasserna i mappen Commands (t.ex. TurnOnCommand.cs). Varje unik handling kapslas in som ett objekt, vilket gör det möjligt att skicka, köra och lagra instruktioner oberoende av vilken enhet som faktiskt utför dem. Detta skapar en mycket flexibel och utökbar struktur för framtida funktioner.

Command History (Replay)
Logiken för att hantera historik återfinns i CommandInvoker.cs. Genom att lagra utförda ICommand-objekt i en intern lista kan systemet återskapa tidigare händelser via metoden ReplayLast5(). Detta ger systemet en kraftfull förmåga att logiskt gå tillbaka eller upprepa sekvenser utan att behöva hårdkoda specifika tillstånd för varje enhet.

Observer
Mönstret implementeras genom IObserver.cs och används av systemets Logger.cs. Husets enheter agerar som subjekt som automatiskt notifierar observatören vid statusförändringar. Detta möjliggör passiv övervakning och loggning av händelser utan att enheterna själva behöver ha kännedom om hur loggningslogiken fungerar.

Singleton
Detta mönster används i Logger.cs. Genom att använda en privat konstruktor och en statisk instans säkerställs att det endast finns en central loggpunkt i hela applikationen. Detta förhindrar konflikter vid utskrifter och garanterar att all systeminformation samlas på ett och samma ställe under körning.

Strategy
Mönstret återfinns i IModeStrategy.cs samt de konkreta klasserna EcoMode.cs, NormalMode.cs och PartyMode.cs. Det tillåter systemet att växla mellan olika beteenden och regeluppsättningar dynamiskt. Genom att byta strategi ändras hemmet övergripande logik omedelbart utan att någon kod i de enskilda enheterna behöver modifieras.
