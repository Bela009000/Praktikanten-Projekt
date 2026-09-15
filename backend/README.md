# Lernkarten-Projekt

Das Backend ist eine ASP.NET-Core-Web-API in C# und liegt im Ordner `backend`.
Das Frontend ist ein minimales Angular-Projekt mit einer einfachen Startseite.

## Voraussetzungen

- .NET SDK 10 oder neuer
- Node.js und npm fuer das Frontend

Versionen prüfen:

```powershell
dotnet --version
node --version
npm --version
```

## Backend starten

Aus dem Projektverzeichnis:

```powershell
dotnet run --project .\backend\Lernkarten.Api.csproj --launch-profile http
```

Die API ist danach unter `http://localhost:5080` erreichbar.

Alternativ direkt aus dem Backend-Ordner:

```powershell
Set-Location .\backend
dotnet run --launch-profile http
```

## Backend bauen

```powershell
dotnet build .\backend\Lernkarten.Api.csproj
```

## Backend pruefen

```powershell
(Invoke-WebRequest -Uri "http://localhost:5080/api/health" -UseBasicParsing).Content
```

Erwartete Antwort:

```json
{ "status": "ok" }
```

## API-Endpunkte

- `GET /api/health`
- `GET /api/cards?setId={guid}`
- `GET /api/cards/{id}`
- `POST /api/cards`
- `PUT /api/cards/{id}`
- `DELETE /api/cards/{id}`

## Frontend starten

Aus dem Projektverzeichnis:

```powershell
Set-Location .\frontend
npm install
npm start
```

Die einfache Angular-Startseite ist danach unter `http://localhost:4200`
erreichbar. Weitere Funktionen sind noch nicht eingerichtet.
