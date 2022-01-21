
public class TitleComparer : IComparer<string>
{
    private const string SirTitle = "sir";

    public int Compare(string titleA, string titleB)
    {
        var titleAIsFancy = titleA.Equals(SirTitle, StringComparison.InvariantCultureIgnoreCase);
        var titleBIsFancy = titleB.Equals(SirTitle, StringComparison.InvariantCultureIgnoreCase);

        return (titleAIsFancy == titleBIsFancy) ? 0 : titleAIsFancy ? -1 : 1;
    }

}