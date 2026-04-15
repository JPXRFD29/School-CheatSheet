

# Promts:

**Activiteitendiagram genereren**

> [!WARNING]
> Geef de casus en de userstories mee!

```
Je bent een simpele en nauwkeurige AI die activiteitendiagrammen maakt in PlantUML.

Je krijgt een casus en user stories. Jouw taak is om daar EXACT één activiteitendiagram van te maken.

BELANGRIJK:

* Je maakt ALLEEN een activiteitendiagram
* Je geeft GEEN uitleg
* Je geeft GEEN tekst buiten de code
* Je output is ALLEEN een codeblok met PlantUML

====================
HOOFDREGEL
==========

JE MAG NIETS VERZINNEN DAT NIET IN DE CASUS OF USER STORIES STAAT.

====================
VERPLICHT: SWIMMING LANES
=========================

* Je MOET swimming lanes gebruiken (partitions in PlantUML)
* Elke lane stelt een rol of actor voor (bijv: Gebruiker, Systeem, Admin)
* Gebruik ALLEEN rollen die duidelijk in de casus of user stories staan
* Verzin GEEN extra rollen

Voorbeeld:
partition Gebruiker {
:Gebruiker logt in;
}

partition Systeem {
:Controleer gegevens;
}

====================
SYNTAX REGELS
=============

1. Begin met:
   @startuml

2. Eindig met:
   @enduml

3. Gebruik ALLEEN:

   * start
   * stop
   * :actie;
   * if / then / else
   * partition (voor swimming lanes)

4. Gebruik GEEN:

   * forks / parallel
   * notes
   * styling of kleuren
   * andere diagram types

====================
STRUCTUUR
=========

* start staat bovenaan (buiten of in eerste logische lane)
* acties staan ALTIJD binnen een partition
* elke actie hoort bij de JUISTE actor
* volgorde moet logisch zijn van boven naar beneden

====================
BESLISSINGEN
============

Gebruik altijd:

if (vraag?) then (ja)
:actie;
else (nee)
:actie;
endif

* Gebruik alleen beslissingen die echt nodig zijn
* Gebruik altijd "ja" en "nee"

====================
TAAL
====

* Nederlands
* Korte zinnen
* Simpele woorden

====================
LOGICA
======

* Gebruik alleen info uit de casus en user stories
* Raad niets
* Bij twijfel: kies de simpelste oplossing

====================
STAPPENPLAN
===========

Stap 1: Lees casus en user stories
Stap 2: Bepaal de rollen (swimming lanes)
Stap 3: Bepaal begin en eind
Stap 4: Zoek alle acties
Stap 5: Zet acties in de JUISTE lane
Stap 6: Voeg alleen noodzakelijke beslissingen toe
Stap 7: Controleer of alles klopt

====================
EXTRA CONTROLE (ZEER BELANGRIJK)
================================

Controleer voordat je antwoord geeft:

* Heeft elke actie de JUISTE actor (lane)?
* Zijn er GEEN verzonnen rollen?
* Zijn er GEEN acties buiten een partition?
* Is het proces logisch van begin tot eind?
* Is het zo simpel mogelijk?

Als je twijfelt: LAAT HET WEG.

====================
OUTPUT VOORBEELD
================

@startuml
start

partition Gebruiker {
:Opent app;
}

partition Systeem {
:Toon login scherm;
}

partition Gebruiker {
:Voert gegevens in;
}

partition Systeem {
if (Gegevens correct?) then (ja)
:Login succesvol;
else (nee)
:Toon foutmelding;
endif
}

stop
@enduml

====================
NU JOUW OPDRACHT
================

CASUS:
[PLAK HIER DE CASUS]

USER STORIES:
[PLAK HIER DE USER STORIES]
```


**Activiteitendiagram check:**

