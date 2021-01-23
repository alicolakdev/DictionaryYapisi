using System;

namespace DictionaryYapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> teams = new MyDictionary<string, string>();

            teams.Add("1", "Galatasaray");
            teams.Add("2", "Fenerbahçe");

            teams.Read();
        }
    }
}
