public class Time
{
    private int _minute;
    public int Hour 
    { 
        get
        {
              return _minute / 60;  
        } 
        set
        {
            _minute = value * 60;
        } 
    }


    public int GetMinutes()
    {
        return _minute;
    }
}