```
Je gaat nu een bestaand activiteitendiagram CONTROLEREN en VERBETEREN.

BELANGRIJK:

* Je geeft GEEN uitleg
* Je geeft GEEN tekst buiten de code
* Je output is ALLEEN een verbeterde PlantUML code
* Als iets fout is: FIX het
* Als iets goed is: laat het staan

====================
DOEL
====

Controleer of het activiteitendiagram:

* correct is volgens de casus en user stories
* swimming lanes (partitions) goed gebruikt
* geen onnodige of verzonnen dingen bevat

====================
WAT JE MOET CONTROLEREN
=======================

1. SWIMMING LANES (ZEER BELANGRIJK)

* Heeft elke actie een partition?
* Klopt de actor per actie?
* Zijn er GEEN verzonnen rollen?
* Zijn de namen logisch? (bijv: Gebruiker, Systeem, Admin)

FOUTEN DIE JE MOET FIXEN:

* Actie in verkeerde lane → verplaatsen
* Ontbrekende lane → toevoegen
* Verkeerde actor → corrigeren
* Onnodige lane → verwijderen

2. LOGICA

* Klopt de volgorde van stappen?
* Is het begin en eind correct?
* Zijn er geen losse stappen?

FOUTEN:

* Verkeerde volgorde → herstellen
* Missende stappen → toevoegen (ALLEEN als duidelijk uit casus)
* Onnodige stappen → verwijderen

3. BESLISSINGEN

* Zijn if/else correct gebruikt?
* Is er altijd "ja" en "nee"?
* Zijn beslissingen logisch?

FOUTEN:

* Slechte vraag → verbeteren
* Onnodige if → verwijderen
* Missende else → toevoegen

4. SIMPELHEID

* Is het diagram zo simpel mogelijk?
* Geen overbodige stappen?

FOUTEN:

* Te complex → versimpelen
* Dubbele stappen → verwijderen

5. REGELS

* Start met @startuml
* Eindigt met @enduml
* Alleen toegestane syntax:

  * start
  * stop
  * :actie;
  * if / else
  * partition

====================
HOOFDREGEL
==========

JE MAG NIETS TOEVOEGEN DAT NIET UIT DE CASUS OF USER STORIES KOMT.

Als je twijfelt:
→ NIET toevoegen
→ Liever weglaten

====================
OUTPUT
======

Geef ALLEEN de verbeterde PlantUML code.

====================
DIT IS HET DIAGRAM:
===================

[PLAK HIER DE PLANTUML CODE]

====================
CASUS:
======

[PLAK HIER DE CASUS]

====================
USER STORIES:
=============

[PLAK HIER DE USER STORIES]
```

<br><br><br><br><br>

**Activiteitendiagram Uitleggen:**
```
Je gaat nu jouw eigen activiteitendiagram uitleggen.

BELANGRIJK:

* Geef GEEN PlantUML code meer.
* Geef ALLEEN uitleg.
* Gebruik simpele taal.
* Schrijf alsof je het uitlegt aan een beginner.

====================
WAT JE MOET UITLEGGEN
=====================

1. ALGEMEEN OVERZICHT

* Leg kort uit wat het proces is
* Waar het begint en eindigt

2. STAPPEN (IN VOLGORDE)

* Leg elke stap uit die in het diagram staat
* Gebruik dezelfde namen als in het diagram
* Leg kort uit wat elke stap betekent

3. BESLISSINGEN

* Leg elke if/else uit
* Wat wordt er gecontroleerd?
* Waarom is die keuze nodig?
* Wat gebeurt er bij "ja" en bij "nee"?

4. WAAROM DIT DIAGRAM

* Leg uit waarom je deze stappen hebt gekozen
* Leg uit waarom je deze beslissingen hebt toegevoegd
* Verwijs naar de casus en user stories

5. SIMPEL HOUDEN

* Gebruik korte zinnen
* Geen moeilijke woorden
* Geen lange alinea’s

====================
EXTRA REGELS
============

* Gebruik lijstjes (met - of nummers)
* Maak het overzichtelijk
* Sla geen stappen over
* Verzint niets wat niet in de casus of user stories staat

====================
DOEL
====

De uitleg moet zo duidelijk zijn dat iemand zonder ervaring het diagram kan begrijpen.

====================
DIT IS HET DIAGRAM:
===================

[PLAK HIER DE PLANTUML OUTPUT]
```
<br><br><br><br><br>

**ERD maken:**

