namespace phone
{
  public abstract class Phone
  {
    protected string _versionNumber { get; set; }
    protected int _batteryPercentage {get; set;}
    protected string _carrier { get; set; }
    protected string _ringTone { get; set; }
    protected Phone(string versionNumber, int batteryPercentage, string carrier, string ringTone)
    {
      _versionNumber = versionNumber;
      _batteryPercentage = batteryPercentage;
      _carrier = carrier;
      _ringTone = ringTone;
    }
    
    public abstract void DisplayInfo();

  }
  public interface IRingable
  {
    string Ring();
    string Unlock();

  }

  public class Nokia : Phone, IRingable
  {
   public Nokia(string _versionNumber, int _batteryPercentage, string _carrier, string _ringTone) : base(_versionNumber, _batteryPercentage, _carrier, _ringTone){}

   public string Ring()
   {
     string ring = "Dingalingaling";
     return ring;
   }

   public string Unlock()
   {
     string unlock = "I need a 4 diget code to unlock";
     return unlock;
   }
   public override void DisplayInfo()
   {
     System.Console.WriteLine("The version number is {0}, the battery percentage is {1}, the carrier is {2}, the ringtone is {3}", _versionNumber, _batteryPercentage.ToString(), _carrier, _ringTone);
   }
  }

  public class Galaxy : Phone, IRingable
  {
    public Galaxy(string _versionNumber, int _batteryPercentage, string _carrier, string _ringTone) : base(_versionNumber, _batteryPercentage, _carrier, _ringTone) {}

    public string Ring() 
    {
      string ring = "Beedaloo Beedaloo Beedaloo";
      return ring;
    }
    public string Unlock()
    {
      string unlock = "I have many methods to unlock, fingerprint, pattern, and pin";
      return unlock;
    }
    public override void DisplayInfo()
    {
      System.Console.WriteLine("The version number is {0}, the battery percentage is {1}, the carrier is {2}, the ringtone is {3}", _versionNumber, _batteryPercentage, _carrier, _ringTone);
    }
  }
}
