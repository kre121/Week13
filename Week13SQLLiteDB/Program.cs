﻿using System.Data.SQLite;
SQLiteConnection connection = new SQLiteConnection("Data Source=mydb.db; Version = 3; New = True; Compress = True;");
try
{
    connection.Open();
    Console.WriteLine("DB found.");
}
catch
{
    Console.WriteLine("DB not found.");
}