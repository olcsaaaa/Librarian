using Librarian.Model;

namespace Librarian;

public class BookManager
{
    public IEnumerable<Opus> Search(string searchStr)
    {
        List<Opus> result = new List<Opus>();
        foreach (Opus opus in Program.Config.GetAll<Opus>())
        {
            if (opus.Title.Contains(searchStr))
            {
                result.Add(opus);
            }
        }

        return result;
    }

    public bool Add(Opus opus)
    {
        try
        {
            Program.Config.Add<Opus>(opus);
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    public bool Delete(Opus opus)
    {
        throw new NotImplementedException();
    }

    public bool Change(Opus opus)
    {
        throw new NotImplementedException();
    }
}