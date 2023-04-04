# Projekt-Dokumentation

Strawflowers: Erismann, Müller, Greub, Lutziger, Bytyqi

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|  28.2     | 0.0.1   | - Dokumentation mit User-Stories, Testfällen und Arbeitspaketen wurde fertig erstellt. |
|  7.3  | 0.0.2     |   - Spieler kann sich nach links und recht bewegen, Objekte kommen auf den Spieler zu, Spiel wird mit der Zeit schneller. |
|  14.3  | 0.0.3     |   - Deathscreen und Titlescreen erstellt, Timer erstellt, Spiel hat nun vernünftige Texturen |
|  21.3  | 0.0.4     |   - Deathscreen und Titlescreen funktionieren nun korrekt, Timer verbessert, Multiplayer Modus erstellt |
| 4.4    | 1.0.0     | 

## 1 Informieren

### 1.1 Ihr Projekt

Wir machen ein jump and run Spiel bei dem man einfach nur laufen kann und nicht springen. Wir machen unser Spiel über unity. Die verschiedenen Elemente (Hindernisse, Figur) sind nicht miteinander verbunden und reagieren autonom. Wir möchten in diesem Projekt unity ein bisschen besser kennen lernen, was Vektoren sind und wie man mit Vektoren arbeitet.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ----| --------------- | ---- | ---------------------------------- |
| 1  |        Muss       |   Funktional   | Als ein Spieler möchte ich am anfang mit einem Titlescreen begrüsst werden, damit ich nicht sofort ins spiel geworfen werde. |
| 2  |           Muss      |   Funktional   |   Als ein Spieler möchte ich zwischen verschiedenen Menüpunkten entscheiden können.     |
| 3 | Muss                 |    Funktional  |   Als ein Spieler möchte ich den Objekten ausweichen können, um Spass beim Spielen zu haben. |
| 4  |           Kann      |   Qualität     |   Als ein Spieler möchte ich während des Spielens lustige Musik hören.                                 |
| 5  |           Muss      |   Funktional   |   Als Spieler möchte ich einen failscreen bekommen, falls ich verliere, damit man sieht, dass man verloren hat.   |
| 6  |           Muss      |   Funktional   |   Als Spieler möchte ich mit einem Freund auf dem gleichen Laptop zusammen spielen, damit man nicht immer alleine Spielen muss.  |
| 7  |           Kann      |   Funktional   |   Als Spieler möchte ich in einem Shop gegenstände kaufen die mich beschützen oder die mein aussehen anpassen.     |
| 8  |           Muss      |   Funktional   |   Als Spieler möchte ich Münzen Sammeln um diese im shop auszugeben, damit meine Figur besser aussieht.        |
| 9  |           Kann      |   Funktional   |   Als Spieler möchte ich Powerups haben um mich kurzeitig zu retten, damit ich nicht so schnell verliere.      |
| 10  |           Muss      |   Funktional   |   Als Spieler möchte ich wissen wie mein laufscore ist, damit ich sehe ob ich besser werde. |     
| 11 |           Muss      |   Funktional   |   Als Spieler möchte ich wissen wie viele Münzen ich besitze, damit ich weiss wie viele ich ausgeben kann. |
 

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
|---|---|---|---|
| 1.1 | Applikation ist gestartet | - | Titlescreen |
| 2.1 | Titlescreen ist zu sehen | Singleplayer | Singleplayer modus wird gestartet |
| 2.2 | Titlescreen ist zu sehen | Multiplayer | Multiplayer modus wird gestartet |
| 2.3 | Titlescreen ist zu sehen | Shop | Shop wird geöffnet |
| 3.1 | Singeplayer/Multiplayer ausgewählt | Spieler drückt A | Figur bewegt sich nach links |
| 3.1 | Singeplayer/Multiplayer ausgewählt | Spieler drückt D | Figur bewegt sich nach rechts |
| 4.1 | Applikation ist gestartet | - | lustige Musik |
| 4.2 | Singleplayer / Multiplayer | - | Andere lustige Musik |
| 5.1 | Singleplayer | Falsches movement | Todesscreen wird angezeigt |
| 5.2 | Multiplayer | Falsches movement | Bei Spieler 1 oder 2 wird der Todesscreen angezeigt, einen Score und wer gewonnen hat |
| 6.1 | Multiplayer | P1 steuert mit W,A,S,D P2 mit UP,DOWN,LEFT,RIGHT | 2Spieler auf dem Spielfeld |
| 7.1 | Shop | Mit genügeng Geld auf Item1 gedrückt | Sie haben erfolgreich Item1 Gekauft. |
| 7.2 | Shop | Mit nicht genügengem Geld auf Item1 gedrückt | Sie sind zu arm. |
| 7.3 | Shop | Mit genügend Geld auf Amongus gedrückt | Sie haben erfolgreich den Amongus Skin Gekauft und ausgerüstet. |
| 7.4 | Shop | Mit nicht genügengem Geld auf Amongus gedrückt | Sie sind zu arm. |
| 8.1 | Singleplayer / Multiplayer | Bewegung um zu den Münzen zu gelangen | +1 Coin |
| 9.1 | Singleplayer / Multiplayer und ein rettungs Item gekauft | Bewegung in ein obstical | Du wurdest wiederbelebt |
| 10.1 | Singleplayer / Multiplayer | - | Oben links laufscore |
| 11.1 | Applikation ist gestartet | - | Oben rechts die anzahl Münzen |


