using System.Security.Cryptography.X509Certificates;

namespace Intermediate.Interfaces;
public class InterfacesAreNotForMultipleInheritance
{
    public static void Run()
    {
        // I noen språk kan man la en klasse arve fra flere base klasser (multiple inheritance). 
        // Det går ikke i C#. Derimot kan en klasse arve fra en klasse, og
        // i tillegg implementere flere interfaces. Men det er viktig å forstå at man ikke
        // arver interfacene, man får ingen kode fra dem - de er jo tomme. De er bare kontrakter
        // klassene må oppfylle. Man implementerer interfaces, man arver ikke noe fra dem.

        // Ikke mulig:
        // public class DerivedClass_1 : BaseClass_1, BaseClass_2
        // {}

        // Men dette er mulig 
        // public class DerivedClass_1 : BaseClass_1, IInterface_1, IInterface_2
        // {}

        // Se klassen TextBox for faktisk kodeeksempel


    }
}