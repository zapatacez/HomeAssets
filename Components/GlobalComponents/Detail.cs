namespace HomeAssets.Components.GlobalComponents;

// Detail.cs

public class Detail
{
    public string Name { get; set; }
    public string Slot { get; set; }
    public string Text { get; set; }
    
    public string Type { get; set; } // You may want to use an enum for better type safety
    public bool Copyable { get; set; }
}

// DateDetail.cs

public class DateDetail : Detail
{
    public bool Date { get; set; }
}

// CurrencyDetail.cs

public class CurrencyDetail : Detail
{
}

// LinkDetail.cs

public class LinkDetail : Detail
{
    public string Href { get; set; }
}


public class BoolDetail : Detail
{
    public bool Bool { get; set; }
}
// MarkdownDetail.cs

public class MarkdownDetail : Detail
{
}

// DetailsFilter.cs

public static class DetailsFilter
{
    public static List<Detail> FilterZeroValues(List<Detail> details)
    {
        return details.Where(detail =>
        {
            switch (detail.Type)
            {
                case "date":
                    return ValidDate(detail.Text);
                case "currency":
                    return !string.IsNullOrEmpty(detail.Text);
 
                case "link":
                    return !string.IsNullOrEmpty(detail.Text) && !string.IsNullOrEmpty((detail as LinkDetail)?.Href);
                case "text":
                case "markdown":
                    return !string.IsNullOrEmpty(detail.Text);
                default:
                    Console.WriteLine("Unknown detail type (this should never happen)");
                    return false;
            }
        }).ToList();
    }

    private static bool ValidDate(string dateText)
    {
        // Add logic to validate date
        // You might want to use DateTime.TryParseExact or a similar method
        return !string.IsNullOrEmpty(dateText);
    }
}
