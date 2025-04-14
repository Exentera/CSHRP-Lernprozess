namespace IT072406.Aufgaben
{
    public class Aufgabe_1_3
    {
        public static void run()
        {
            /*
                --------------------------------------------------------------------
                .NET-PROGRAMMERSTELLUNG (VON CODE ZUR AUSFÜHRUNG)
                --------------------------------------------------------------------
                1. CODE SCHREIBEN
                   • Sprache: C#/VB.NET/F# (z. B. in Rider/VS Code)
                   • Komponenten:
                     - Klassen
                     - Methoden
                     - Abhängigkeiten (NuGet-Pakete)

                     ↓
                2. KOMPILIERUNG (ROSILYN-COMPILER)
                   • Eingabe: .cs/.vb/.fs Dateien
                   • Ausgabe: IL-Code + Manifest → Assembly (.dll/.exe)
                     - IL = Intermediate Language
                     - Metadaten für CLR

                     ↓
                3. ASSEMBLY & MANIFEST
                   • Enthält (wie zuvor):
                     - Versionierung
                     - Externe Abhängigkeiten
                     - Sicherheitsinfos

                     ↓
                4. CLR (COMMON LANGUAGE RUNTIME)
                   • Schritte:
                     a) Assembly laden (mscorlib.dll etc.)
                     b) JIT-Kompilierung (IL → Native CPU-Instruktionen)
                     c) Speicherverwaltung (Garbage Collection)

                     ↓
                5. AUSFÜHRUNG
                   • Native Code läuft auf Betriebssystem
                   • Ausgabe: Console/Web/Desktop-App etc.

                --------------------------------------------------------------------
                ERWEITERTER WORKFLOW (ENTWICKLERPERSPEKTIVE)
                --------------------------------------------------------------------
                [Code schreiben] → [Build (Ctrl+Shift+B)] → [Testen/Debuggen] 
                     ↑                                      ↓
                  [Fehler beheben]                  [Deployment]
                                                        • Optionen:
                                                          - Publish (self-contained)
                                                          - Docker-Image
                                                          - Azure/AWS

                --------------------------------------------------------------------
                BEISPIEL: HELLO WORLD
                --------------------------------------------------------------------
                Program.cs → Kompilierung → HelloWorld.dll → CLR/JIT → "Hello World" in Konsole

                --------------------------------------------------------------------
                TOOLS IN RIDER
                --------------------------------------------------------------------
                • IL-Viewer: IL-Code inspizieren (Tools > IL Viewer)
                • Assembly Explorer: Abhängigkeiten visualisieren
                • Profiler: Leistungsanalyse während der Ausführung
                • Unit Test Runner: Tests parallel zur Entwicklung
             */
        }
    }
}