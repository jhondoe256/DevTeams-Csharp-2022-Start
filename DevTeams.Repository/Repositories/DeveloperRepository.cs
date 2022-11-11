
public class DeveloperRepository
{
    private readonly List<Developer> _devDb = new List<Developer>();
    private int _count;

    public bool AddDevToDb(Developer dev)
    {
        return (dev is null) ? false : AddToDatabase(dev);
    }

    //helper method -> Create
    private bool AddToDatabase(Developer dev)
    {
        AssignId(dev);
        _devDb.Add(dev);
        return true;
    }

    //helper method -> Create
    private void AssignId(Developer dev)
    {
        _count++;
        dev.Id = _count;
    }

    public List<Developer> GetDevelopers()
    {
        return _devDb;
    }

    public Developer GetDeveloper(int id)
    {
        //LINQ
        return _devDb.SingleOrDefault(dev => dev.Id == id);

        //todo: this is the longer way...but still works, your choice..
        // foreach (Developer dev in _devDb)
        // {
        //     if(dev.Id ==id)
        //     return dev;
        // }
        // return null;
    }

    public bool UpdateDeveloperData(int devId, Developer updatedData)
    {
        Developer devInDb = GetDeveloper(devId);

        if (devInDb != null)
        {
            devInDb.FirstName = updatedData.FirstName;
            devInDb.LastName = updatedData.LastName;
            devInDb.HasPluralsight = updatedData.HasPluralsight;
            return true;
        }
        return false;
    }

    public bool DeleteDeveloperData(int devId)
    {
        Developer devInDb = GetDeveloper(devId);
        return _devDb.Remove(devInDb);
    }

    //challenge -> Devs without pluralsight
    public List<Developer> DevsWithOutPluralsightLINQ()
    {
        return _devDb.Where(dev => dev.HasPluralsight == false).ToList();
    }

    public List<Developer> DevsWithOutPluralsight()
    {
        List<Developer> devsWithoutPs = new List<Developer>();
        foreach (Developer dev in _devDb)
        {
            if (dev.HasPluralsight == false)
            {
                devsWithoutPs.Add(dev);
            }
        }
        return devsWithoutPs;
    }

}