```
Je bent een simpele en nauwkeurige AI die een ERD (Entity Relationship Diagram) maakt in DBML voor [https://dbdiagram.io/](https://dbdiagram.io/)

Je krijgt een casus en user stories. Jouw taak is om daar EXACT één correcte en simpele database structuur van te maken.

BELANGRIJK:

* Je maakt ALLEEN een ERD in DBML.
* Je geeft GEEN uitleg.
* Je geeft GEEN tekst buiten de code.
* Je output is ALLEEN een codeblok met DBML code.

JE MAG NIETS VERZINNEN DAT NIET NODIG IS.

* Maak GEEN tabellen die niet duidelijk uit de casus of user stories komen
* Voeg GEEN extra features toe
* Voeg GEEN “handige” dingen toe die niet gevraagd worden
* Houd alles zo klein en simpel mogelijk

1. Maak alleen tabellen die echt nodig zijn

2. Elke tabel moet direct te herleiden zijn naar:

   * de casus OF
   * een user story

3. Gebruik simpele en duidelijke namen (Engels, standaard database stijl)
   Voorbeeld:
   users
   orders
   products

1) Gebruik MINIMALE kolommen

2) Voeg alleen kolommen toe die nodig zijn voor de werking

3) Als iets niet gespecificeerd is (bijv. login):

   * kies de SIMPELSTE oplossing

   Bijvoorbeeld:
   Als een user kan inloggen:
   → gebruik:

   * id
   * email
   * password

   NIET:

   * username
   * last_login
   * created_at
   * profile_image
     (tenzij dit expliciet nodig is)

4) Gebruik simpele datatypes:

   * int
   * varchar
   * boolean
   * date (alleen als nodig)

5) Elke tabel heeft:

   * een primary key: id

1. Voeg ALLEEN relaties toe als ze duidelijk nodig zijn
2. Gebruik foreign keys
3. Gebruik relaties die logisch zijn:

   * 1-op-veel waar logisch
   * many-to-many als dit duidelijk uit de casus of user stories komt (gebruik dan een koppeltabel)
4. GEEN complexe constructies tenzij expliciet nodig

====================
ENUMS (TOEGESTAAN MAAR BEPERKT)
===============================

* Je MAG enums gebruiken als dit logisch is (bijv. roles, status)
* Gebruik enums ALLEEN als het echt nodig is
* Voeg GEEN onnodige enum waarden toe

Voorbeeld:

Enum user_role {
admin
user
}

* Gebruik enums alleen als alternatief voor simpele vaste waardes
* Als je twijfelt: gebruik GEEN enum

Gebruik GEEN:

* audit velden (created_at, updated_at)
* logging tabellen
* role/permission systemen (tenzij expliciet genoemd)
* extra koppeltabellen zonder reden

Stap 1: Lees casus en user stories
Stap 2: Zoek de hoofdobjecten (dit worden tabellen)
Stap 3: Verwijder alles wat niet echt nodig is
Stap 4: Bepaal per tabel de minimale velden
Stap 5: Bepaal relaties
Stap 6: Controleer of alles echt uit de tekst komt
Stap 7: Maak DBML code

Gebruik dit formaat:

Table users {
id int [pk]
email varchar
password varchar
}

Table posts {
id int [pk]
user_id int
content varchar
}

Ref: posts.user_id > users.id

Voordat je antwoord geeft, controleer:

* Zit elke tabel in de casus/user stories?
* Zijn er GEEN onnodige kolommen?
* Is alles zo simpel mogelijk?

Als je twijfelt: LAAT HET WEG.

Gebruik ALLEEN de info hieronder.

CASUS:
[PLAK HIER DE CASUS]

USER STORIES:
[PLAK HIER DE USER STORIES]
```


**ERD uitleggen:**

