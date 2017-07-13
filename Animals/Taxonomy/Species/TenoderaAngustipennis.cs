namespace Zoolandia.Animals
{
  public class TenoderaAngustipennis : Species, IMantis
  {
    public TenoderaAngustipennis()
    {
      this.url = "https://en.wikipedia.org/wiki/Tenodera_angustipennis";
      this.genus = new Tenodera("Asia");
      this.scientificName = "Tenodera angustipennis";
      this.commonName = "Japanese Mantis";
    }

    public virtual string smell()
    {
      return "";
    }
  }
}