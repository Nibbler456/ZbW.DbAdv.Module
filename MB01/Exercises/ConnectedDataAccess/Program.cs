// Aufgabe 6: SqlBatch (Musterlösung, SQLite-Variante)
//
// Aufruf:  SqlBatch sqlcmd.txt result.txt
//   Zeile 1 der Eingabedatei: ConnectionString
//   danach: SQL-Anweisungen, jeweils mit ';' abgeschlossen (dürfen über mehrere Zeilen gehen)
//
// Alle Anweisungen laufen in EINER Transaktion. Schlägt eine fehl -> Rollback.

using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Diagnostics;

namespace SqlBatch
{

    internal class Program
    {
      static int Main(string[] args)
      {
        string[] fileLines = File.ReadAllLines("./sqlcmd.txt");
        /*foreach (var line in fileLines)
        {
            Console.WriteLine(line);
        }*/


        string[] result = [""];

        IDbConnection con = new SQLiteConnection(fileLines[0]);
        IDbTransaction trans = null!;

        try
        {
            con.Open();
            trans = con.BeginTransaction(IsolationLevel.ReadCommitted);

            IDbCommand cmd1 = new SQLiteCommand();
            cmd1.CommandText = fileLines[1];
            cmd1.Transaction = trans;
            cmd1.ExecuteNonQuery();
            
            IDbCommand cmd2 = new SQLiteCommand();
            cmd2.CommandText = fileLines[2];
            cmd2.Transaction = trans;
            cmd2.ExecuteNonQuery();
            
            IDbCommand cmd3 = new SQLiteCommand();
            cmd3.CommandText = fileLines[3];
            cmd3.Transaction = trans;
            cmd3.ExecuteNonQuery();
            
            IDbCommand cmd4 = new SQLiteCommand();
            cmd4.CommandText = fileLines[4];
            cmd4.Transaction = trans;
            cmd4.ExecuteNonQuery();

            trans.Commit();
        }
        catch (DbException ex)
        {
            if (trans != null)
                trans.Rollback();
            string[] errorResult = ["Oh, da ist etwas schief gelaufen", ex.ToString()];
            File.WriteAllLines("./result.txt", errorResult);
        }
        finally
        {
            con.Close();
            File.WriteAllLines("./result.txt", result);
        }
        
        return 0;
      }
    }
}
