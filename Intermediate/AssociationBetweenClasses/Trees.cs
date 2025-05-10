namespace Intermediate.AssociationBetweenClasses;

// Jeg vil demonstrerer 3 måter å bruke validation logic for fields
// Først ut er auto-implemented property der valideringen gjøres
// i en annen metode 
public class TreeOne
{
    public int Height { get; private set; }

    public void SetHeight(int height)
    {
        if(height > 0)
        {
            Height = height;
        }
        else
        {
            throw new ArgumentException("Høyde må være større enn 0");
        }
    }
}

// Her gjøres valideringen i constructoren i stedet
public class TreeTwo
{
    public int Height { get; private set; }

    public TreeTwo(int height)
    {
        if(height > 0)
        {
            Height = height;
        }
        else
        {
            throw new ArgumentException("Høyde må være større enn 0");
        }
    }
}

// Og her gjøres valideringen i setteren i stedet
// Men det krever en private backing field
// Og siden man gjør shit i setteren, kan man ikke bare skrive
// get; den må skrives som nedenfor, selv om den gjør akkurat
// det samme som get; i auto-implemented properties.
public class TreeThree
{
    private int _height;
    public int Height { 
        get
        {
            return _height;
        }
        set // kan ikke bruke private her, uten å måtte lage enda en ny metode for validering, så de to øverste er bedre hvis man ønsker encapsulation og validering av input samtidig
        {
            if (value > 0)
            {
                _height = value;
            }
            else 
            {
                throw new ArgumentException("Høyde må være større enn 0");
            }
        } 
    }
}