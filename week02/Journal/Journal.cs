public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile()
{
    using (StreamWriter writer = new StreamWriter("journal.txt"))
    {
        foreach (Entry entry in _entries)
        {
            writer.WriteLine(entry.FormatEntry());
        }
    }
}

    public void LoadFromFile()
    {
        _entries.Clear();
        if (File.Exists("journal.txt"))
        {
            string[] lines = File.ReadAllLines("journal.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry entry = new Entry(parts[0], parts[1], parts[2]);
                    _entries.Add(entry);
                }
            }
        }
        else
        {
            Console.WriteLine("No journal.txt file found.");
        }
    }

}
