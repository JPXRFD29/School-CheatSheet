Algemeen

Het komt voor dat je niets kunt doen voor een normaalvorm. Geef dat duidelijk aan in je toets.
Zolang het zinvol is, mag je zelf een primaire sleutel verzinnen voor een tabel, dit kan het proces makkelijker maken.
0e normaal vorm

Officiële uitleg: verzamel alle gegevens en leg deze vast
We leggen geen statische gegevens vast
Er worden geen procesgegevens opgeslagen
Makkelijke uitleg: schrijf alle gegevens onder elkaar. De dingen die vast op het formulier staan (statische gegevens) sla je over. Ook de dingen die je kunt berekening (totalen, gemiddeldes, hoeveelheid btw, enzovoort) leg je niet vast.
1e normaal vorm

Officiële uitleg: elimineer herhalende groepen in afzonderlijke tabellen.
Een tabel heeft altijd een primaire sleutel.
Identificeer de nieuwe tabel met een primaire sleutel.
Neem vervolgens de primaire sleutel over van de andere tabel waaruit de gegevens komen.
Makkelijke uitleg: maak twee of meer ‘rijtjes’, de eerste voor alle niet-herhalende gegevens en daarn voor iedere repeating groep één rijtje. Zo'n rijtje noemen we alvast een ‘tabel’.
Bekijk per rijtje of er een gegeven als sleutel kan worden ingezet, onderstreep die. Vaak is dit: lidnummer, bestelnummer, klantnummer, ordernummer, enzovoort.
Zorg ervoor dat de repeating groups een samengestelde sleutel hebben (dus twee dingen onderstreept). Hiertoe plak je ook de sleutel van de bovenste tabel erbij, naast de sleutel die je al had bedacht voor het rijtje.
2e normaal vorm

Officiële uitleg: bekijk de herhalende groepen; controleer of alle aanwezige attributen afhankelijk zijn van de volledige samengestelde sleutel. Plaats de attributen vervolgens in een nieuwe tabel, met als primary key de deelsleutel.
Makkelijke uitleg: focus alleen op de tabellen met een samengestelde sleutel. Controleer van alle gegevens (behalve de sleutels zelf) of deze bij de complete samengestelde sleutel horen, of misschien alleen bij één van de twee sleutels. Als een gegeven maar bij één sleutel hoort, verplaats je deze naar een nieuw rijtje. De sleutel kopieër je ook mee, zodat er een link blijft met het originele rijtje.
3e normaal vorm

Officiële uitleg: elimineer de attributen die niet afhankelijk zijn van de sleutel, door deze in een nieuwe tabel te plaatsen met het afhankelijke veld als primairy key.
Makkelijke uitleg: focus alleen op de tabellen die géén samengestelde sleutel hebben. Bekijk of alle gegevens bij de sleutel van deze tabel horen. Bijvoorbeeld: als de sleutel “klantnummer” is, dan hoort “klantnaam” daar zeker bij. Maar iets als “accountmanager” hoort er misschien niet bij, en verdient een eigen tabel.
Verplaats de gegevens die niet bij de sleutel horen naar een eigen rijtje. Geef dit rijtje ook een eigen sleutel, en zorg dat er een link blijft met de originele tabel.