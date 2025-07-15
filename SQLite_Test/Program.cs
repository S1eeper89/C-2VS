using System;
using System.Data.SQLite;

class Program
{
    static void Main()
    {
        // Připojení k SQLite databázi (vytvoří nový soubor, pokud neexistuje)
        using var conn = new SQLiteConnection("Data Source=mojedb.db");
        conn.Open();

        // SQL příkaz: vytvoření tabulky
        var cmd = new SQLiteCommand(@"
            CREATE TABLE IF NOT EXISTS Zakaznici (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                jmeno TEXT,
                email TEXT
            )", conn);
        cmd.ExecuteNonQuery();

        Console.WriteLine("Databáze připravena.");
    }
}