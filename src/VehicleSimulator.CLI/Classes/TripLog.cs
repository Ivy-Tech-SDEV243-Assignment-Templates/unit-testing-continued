using System.Text;

public class TripLog
{
    public List<Position> Entries { get; private set; }
    public int OutputPrecision { get; private set; }
    public double TotalDistance
    {
        // This property works just like any other property; it just does a
        // calculation prior to returning the value.
        get
        {
            // If there are not at least two points logged then the vehicle has not moved
            if (Entries.Count < 2)
                return 0;

            double total = 0;
            for (int i = 1; i < Entries.Count; i++)
            {
                // Get the component distance between this point and the previous point
                double distanceX = Entries[i].X - Entries[i - 1].X;
                double distanceY = Entries[i].Y - Entries[i - 1].Y;

                // Add the distance to the total
                total += Math.Sqrt(distanceX * distanceX + distanceY * distanceY);
            }
            return total;
        }
    }

    public TripLog(int outputPrecision)
    {
        if (outputPrecision <= 0)
            throw new ArgumentException("Output precision must be greater than 0.");

        OutputPrecision = outputPrecision;
        Entries = new List<Position>();
    }

    public string GetPrintedEntries()
    {
        // Convenience method to print the entries in a readable format
        StringBuilder sb = new StringBuilder();
        foreach (Position entry in Entries)
        {
            string x = entry.X.ToString($"F{OutputPrecision}");
            string y = entry.Y.ToString($"F{OutputPrecision}");
            sb.AppendLine($"Position: {x}, {y}");
        }
        return sb.ToString();
    }

    public void Record(Position point)
    {
        Entries.Add(point);
    }
}