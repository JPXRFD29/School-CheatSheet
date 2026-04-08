

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