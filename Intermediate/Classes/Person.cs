namespace Intermediate.Classes;

public class PersonPrivat
{
    private DateTime _birthdate;

    public void SetBirthdate(DateTime birthdate)
    {
        _birthdate = birthdate;
    }
    public DateTime GetBirthdate()
    {
        return _birthdate;
    }
}