using System.Collections.Generic;

namespace Places.Models
{
  public class Place
  {
    private string _cityName;
    private int _stayLength;
    private string _journalEntry;
    public int Id { get; }
    private static List<Place> _instances = new List<Place> { };

    public Place(string cityName)
    {
      _cityName = cityName;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public string GetCityName()
    {
      return _cityName;
    }

    public int GetStayLength()
    {
      return _stayLength;
    }

    public string GetJournalEntry()
    {
      return _journalEntry;
    }

    public static List<Place> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}