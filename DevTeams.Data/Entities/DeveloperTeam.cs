
public class DeveloperTeam
{
    public DeveloperTeam()
    {
    }
    public DeveloperTeam(string teamName, List<Developer> developers)
    {
        TeamName = teamName;
        Developers = developers;
    }
    public int Id { get; set; }
    public string TeamName { get; set; }
    public List<Developer> Developers { get; set; } = new List<Developer>();
}
