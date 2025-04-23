namespace Intermediate.AssociationBetweenClasses;
public class CompositionOverInheritance
{
    public static void Run()
    {
        // Tasta Knøttekor er både Gathering og Knøttekor
        Knøttekor tastaKnøttekor = new Knøttekor();
        // Vi har nå tilgang til både Gathering klassens og Kor klassens metoder
        // Men vi når dem indirekte ved å kalle på metoder i Knøttekor klassen
        // som igjen kaller på metodene i henholdsvis Gathering og Kor klassen.
        // Fieldsene til disse klassene er det verre å nå

        // Her bruker vi en Statement metoden fra Gathering via metode i Knøttekor
        tastaKnøttekor.Beskjed("Tasta knøttekor har startet");
        // Her bruker vi Sangleder metoden fra Kor via metode i Knøttekor
        tastaKnøttekor.Lederinfo();

        // Gladmat 2025 er både Gathering og FesitvalOver18
        Gladmat gladmat2025 = new Gladmat();
        gladmat2025.Beskjed("Gladmat2025 er i gang");
        gladmat2025.HilsPåBartender();
    
        Gladmat gladmat2023 = new Gladmat();
        gladmat2023.Beskjed("Gladmat2023 er i gang");
        gladmat2023.HilsPåBartender();

        // Gubbekorfestivalen 2025 har når metoder fra 3 klasser samtidig (Gathering, FesitvalOver18 og Kor)
        GubbeKorFestival gubbeKorFestival2025 = new GubbeKorFestival();
        gubbeKorFestival2025.Beskjed("La oss synge inn Gubbekorfestivalen 2025");
        gubbeKorFestival2025.HilsPåBartender();
        gubbeKorFestival2025.Lederinfo();

        // Frem til nå har FestivalOver18 klassen vært lik. Etter denne kommentaren endret jeg den
        // til å inkludere en ny metode som øker antall bonger brukt. Men trenger ikke endre klassene
        // som bruker denne klassens metoder. De har bare tilgang på dem under her automatisk.
        // Nei, det stemmer ikke. Slik jeg har gjort det til nå kaller jeg på metoder fra andre klasser
        // indirekte. Dermed må jeg jo inn i både Gladmat klassen og GubbekorFestival klassen og 
        // lage metoder som kaller på de nye drikkebong metodene jeg har laget.
        // Begynner å innse at det instruktøren lærte meg var bare konseptet, men at det antageligvis
        // finnes mange best practice måter for hvordan det faktisk implementeres som jeg sikkert lærer om
        // etterhvert. Bruker ikke mer tid på det foreløpig. 
    }
}