```
Je gaat nu jouw eigen ERD (database diagram) uitleggen.

BELANGRIJK:

* Geef GEEN DBML code meer.
* Geef ALLEEN uitleg.
* Gebruik simpele taal.
* Schrijf alsof je het uitlegt aan een beginner.

====================
WAT JE MOET UITLEGGEN
=====================

1. ALGEMEEN OVERZICHT

* Leg kort uit wat voor systeem dit is
* Wat wordt opgeslagen in de database?

2. TABELLEN

* Noem elke tabel
* Leg per tabel uit:

  * wat het voorstelt
  * waarom deze tabel nodig is (koppel aan casus of user story)

3. KOLOMMEN

* Leg per tabel de kolommen uit
* Leg kort uit wat elke kolom betekent
* Leg uit waarom deze kolommen genoeg zijn (en waarom je geen extra hebt toegevoegd)

4. RELATIES

* Leg alle relaties uit
* Welke tabellen horen bij elkaar?
* Waarom is die relatie nodig?
* Is het 1-op-veel of many-to-many?

5. ENUMS (ALS DIE ER ZIJN)

* Leg uit wat de enum betekent
* Waarom je een enum hebt gebruikt
* Waarom deze waarden gekozen zijn

6. WAAROM DIT ONTWERP

* Leg uit waarom je het simpel hebt gehouden
* Leg uit waarom je GEEN extra tabellen of kolommen hebt toegevoegd
* Verwijs naar de casus en user stories

====================
EXTRA REGELS
============

* Gebruik lijstjes (met - of nummers)
* Gebruik korte zinnen
* Geen moeilijke woorden
* Geen lange alinea’s
* Sla niets over

====================
DOEL
====

De uitleg moet zo duidelijk zijn dat iemand zonder database kennis het kan begrijpen.

====================
DIT IS DE ERD:
==============

[PLAK HIER DE DBML OUTPUT]
```

<br><br><br><br>

**acceptatieTests**

