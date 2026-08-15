namespace Backend;

public class Date
{
    private int _year;
    private int _month;
    private int _day;

    public Date()
    {
        _year = 1900;
        _month = 1;
        _day = 1;
    }





    public Date(int year, int month, int day)
    {
        _year = year;
        _month = month;
        _day = day;
    }



    public int Year
    {
        get => _year;
        set => _year = value;
    }
    public int Month
    {
        get => _month;
        set => _month = value;
    }
    public int Day
    {
        get => _day;
        set => _day = value;
    }



    public override string ToString()
    {
        return $"{_year:D4}/{_month:D2}/{_day:D2}";
    }
}
