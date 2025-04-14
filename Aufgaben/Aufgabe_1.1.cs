namespace IT072406.Aufgaben
{
    public class Aufgabe_1_1
    {
        public static void run()
        {
            /*
              --------------------------------------------------------------------
              1. ASSEMBLY
              --------------------------------------------------------------------
              • Was: Grundbaustein einer .NET-Anwendung (.dll/.exe)
              • Enthält:
                - Kompilierten IL-Code
                - Metadaten
                - Ressourcen (Bilder, Konfigurationen)
              • Zweck: Portabilität, Sicherheit, CLR-Integration

              --------------------------------------------------------------------
              2. MANIFEST (ASSEMBLY MANIFEST)
              --------------------------------------------------------------------
              • Was: Metadaten-Beschreibung innerhalb jeder Assembly
              • Enthält:
                - Name/Version/Kultur
                - Externe Abhängigkeiten
                - Sicherheitsberechtigungen
                - Öffentliche Typen/Ressourcen
              • Zweck:
                - Vermeidung von Versionierungskonflikten
                - CLR-Ladeinformationen

              --------------------------------------------------------------------
              3. GLOBAL ASSEMBLY CACHE (GAC)
              --------------------------------------------------------------------
              • Was: Systemweiter Ordner für Shared Assemblies
              • Pfad: C:\Windows\Microsoft.NET\assembly\ (.NET 4.0+)
              • Funktionsweise:
                - CLR sucht zuerst im GAC
                - Erfordert Strong-Name (Signierte Assemblies)
              • Zweck: Zentrale Verwaltung gemeinsamer Bibliotheken

              --------------------------------------------------------------------
              ZUSAMMENHANG
              --------------------------------------------------------------------
              Assembly → Manifest definiert Abhängigkeiten → Bei Mehrfachnutzung: 
              Installation im GAC (mit Strong-Name)

              Beispiel:
              - MyLib.dll (Version 1.0.0.0) im GAC
              - Manifest referenziert Newtonsoft.Json 13.0.0.0
              - Alle Apps nutzen zentrales DLL ohne lokale Kopie
             */
        }
    }
}