```
Je bent een simpele en nauwkeurige AI die acceptatietests maakt op basis van een casus en user stories.

Je krijgt een casus en user stories. Jouw taak is om van elke user story een acceptatietest te maken in HTML, volgens de template hieronder.

BELANGRIJK:

* Gebruik ALLEEN informatie uit de casus en user stories.
* Verzin geen extra functies, stappen of data.
* Houd alles zo simpel mogelijk.
* Vul alle [ ... ] plekken in met de juiste tekst.
* Gebruik de template exact zoals hieronder.
* Voor elke user story maak je 1 acceptatieblok.
* Per user story maak je 4 testtabellen:

  1. happy-path
  2. edge-case 1
  3. edge-case 2
  4. extreme-case

====================
WAT IS HET VERSCHIL TUSSEN DE PATHS?
====================================

Happy-path:

* Dit is het normale pad.
* Alles gaat goed.
* De gebruiker doet wat de user story bedoelt.
* Geen fouten, geen rare situaties.

Edge-case:

* Dit is een grensgeval.
* Alles is nog wel logisch, maar het is niet de standaard situatie.
* Bijvoorbeeld: lege invoer, een kleine afwijking, een alternatief pad, of een onvolledige maar nog steeds realistische situatie.

Extreme-case:

* Dit is een zwaar of uitzonderlijk geval.
* Bijvoorbeeld: heel veel invoer, een fout die vaak misgaat, of een situatie die bijna niet voorkomt maar wel mogelijk is.
* Gebruik dit alleen als het nog steeds past bij de user story.

====================
REGELS VOOR HET MAKEN VAN DE TESTS
==================================

1. Voor elke user story maak je precies deze onderdelen:

   * Use Case / Unit
   * Pre-conditie
   * Beschrijving
   * Uitzondering
   * Post-conditie

2. Daarna maak je 4 testtabellen:

   * Test 1 = happy-path
   * Test 2 = edge-case 1
   * Test 3 = edge-case 2
   * Test 4 = extreme-case

3. Elke testtabel moet bevatten:

   * Stappen
   * Dataset
   * Verwachten uitkomst
   * Resultaat

4. Vul alle [ PLAATS HIER ... ] velden in.

5. Gebruik korte, duidelijke taal.

6. Gebruik alleen testen die echt logisch zijn bij de user story.

7. Voeg geen extra tabel toe als dat niet nodig is.

8. Zet de resultaten bij Resultaat op:

   * ✔ voor geslaagd
   * ✖ voor niet geslaagd
     Als het nog niet is uitgevoerd, laat het veld leeg of zet “nog te testen” als dat beter past.

9. De dataset moet passen bij de test.

   * Bij happy-path: normale, geldige data
   * Bij edge-case: een randgeval
   * Bij extreme-case: een zware of bijzondere situatie

10. De stappen moeten laten zien wat je precies doet in de test.

11. De verwachte uitkomst moet duidelijk zeggen wat er hoort te gebeuren.

12. De uitzonderingen moeten duidelijk laten zien wat er mis kan gaan.

====================
OPBOUW DIE JE MOET GEBRUIKEN
============================

Voor elke user story:

<table width="100%" border="1">
  <tr>
    <th style="width: 30%;"> <b>Use Case / Unit</b> <br><i>Naam van de use case</i></th>
    <td style="width: 70%;"> [ VUL IN ] </td>
  </tr>
  <tr>
    <th> <b>Pre-conditie</b> <br><i>Voorwaarden voor de use case<br>uitgevoerd kan worden</i></th>
    <td> [ VUL IN ] </td>
  </tr>
  <tr>
    <th> <b>Beschrijving</b> <br><i>De flow van de code (happy path)</i></th>
    <td> 1. [ VUL IN ] </td>
  </tr>
  <tr>
    <th> <b>Uitzondering</b> <br><i>Wat kan er misgaan?</i></th>
    <td> [ VUL IN ] </td>
  </tr>
  <tr>
    <th> <b>Post-conditie</b> <br><i>Wat is de verwachte uitkomst, wat<br>is er gebeurd?</i></th>
    <td> [ VUL IN ] </td>
  </tr>
</table>

<!-- Test Template -->

<table width="100%" border="1">
    <tr>
        <th style="width: 40%;">Test 1</th>
        <th style="width: 50%;">Dataset</th>
        <th style="width: 10%;">Resultaat</th>
    </tr>
    <tr>
        <td>
            <i>Stappen;</i>
            <br>
            [ VUL IN ]
        </td>
        <td rowspan="2" style="vertical-align: top;">
            <i>Beschrijf dataset voor happy path;</i>
            <br>
            [ VUL IN ]
        </td>
        <td rowspan="2" style="text-align: center;">&#10004 | &#10006</td>
    </tr>
    <tr>
        <td>
            <i>Verwachten uitkomst;</i>
            <br>
            [ VUL IN ]
        </td>
    </tr>
</table>

Gebruik daarna exact dezelfde opbouw nog 3 keer:

* Test 2 voor edge-case 1
* Test 3 voor edge-case 2
* Test 4 voor extreme-case

====================
HOE JE MOET DENKEN
==================

Stap 1: Lees de user story goed.
Stap 2: Bepaal wat de normale werking is.
Stap 3: Bedenk 2 edge-cases die nog steeds logisch zijn.
Stap 4: Bedenk 1 extreme-case die nog steeds past bij de user story.
Stap 5: Vul alles netjes in.
Stap 6: Controleer of je niets hebt toegevoegd dat niet in de casus of user stories staat.

====================
EXTRA REGELS
============

* Houd de teksten simpel.
* Gebruik geen moeilijke woorden.
* Gebruik geen lange verhalen.
* Schrijf precies genoeg om de test duidelijk te maken.
* Als iets niet duidelijk is in de user story, kies dan de simpelste logische test.
* Als een user story meerdere kleine stappen heeft, maak die stappen duidelijk in de beschrijving en bij de tests.

====================
OUTPUT
======

Geef alleen het uitgewerkte HTML-blok terug.
Geen uitleg ernaast.
Geen extra tekst.

====================
CASUS:
======

[PLAK HIER DE CASUS]

====================
USER STORIES:
=============

[PLAK HIER DE USER STORIES]
```

<br><br>

**Strenge acceptatieTests**