### 1.4 Diagramme
![Run](https://user-images.githubusercontent.com/110893288/220324194-476d5fbe-c8ab-4b4f-abd5-931698f17e79.png)


![Blank diagram](https://user-images.githubusercontent.com/110885770/220322741-d9e832e7-4baf-46a4-87b5-53099bd42f67.png)

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung                                                               | geplante Zeit |
|------|-------|-----------|----------------------------------------------------------------------------|---------------|
| 1.A  | 14.3  | Bytyqi    | Titlescreen erstellen                                                      | 60 min        |
| 2.A  | 14.3  | Bytyqi    | Menu Button für Singleplayer                                               | 30 min        |
| 2.B  | 14.3  | Bytyqi    | Menu Button für Multiplayer                                                | 20 min        |
| 2.C  | 14.3  | Bytyqi    | Menu Button für Shop                                                       | 20 min        |
| 3.A  | 7.3   | Erismann  | Spielerbewegung                                                            | 45 min        |
| 3.B  | 7.3   | Erismann  | Objekte werden generiert                                                   | 45 min        |
| 3.C  | 7.3   | Erismann  | Objekte kommen auf den Spieler zu                                          | 60 min        |
| 3.D  | 7.3   | Müller    | Mit der Zeit werden die Objekte immer schneller                            | 45 min        |
| 3.E  | 7.3   | Müller    | Objekte werden wieder entfernt                                             | 30 min        |
| 4.A  | 21.3  | Bytyqi    | Musikausgabe im Titlescreen                                                | 30 min        |
| 4.B  | 21.3  | Müller    | Musik im Spiel abspielen                                                   | 30 min        |
| 5.A  | 14.3  | Greub     | Deathscreen erstellen                                                      | 30 min        |
| 5.B  | 14.3  | Greub     | Deathscreen erscheint beim Spielertod                                      | 45 min        |
| 6.A  | 21.3  | Greub     | Eine 2. Laufbahn erscheint                                                 | 60 min        |
| 6.B  | 21.3  | Greub     | Ein 2. Spieler erscheint                                                   | 60 min        |
| 6.C  | 21.3  | Greub    | Der 2. Spieler kann separat vom 1. gesteuert werden                        | 30 min        |
| 7.A  | 21.3  | Greub     | Shop Interface erstellen                                                   | 60 min        |
| 7.B  | 21.3  | Erismann  | Verschiedene Gegenstände in den Shop einfügen                              | 45 min        |
| 7.C  | 21.3  | Erismann  | Wenn ein Gegenstand gekauft wird, erhält der Spieler diesen                | 30 min        |
| 7.D  | 21.3  | Erismann  | Wenn ein Gegenstand gekauft wird, kann dieser nicht nochmal gekauft werden | 60 min        |
| 7.E  | 21.3  | Erismann  | Kosmetische Gegenstände werden auf den Spieler angewendet                  | 60 min        |
| 8.A  | 21.3  | Bytyqi    | Es erscheinen Münzen zufällig im Spielfeld                                 | 45 min        |
| 8.B  | 21.3  | Bytyqi    | Die Anzahl der eingesammelten Münzen wird gespeichert                      | 45 min        |
| 8.C  | 21.3  | Bytyqi    | Münzen können im Shop ausgegeben werden                                    | 45 min        |
| 9.A  | 21.3  | Erismann  | Die gekauften Gegenstände erhalten ihre Funktion                           | 60 min        |
| 10.A | 21.3  | Lutziger  | Mit der vergangenen Zeit zählt ein Score immer weiter nach oben            | 45 min        |
| 10.B | 21.3  | Lutziger  | Beim Tod soll der Score angezeigt werden                                   | 30 min        |
| 10.C | 21.3  | Lutziger  | Der Highscore soll gespeichert werden                                      | 45 min        |
| 11.A | 21.3  | Lutziger  | Die Anzahl der Münzen soll während dem Spiel angezeigt werden              | 30 min        |

Total: 20h 40min


## 3 Entscheiden

Bei unserem Projekt gab es keine wichtigen Entscheidungen, welche wir treffen mussten.

## 4 Realisieren

| AP-№ | Datum | Zuständig | Beschreibung                                                               | geplante Zeit | tatsächliche Zeit |
|------|-------|-----------|----------------------------------------------------------------------------|---------------|-------------------|
| 1.A  | 14.3  | Bytyqi    | Titlescreen erstellen                                                      | 60 min        | 60 min            |
| 2.A  | 14.3  | Bytyqi    | Menu Button für Singleplayer                                               | 30 min        | 10 min            |
| 2.B  | 14.3  | Bytyqi    | Menu Button für Multiplayer                                                | 20 min        | 10 min            |
| 2.C  | 14.3  | Bytyqi    | Menu Button für Shop                                                       | 20 min        | 10 min            |
| 3.A  | 7.3   | Erismann  | Spielerbewegung                                                            | 45 min        | 180 min           |
| 3.B  | 7.3   | Erismann  | Objekte werden generiert                                                   | 45 min        | 60 min            |
| 3.C  | 7.3   | Erismann  | Objekte kommen auf den Spieler zu                                          | 60 min        | 180 min           |
| 3.D  | 7.3   | Müller    | Mit der Zeit werden die Objekte immer schneller                            | 45 min        | 180 min           |
| 3.E  | 7.3   | Müller    | Objekte werden wieder entfernt                                             | 30 min        | 10 min            |
| 4.A  | 21.3  | Müller    | Musikausgabe im Titlescreen                                                | 30 min        | 60 min            |
| 4.B  | 21.3  | Müller    | Musik im Spiel abspielen                                                   | 30 min        | 60 min            |
| 5.A  | 14.3  | Greub     | Deathscreen erstellen                                                      | 30 min        | 180 min           |
| 5.B  | 14.3  | Greub     | Deathscreen erscheint beim Spielertod                                      | 45 min        | 60 min            |
| 6.A  | 14.3  | Greub     | Eine 2. Laufbahn erscheint                                                 | 60 min        | 45 min            |
| 6.B  | 14.3  | Greub     | Ein 2. Spieler erscheint                                                   | 60 min        | 45 min            |
| 6.C  | 14.3  | Greub     | Der 2. Spieler kann separat vom 1. gesteuert werden                        | 30 min        | 30 min            |
| 6.D  | 21.3  | Erismann  | Objekte kommen auf der 2. Laufbahn auf den Spieler zu                      | 60 min        | 40 min            |
| 7.A  | ❌     | ❌         | Shop Interface erstellen                                                   | 60 min        | ❌                 |
| 7.B  | ❌     | ❌         | Verschiedene Gegenstände in den Shop einfügen                              | 45 min        | ❌                 |
| 7.C  | ❌     | ❌         | Wenn ein Gegenstand gekauft wird, erhält der Spieler diesen                | 30 min        | ❌                 |
| 7.D  | ❌     | ❌         | Wenn ein Gegenstand gekauft wird, kann dieser nicht nochmal gekauft werden | 60 min        | ❌                 |
| 7.E  | ❌     | ❌         | Kosmetische Gegenstände werden auf den Spieler angewendet                  | 60 min        | ❌                 |
| 8.A  | ❌     | ❌         | Es erscheinen Münzen zufällig im Spielfeld                                 | 45 min        | ❌                 |
| 8.B  | ❌     | ❌         | Die Anzahl der eingesammelten Münzen wird gespeichert                      | 45 min        | ❌                 |
| 8.C  | ❌     | ❌         | Münzen können im Shop ausgegeben werden                                    | 45 min        | ❌                 |
| 9.A  | ❌     | ❌         | Die gekauften Gegenstände erhalten ihre Funktion                           | 60 min        | ❌                 |
| 10.A | 21.3  | Lutziger  | Mit der vergangenen Zeit zählt ein Score immer weiter nach oben            | 45 min        | 180 min           |
| 10.B | ❌     | ❌         | Beim Tod soll der Score angezeigt werden                                   | 30 min        | ❌                 |
| 10.C | ❌     | ❌         | Der Highscore soll gespeichert werden                                      | 45 min        | ❌                 |
| 11.A | ❌     | ❌         | Die Anzahl der Münzen soll während dem Spiel angezeigt werden              | 30 min        | ❌                 |


## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat                          | Tester   |
|------|-------|-----------------------------------|----------|
| 1.1  | 21.3  | Titlescreen wird angezeigt        | Erismann |
| 2.1  | 21.3  | Singleplayer modus wird gestartet | Erismann |
| 2.2  | 21.3  | Multiplayer modus wird gestartet  | Erismann |
| 3.1  | 21.3  | Figur bewegt sich nach links      | Erismann |
| 3.2  | 4.4   | Figur bewegt sich nach rechts     | Müller   |
| 4.1  | 4.4   | Musik wird abgespielt             | Müller   |
| 4.2  | 4.4   | gleiche Musik wird abgespielt     | Müller   |
| 5.1  | 4.4   | Todesscreen wird angezeigt        | Müller   |
| 5.2  | 4.4   | Todesscreen wird angezeigt        | Müller   |
| 6.1  | 4.4   | P1 mit A und D, P2 mit J und L    | Müller   |
| 7.1  | 4.4   | keine Reaktion                    | Müller   |
| 7.2  | 4.4   | funktioniert nicht                | Müller   |
| 7.3  | 4.4   | funktioniert nicht                | Müller   |
| 7.4  | 4.4   | funktioniert nicht                | Müller   |
| 8.1  | 4.4   | funktioniert nicht                | Müller   |
| 9.1  | 4.4   | funktioniert nicht                | Müller   |
| 10.1 | 4.4   | Score stoppt nicht                | Müller   |
| 11.1 | 4.4   | Spiel startet                     | Müller   |


### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |Applikation gestartet| | Home screen des Spieles| Start des Singleplayer spieles|
| II   | Home screen  |  Singleplayer|Start des Singplayer spieles | Start des Singplayer spieles|
| III  | Home screen  |  Multiplayer |Start des Multiplayer spieles | Start des Multiplayer spieles|
| IV   | Home screen  |  Shop | öffnen des Shops | Keine ausgabe |
| V    | Singleplayer/Multiplayer  |  W,d/J,L | Das bewegen des Spieler/s | Das bewegen des Spieler/s |
| VI   | Singleplayer/Multiplayer Death screen  |  Respawn | Starten eines neues  Spieles | Starten eines neues  Spieles |
| VII  | Singleplayer/Multiplayer Death screen  |  Main Menu | Main Menu screen | Main Menu screen |


## 6 Auswerten

Hier geht es zum [Lern-Bericht](Lernbericht.md)
