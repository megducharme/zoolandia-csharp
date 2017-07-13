namespace Zoolandia.Animals
{
  public class Tenodera : Genus
  {
    private string _continent;

    public string continent
    {
      get
      {
        return _continent;
      }
      set
      {
        if (value != "")
        {
          _continent = value;
        }
      }
    }

    private void init()
    {
      this.url = "https://en.wikipedia.org/wiki/Tenodera";
      this.trait = "apical spine";
      this.commonName = "Mantis";
      this.scientificName = "Tenodera";
    }

    public Tenodera()
    {
      this.init();
    }

    public Tenodera(string continent)
    {
      this.init();
      this.continent = continent;
    }
  }
}