```
Je bent een simpele en nauwkeurige AI die acceptatietests maakt op basis van een casus en user stories.

Je krijgt een casus en user stories. Jouw taak is om van elke user story een acceptatietest te maken in HTML.

BELANGRIJK:

* Je gebruikt ALLEEN informatie uit de casus en user stories
* Je verzint GEEN nieuwe functionaliteit
* Je voegt GEEN extra features toe
* Je houdt alles zo simpel mogelijk
* Je output is ALLEEN HTML (geen uitleg)

====================
HOOFDREGELS (ZEER BELANGRIJK)
=============================

1. GEEN HERHALING:

* Je mag GEEN identieke testcases hergebruiken tussen user stories
* Elke user story moet UNIEKE tests hebben
* Als 2 user stories lijken op elkaar → maak toch andere testscenario’s

2. GEEN HALLUCINATIES:

* Alles moet terug te leiden zijn naar:

  * de casus OF
  * de user story
* Als iets niet duidelijk is → kies de simpelste optie
* Bij twijfel → NIET toevoegen

3. MINIMAAL MAAR COMPLEET:

* Niet te veel tekst
* Niet te weinig uitleg
* Precies genoeg om de test duidelijk te maken

====================
PATHS (VERPLICHT)
=================

Per user story maak je EXACT 4 tests:

1. Happy-path

* Normaal gebruik
* Alles werkt correct

2. Edge-case 1

* Kleine afwijking
* Nog realistisch

3. Edge-case 2

* Andere rand situatie dan edge-case 1
* Mag niet hetzelfde idee zijn

4. Extreme-case

* Zeldzame of zware situatie
* Maar nog steeds mogelijk binnen de user story

====================
VERBODEN FOUTEN
===============

Je mag NIET:

* Dezelfde dataset gebruiken in meerdere tests
* Dezelfde stappen herhalen met kleine aanpassing
* Algemene teksten gebruiken zoals:
  "voer geldige data in"
* Testcases maken die niets toevoegen

====================
VERPLICHTE VARIATIE
===================

Zorg dat:

* Elke test een ANDER scenario heeft
* Elke dataset anders is
* Elke uitkomst logisch past bij die specifieke test

====================
STRUCTUUR
=========

Voor ELKE user story:

1. Acceptatietabel (Use Case / Unit, Pre-conditie, etc.)
2. Test 1 (happy-path)
3. Test 2 (edge-case 1)
4. Test 3 (edge-case 2)
5. Test 4 (extreme-case)

Gebruik EXACT de HTML template.

====================
KWALITEITSCONTROLE (VERPLICHT)
==============================

Controleer voordat je antwoord geeft:

* Heeft elke user story 4 unieke tests?
* Zijn alle datasets verschillend?
* Zijn alle stappen logisch?
* Is alles gebaseerd op de casus?
* Zijn er GEEN herhalingen?
* Zijn er GEEN verzonnen features?

Als iets niet zeker is:
→ weglaten of simpeler maken

====================
TAAL
====

* Nederlands
* Simpele woorden
* Korte zinnen

====================
OUTPUT
======

* Alleen HTML
* Geen uitleg
* Geen extra tekst

====================
CASUS:
======

[PLAK HIER DE CASUS]

====================
USER STORIES:
=============

[PLAK HIER DE USER STORIES]

```



## Verbeterplan prompt:

```
Schrijf een compleet verbeterplan op basis van een acceptatietest en een unittest.

Gebruik eenvoudige, duidelijke Nederlandse zinnen. Maak de tekst netjes, logisch en professioneel. Houd je exact aan de opmaak hieronder.

Belangrijke regels:
- Interpreteer en vertaal wensen, reacties, testresultaten en/of meldingen naar realiseerbare verbetervoorstellen.
- Maak alleen verbeterpunten die haalbaar zijn binnen een normale school- of projectplanning.
- Gebruik concrete voorbeelden en benoem wat er aangepast moet worden.
- Als informatie ontbreekt, vul die dan logisch en realistisch aan.
- Zorg dat de grammatica en formulering eenvoudig en correct zijn.
- Schrijf alsof het een echt schoolverslag is.

## 1. Uitgevoerde Acceptatietest en Unittest

Beschrijf hier kort en duidelijk welke acceptatietests en unittests zijn uitgevoerd. Zet erbij wat er getest is, wat het resultaat was en welke problemen, fouten of opmerkingen daaruit kwamen.

## 2. Verbeterpunten uit Acceptatietest en Unittest

Maak een tabel met verbeterpunten die direct uit de testresultaten komen. Maak per punt duidelijk wat het probleem is, wat er moet worden verbeterd en wanneer dat haalbaar is.

| Verbeterpunt | Omschrijving | Planning (haalbaar) |
|--------------|--------------|---------------------|
| ... | ... | ... |
| ... | ... | ... |

## 3. Verbeterpunten die jullie zelf willen doorvoeren

Maak een tabel met extra verbeterpunten die jullie zelf bedenken. Denk aan verbeteringen voor gebruiksvriendelijkheid, techniek, prestaties of extra functies.

| Verbeterpunt | Omschrijving | Planning (haalbaar) |
|--------------|--------------|---------------------|
| ... | ... | ... |
| ... | ... | ... |
```





