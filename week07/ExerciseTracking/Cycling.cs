public class Cycling : Activity
{
    private double _speed; // speed in kilometers per hour

    public Cycling(DateTime date, double duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        // Distance = Speed (kilometers per hour) * Time (hours)
        return _speed * _duration / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        // Pace = 60 / Speed (in km/h)
        return 60 / _speed;
    }
    public override string GetSummary()
    {
        return $"{_date:dd MMM yyyy} Cycling ({_duration} min): Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }
}