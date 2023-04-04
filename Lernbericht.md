# Lern-Bericht

Strawflower: Erismann, Müller, Greub, Lutziger, Bytyqi

## Einleitung

In diesem Projekt geht es darum, ein Spiel zu programmieren, bei dem Objekte auf den Spieler zukommen und dieser denen dann ausweichen muss.

## Was habe ich gelernt?

In diesem Projekt haben wir gelernt, wie wir die Hindernisse in unserem Spiel zufällig generieren können.

## Beschreibung

Bei der Erstellung des *Obsticles* werden *Parents* als durchsichtige Boxen verwendet, welche die *Children* enthalten. Hierfür verwenden wir ein leeres Game Object als *Parent* und drei Würfel als *Children*. 
Da unser Spiel drei Spuren besitzt, auf denen sich der Spieler bewegen kann, werden davon zwei von den Objekten eingenommen. Hierfür werden drei Schablonen erstellt und mit einem Zufalls-Generator und *System.Random* ausgewählt, wobei immer ein unsichtbarer Würfel erzeugt wird, indem seine Grösse auf 0 gesetzt wird.

```c#
GameObject obstical = new GameObject("Obstical");
            GameObject cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            GameObject cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            GameObject cube3 = GameObject.CreatePrimitive(PrimitiveType.Cube);

            RandN = randN.Next(0, 3);

            if (RandN == 0)
            {
                cube1.transform.localScale = new Vector3(0f, 0f, 0f);
                cube2.transform.localScale = new Vector3(4f, 4f, 4f);
                cube3.transform.localScale = new Vector3(4f, 4f, 4f);
            }
            else if (RandN == 1)
            {
                cube1.transform.localScale = new Vector3(4f, 4f, 4f);
                cube2.transform.localScale = new Vector3(0f, 0f, 0f);
                cube3.transform.localScale = new Vector3(4f, 4f, 4f);
            }
            else if (RandN == 2)
            {
                cube1.transform.localScale = new Vector3(4f, 4f, 4f);
                cube2.transform.localScale = new Vector3(4f, 4f, 4f);
                cube3.transform.localScale = new Vector3(0f, 0f, 0f);
            }
```
*Dieser Code beinhaltet die oben beschriebenen Schritte zur Generierung un zufälligen Auswahl der Objekte*


Danach müssen die Würfel noch in die *Parents* eingefügt werden und an der richtigen Position platziert werden.
Damit die Hindernisse auch gut im Spiel aussehen, haben sie anschliessend noch ein schicke Textur erhalten.
Bezüglich der Hindernisse gibt es noch weitere Änderungen, jedoch haben diese weniger mit der Generierung, sondern mit der Bewegung zu tun.

![Bild1](Files/Gif.gif)  
*Hier sieht man nun das Ergebnis in unserem Spiel. Die Objekte nehmen eine von drei Formen an, so dass der Spieler diesen dann ausweichen kann.*

## Verifikation

**Text:**  
* Der Text zeigt, dass wir erklären können, wie die gezeigte Methode aufgebaut ist und wir verstehen wie jene funktioniert.

**Bild:**  
* Das Bild zeigt, dass wir wissen, wie wir die gezeigte Methode in einem praktischen Beispiel anwenden können.

**Code:**  
* Der Code zeigt, dass wir verstanden haben, wie die beschriebene Methode funktioniert und wir dies auch in der Praxis anwenden können.

# Reflektion zum Arbeitsprozess

**Was gut an unserer Arbeit lief:**
* Da wir schon vor dem Projekt ein genaues Ziel vor Augen hatten, hatten wir viel Spass beim Programmieren und kamen auch, für die in unserer Zeit möglichen Ziele, gut voran.


**Was nicht gut an unserer Arbeit lief:**
* Da wir bei unserer Gruppenarbeit zu wenig Zeit für die uns gesetzten Ziele einplanten und die Gruppenarbeit mit einigen Personen schwieriger war als mit anderen konnten wir deshalb nicht alle unsere Ziele erreichen. Ausserdem konnten wir unseren Fortschritt und unseren aktuellen Stand im Projekt nicht richtig einschätzen, da wir unsere Dokumentation nicht vernünftig führten.

**VBV**: Für das nächste Mal sollten wir darauf achten unsere Projektdokumentation vernünftiger zu führen, da wir so einen genaueren Überblick über unser Projekt erhalten und wir dadurch auch besser Aufgaben zuweisen können, so dass wir so dann all unsere Ziele erreichen können.