## Testrapport

```
Je bent een simpele en nauwkeurige AI die een testverslag maakt op basis van een casus en de uitgevoerde acceptatietesten.

Je krijgt een casus en de gemaakte testen. Jouw taak is om daar een compleet testverslag van te maken.

BELANGRIJK:

* Gebruik ALLEEN informatie uit de casus en de gemaakte testen
* Verzin geen extra testresultaten
* Verzin geen extra functionaliteit
* Houd alles zo simpel mogelijk
* Schrijf in duidelijke Nederlandse zinnen
* Geef alleen het uitgewerkte testverslag terug
* Geef geen uitleg ernaast
* Geef geen extra tekst

====================
DOEL
====================

Maak een testverslag met deze onderdelen:

1. Samenvatting - over de testen
2. Evaluatie
3. Conclusie

De sectie Uitgevoerde AcceptatieTests hoef je NIET zelf opnieuw te maken, want die is al gedaan.

====================
BELANGRIJKE REGELS
====================

1. De kandidaat voert de testactiviteiten correct en volgens het testplan uit.
2. Het testrapport bevat testresultaten van alle functionaliteiten.
3. Alle resultaten worden voorzien van de juiste conclusies.
4. Gebruik alleen de resultaten die echt in de gemaakte testen staan.
5. Als iets niet helemaal duidelijk is, kies de simpelste logische uitleg.
6. Gebruik korte en duidelijke zinnen.
7. Schrijf alsof het een echt schoolverslag is.
8. Maak de tekst netjes, logisch en professioneel.

====================
OPBOUW DIE JE MOET GEBRUIKEN
====================

## Samenvatting - over de testen

Geef hier een korte samenvatting van de uitgevoerde testen.
Leg uit:
- wat er getest is
- hoeveel testen er zijn uitgevoerd
- wat in het algemeen goed ging
- of er fouten of afwijkingen waren

## Evaluatie

Geef hier een evaluatie van de testen.
Leg uit:
- of de testen volgens plan zijn uitgevoerd
- of alle functionaliteiten getest zijn
- welke onderdelen goed werkten
- welke onderdelen niet goed werkten
- wat de belangrijkste bevindingen zijn

Gebruik hierbij de resultaten uit de gemaakte testen.

## Conclusie

Geef hier een duidelijke conclusie.
Leg uit:
- of het systeem voldoet aan de verwachtingen
- of de testen geslaagd zijn
- of er nog verbeterpunten zijn
- wat het eindresultaat is van de testfase

====================
EXTRA REGELS
====================

* Gebruik simpele woorden
* Gebruik geen moeilijke vaktaal
* Gebruik geen lange verhalen
* Houd het overzichtelijk
* Maak alleen wat echt nodig is
* Als alle testen goed zijn gegaan, zeg dat duidelijk
* Als er fouten zijn, noem die duidelijk en geef een logische conclusie

====================
OUTPUT
====================

Geef alleen het testverslag terug.
Geen uitleg.
Geen lijst met stappen van hoe je het hebt gemaakt.
Geen extra tekst.

====================
CASUS:
====================

[PLAK HIER DE CASUS]

====================
GEMAAKTE TESTEN:
====================

[PLAK HIER DE GEMAAKTE TESTEN]
```