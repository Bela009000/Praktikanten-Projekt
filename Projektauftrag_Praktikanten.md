# Projektauftrag – Lernkarten-Webapplikation

## Ausgangslage

Im Rahmen dieses Projekts soll eine einfache Webapplikation entwickelt werden, mit der Benutzer eigene Karteikarten erstellen und diese zum Lernen verwenden können. Die Anwendung orientiert sich grundlegend an bekannten Lernkarten-Apps wie Quizlet, soll jedoch bewusst einfach gehalten werden.

## Ziel

Das Ziel ist es, eine funktionierende Webapplikation zu entwickeln, in der sich Benutzer anmelden, eigene Lernkarten erstellen und ihr Wissen mit einem einfachen Quiz überprüfen können.

Dabei sollen die Grundlagen der Webentwicklung mit **Angular, TypeScript, HTML, CSS und C#** kennengelernt und praktisch angewendet werden.

## Technologien

Für das Projekt sollen folgende Technologien verwendet werden:

* Angular
* TypeScript
* HTML
* CSS
* C# mit ASP.NET Core für das Backend und die API
* Eine einfache Datenbank für die Speicherung der Daten

Das Angular-Frontend kommuniziert für die Speicherung und Abfrage der Lernkarten mit dem C#-Backend.

## Anforderungen

### 1. Benutzeranmeldung

Die Anwendung soll eine einfache Benutzerverwaltung besitzen.

Der Benutzer soll:

* sich registrieren können
* sich anmelden können
* sich abmelden können

Nach dem Login soll der Benutzer seine eigenen Karteikarten sehen können.

### 2. Themen / Lernsets

Karteikarten sollen in verschiedenen Themen organisiert werden können.

Beispiele:

* Mathematik
* Informatik
* Englisch
* Allgemeinwissen

Der Benutzer soll:

* ein neues Thema erstellen können
* seine vorhandenen Themen anzeigen können
* ein Thema auswählen können
* ein Thema löschen können

### 3. Karteikarten

Innerhalb eines Themas können mehrere Karteikarten erstellt werden.

Eine Karteikarte besteht mindestens aus:

* einer Frage
* einer Antwort

Beispiel:

**Frage:** Was bedeutet HTML?

**Antwort:** HyperText Markup Language

Der Benutzer soll Karteikarten:

* erstellen
* anzeigen
* bearbeiten
* löschen können

### 4. Lernmodus

Es soll einen einfachen Lernmodus geben.

Dabei wird zuerst die **Frage** einer Karteikarte angezeigt.

Über einen Button wie **„Antwort anzeigen“** kann anschließend die Antwort eingeblendet werden.

Danach kann zur nächsten Karteikarte gewechselt werden.

### 5. Quiz

Zusätzlich soll ein einfacher Quiz-Modus umgesetzt werden.

Der Benutzer wählt zuerst ein Thema aus. Anschließend werden Fragen aus den vorhandenen Karteikarten angezeigt.

Eine mögliche einfache Umsetzung:

1. Eine Frage wird angezeigt.
2. Der Benutzer gibt seine Antwort in ein Eingabefeld ein.
3. Die richtige Antwort wird angezeigt.
4. Der Benutzer gibt an, ob seine Antwort richtig oder falsch war.
5. Am Ende wird angezeigt, wie viele Fragen richtig beantwortet wurden.

Das Quiz muss nicht komplex sein. Ein einfaches und funktionierendes System reicht aus.

## Mögliche Seiten

Die Anwendung könnte beispielsweise aus folgenden Seiten bestehen:

* Login / Registrierung
* Startseite
* Übersicht der Themen
* Übersicht der Karteikarten
* Karteikarte erstellen / bearbeiten
* Lernmodus
* Quiz
* Ergebnis des Quiz

## Zeitplanung

### Woche 1 – Grundlagen und Aufbau

Ziele:

* Angular-Projekt erstellen
* Aufbau der Anwendung planen
* Navigation erstellen
* Login und Registrierung umsetzen
* Datenbank anbinden
* Themen erstellen und anzeigen

Am Ende der ersten Woche sollte sich ein Benutzer anmelden und seine Themen verwalten können.

### Woche 2 – Karteikarten und Lernen

Ziele:

* Karteikarten erstellen
* Karteikarten anzeigen
* Karteikarten bearbeiten
* Karteikarten löschen
* Lernmodus umsetzen
* einfache Gestaltung mit CSS

Am Ende der zweiten Woche sollten die wichtigsten Funktionen der Lernkarten funktionieren.

### Woche 3 – Quiz und Abschluss

Ziele:

* Quiz-Modus entwickeln
* Punkte bzw. richtige Antworten zählen
* Ergebnis anzeigen
* Fehler beheben
* Benutzeroberfläche verbessern
* Anwendung testen
* kurze Dokumentation erstellen

Am Ende der dritten Woche soll eine funktionierende Version der Anwendung präsentiert werden können.

## Optionale Erweiterungen

Falls die Grundfunktionen früher fertiggestellt werden, können zusätzliche Funktionen eingebaut werden:

* zufällige Reihenfolge der Karteikarten
* Fortschrittsanzeige beim Lernen
* verschiedene Quiz-Arten
* Suchfunktion für Themen oder Karteikarten
* Dark Mode
* Anzahl richtiger und falscher Antworten speichern
* einfache Statistiken
* Bewertung einer Karte mit „Kann ich“ / „Muss ich noch lernen“

Diese Funktionen sind **optional** und sollen erst umgesetzt werden, wenn die Grundfunktionen funktionieren.

## Projektabschluss

Am Ende der drei Wochen soll eine kurze Präsentation durchgeführt werden.

Dabei sollen die Praktikantinnen und Praktikanten:

* die Anwendung vorstellen
* die wichtigsten Funktionen zeigen
* kurz erklären, wie die Anwendung aufgebaut ist
* zeigen, was sie während des Projekts gelernt haben
* mögliche Verbesserungen nennen

## Erfolgskriterien

Das Projekt gilt als erfolgreich abgeschlossen, wenn:

* die Angular-Anwendung gestartet werden kann
* ein Benutzer sich anmelden kann
* Themen erstellt werden können
* Karteikarten erstellt, bearbeitet und gelöscht werden können
* Karteikarten in einem Lernmodus angezeigt werden können
* ein einfaches Quiz durchgeführt werden kann
* die Daten gespeichert werden
* die Anwendung grundsätzlich verständlich und bedienbar ist

**Wichtig:** Es wird keine perfekte oder vollständig professionelle Anwendung erwartet. Im Vordergrund stehen das Lernen, das Verständnis der verwendeten Technologien und eine funktionierende Umsetzung der wichtigsten Funktionen.
