# LA1300-Penut


✍️ Peanut: Koch,Meyer,Gilardoni,Grigioni,Erismann

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|   22.11.2022    | 0.0.1   | Wir haben heute die User Stories, die Planung und die Testfälle gemacht. |
|   29.11.2022    | 0.0.2  |         Wir haben heute an den Anforderungen weitergearbeitet.                                                     |
|    06.12.2022   | 0.0.3   |           Koch und Grigioni haben die PowerPoint erstellt. Meyer, Gilardoni und Erismann haben weiter programmiert                                                   |
|13.12.2022|0.0.3| Wir haben an den letzte beiden User Sories gearbeitet.|

## 1 Informieren
https://www.besteonlinecasinos.co/blackjack/regeln/

### 1.1 Ihr Projekt

Wir machen ein Programm mit dem man Black Jack spielen kann.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1  |    Muss         | Funktional | Als Spieler möchte ich Eine Karte ziehen können. um einen höheren Kartenwert zu haben. |
| 2  |    Muss         | Funktional | Als Spieler möchte ich meine Karten behalten können, um meinen Kartenwert nicht über 21 zu bringen. |
| 3  |    Muss         | Funktional | Als Bank möchte ich ich zu beginn dem Spieler und mir jeweils 2 karten austeilen, um das spiel zu starten. |
| 4  |    Kann         | Funktional | Als Spieler möchte ich meine 2 Karten spliten können wenn sie die gleichen karten sind, um meine chance zum gewinn zu erhöhen. |
| 5  |    Muss         | Funktional | Als Spieler möchte ich meinen Einsatz verdoppeln können um meinen gewinn zu steigern wenn ich mich sicher fühle.|
| 6  |    Kann         | Funktional | Als Spieler möchte ich vor jeder Runde meine Einsatz erhöhen/senken können, damit ich mehr Geld Sparen kann |
| 7  |    Muss         | Funktional | Als Spieler möchte ich Mein Guthaben sehen können, um meine Einsätze besser abschätzen zu können |
| 8  |    Muss         | Funktional | Als Spieler möchte ich Meine Karten sehen, um das Spiel spielen zu können. |
| 9  |    Muss         | Funktional | Als Spieler möchte ich das Spiel jederzeit verlassen können, um aufzuhören.|
| 10 |    Kann         | Qualität   | Als Nutzer möchte ich ein übersichtliches Programm, um besser Spieler zu können. |
| 11 |    Kann         | Rand       | Als Programmierer möchte ich mit WinForms arbeiten, da dies vorgegeben ist.|
| 12 |    Muss         | Qualität   | Als Spieler möchte ich mir die Regeln anzeigen lassen können, um das Spiel zu vertsehen. |
| 13 |    Muss         | Funktional | Als Bank möchte ich bei gewinnen den doppelten einzatz auszahlen.|
| 14 |    Muss         | Funktional | Als Bank möchte ich bei BlackJack den Dreifachen einzatz auszahlen. |
| 15 |    Muss         | Funktional | Ein Ass soll Nur dann 11 Punkte Wert sein wenn dies nicht dazu führt dass der spieler über 21 kommt, ansonsten soll es 1 punkt wert sein|
| 16 |    Muss         | Funktional | Als Spieler möchte ich die Option haben meine Punktzahlanzeige ein- und auszuschalten. | 




### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |    start     |  Knopf "karte"      |      +1 zufällige Karte             |
| 2.1  |    start     |  Knopf "Hold"       |  spielwert wird berechnet                 |
| 3.1  |    start     |    nichts     |          +2 karten für spieler und bank         |
| 4.1  |    2 gleiche karten        |  knopf "split"      |    karten auf 2 stapel aufteilen |
| 5.1  |    start     | knopf "double"       |  einsatz verdoppelt  sich                 |
| 6.1  |    start     | einsatz + oder -        |  einsatz ändert sich                 |
| 7.1  |    start     |    keine     |    guthaben einzeigen                |
| 8.1  |    start, 2 karten       |  keine   |     Karten zeigt sich              |
| 9.1  |    programm läuft         |   knopf "leave"   |       spiel schliesst sich            |
| 10.1 |              |         |                   |
| 11.1 |    quellcode          |   keine      |     winforms              |
| 12.1 |   start      | knopf "regeln"       |   regeln werden angezeigt                |
| 13.1 |      spieler gewinnt        |    keine     |       guthaben + doppelter einsatz            |
| 14.1 |       spieler hat BlackJack       |   keine       |             guthaben + dreifacher Einsatz      |
| 15.1 |     Ass gezogen         |     keine    |   wert 11 doer 1 soll berechnet und gezeigt werdern                  |
| 16.1 |     Punktanzahl existiert         |   button press      |        anzeige ändert sich           |


