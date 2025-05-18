namespace Intermediate.Polymorphism.Coupled_Code;

internal class Canvas
{
    public void Draw(List<Shape> shapes)
    {
        // Hver gang vi ønsker å legge til en ny form, må vi legge til en ny case under
        // Altså må denne klassen (Canvas) endres hver gang vi lager en ny type for fieldet kalt Type
        // ShapeType enum må også endres hver gang vi lager et nytt type field for en ny form
        foreach (var shape in shapes)
        {
            switch (shape.Type)
            {
                case ShapeType.Circle:
                    Console.WriteLine("Draw a CIRCLE");
                    break;
                case ShapeType.Square:
                    Console.WriteLine("Draw a SQUARE");
                    break;
                case ShapeType.Triangle:
                    Console.WriteLine("Draw a Triangle");
                    break;
            }
        }
    }
}
