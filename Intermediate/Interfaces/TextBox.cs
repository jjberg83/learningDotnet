namespace Intermediate.Interfaces;

// Poenget er at TextBox klassen arver masse kode som kan gjenbrukes fra UiControl
// Den arver ikke noe kode fra interfacene (metodene der er jo tomme, bare signaturen står der)
// Den arver fra base klasser, og implementerer interfacene
public class TextBox : UiControl, IDraggable, IDroppable
{
    public void Drag()
    {
        throw new NotImplementedException();
    }

    public void Drop()
    {
        throw new NotImplementedException();
    }
}