### 1.4 Diagramme


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |  29.11.2022  |    Koch      |        Button erstellen bei, um eine Karte zu ziehen.      |     45          |
|  2.A |     29.11.2022    |     Meyer      |       Button erstellen, keine weitere Karte zu ziehen         |      45         |
| 3.A  |    29.11.2022   |       Erismann    |     Automatische austeilung von zwei zufälligen Karten, für die  Bank und den Spieler         |       45        |
|  4.A |   29.11.2022    |    Gilardoni       |     Gleiche Karten können gesplitet werden        |      45         |
|  4.B |    29.11.2022   |     Gilardoni          |       Mit einem Button können gleiche Karten gesplitet werden       |         45      |
| 5.A  |     29.11.2022    |      Grigioni     |     Mit einem Button sein Einsatz verdoppeln können.      |     45          |
| 6.A  |  29.11.2022    |    Koch          |     Mit einem Button sein Einsatz(am Anfang vom Spiel) erhöhen kann     |      45         |
| 6.B  |  29.11.2022     |      Koch     |     Mit einem Button sein Einsatz(am Anfang vom Spiel) veringern kann   |      45         |
| 7.A  |  29.11.2022  |  Meyer         |      Guthaben wird angezeigt        |          45     |
|  8.A |    29.11.2022 |   Erismann        |        Karten werden angezeigt      |        45       |
| 9.A  |   29.11.2022   |       Gilardoni    |   Mit einem Button das Spiel verlassen           |    45           |
| 10.A  | 29.11.2022     |      Grigioni     |  Übersichtliche Gestaltung            |        45       |
|  11.A |     29.11.2022   |   Meyer        |     WinForms arbeiten         |        45       |
| 12.A  |   06.12.2022     |     Koch      |         Mit einem Button die Regeln anzeigen lassen.     |    45           |
|  13.A |    06.12.2022  |      Meyer     |     Bank zahlt automatisch das doppelte vom Einsatz, wenn der Spieler gewinnt         |     45         |
| 14.A  |    06.12.2022   |   Erismann        |    Bank zahlt automatisch das dreichfache vom Einsatz, wenn der Spieler gewinnt und es so angeben wird          |      45         |
|  15.A |   06.12.2022   |     Gilardoni       |     Ass ist 11 wert.         |     45          |
|  15.b |   06.12.2022   |     Gilardoni       |     Das Ass ist 1 wert wenn sonst die Punkt zahl über 21 geht        |     45          |
| 16.A  |   06.12.2022    |   Grigioni        |    Punktzahl durch ein Button angezeigt werden      |        45       |
|  16.B |    06.12.2022    |    Erismann          |    Punktzahl kann wieder verschwinden wenn man auf einen Button klikt       |      45         |
|   |       |           |              |               |
|   |       |           |              |               |
|   |       |           |              |               | 4,12,13,14,15
|   |       |           |              |               |
|   |       |           |              |               |


Total: 900 min.

## 3 Entscheiden

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |    29.11.2022   |  Koch         |     45          |       30            |
| 2.A  |   29.11.2022    |   Meyer        |     45           |          30          |
| 3.A  |   29.11.2022    |   Erismann        |     45           |         30           |
| 5.A  |  29.11.2022     |    Grigioni       |     45           |           20         |
| 6.A  |  29.11.2022     |      Koch     |     45           |           30         |
| 6.B  |  29.11.2022     |       Koch  |     45           |            30        |
| 7.A  |  29.11.2022     |       Meyer   |     45           |            30        |
| 8.A  |  29.11.2022     |    Erismann       |      45          |            30        |
| 9.A  |  29.11.2022     |      Grigioni     |      45          |            30        |
| 10.A  | 29.11.2022      |      Erismann     |      45          |           30         |
| 11.A  |  29.11.2022     |     Meyer      |     45           |             30       |
| 16.A  |   29.11.2022    |      Grigioni     |     45           |             30       |
| 16.B  |  29.11.2022     |     Erismann      |     45           |             30       |
|13.A|06.12.2022|Meyer|45|120|
|14.A|06.12.2022|Erismann|45|120|
|15.A|06.12.2022| Gilardoni |45|60|
|15.B|06.12.2022| Gilardoni |45|60|
|12.A|13.12.2022|Koch|45|60|


## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  | 20.12.22 | stimmt         | Meyer       |
| 2.1  | 20.12.22 | stimmt         | Meyer       |
| 3.1  | 20.12.22 | stimmt         | Meyer       |
| 4.1  | 20.12.22 | stimmt nicht   | Meyer       |
| 5.1  | 20.12.22 | stimmt         | Meyer       |
| 6.1  | 20.12.22 | stimmt         | Meyer       |
| 7.1  | 20.12.22 | stimmt         | Meyer       |
| 8.1  | 20.12.22 | stimmt         | Meyer       |
| 9.1  | 20.12.22 | stimmt         | Meyer       |
| 10.1  | 20.12.22 | stimmt         | Meyer       |
| 11.1  | 20.12.22 | stimmt         | Meyer       |
| 12.1  | 20.12.22 | stimmt         | Meyer       |
| 13.1  | 20.12.22 | stimmt         | Meyer       |
| 14.1  | 20.12.22 | stimmt         | Meyer       |
| 15.1  | 20.12.22 | stimmt         | Meyer       |
| 16.1  | 20.12.22 | stimmt nicht   | Meyer       |

Programm Funktioniert bis auf 2 funktionen einwandfrei.
Split funktion funktioniert gar nicht.
Punkteanzeige wurde im verlauf des Projekts als funktion verworfen, da diese als überflüssig angesehen wurde.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
