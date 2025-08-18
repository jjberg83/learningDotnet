namespace Shared;
// Hele Shared project ble laget for å teste ut en idé jeg hadde for ExtensionMethods 
// leksjonen i Advanced kurset.
// Lager en enkel Coder klasse som skal få en tilhørende CoderExtensions klasse.
// Disse vil jeg bruke fra to andre prosjekter. Før var Coder i ett prosjekt
// og Coder Extensions i en annen, og når de to prosjektene refererte til hverandre
// (slik at jeg kunne bruke de to klassene sammen), fikk jeg en circular dependency.
// Copilot sa det var bransjestandard å da lage et tredje delt prosjekt, som inneholdt
// alle klassene som trengtes i begge prosjektene, slik at man unngikk circular dependency.
public class CoderShared
{
    public string Strenghts { get; set; }

    public DateTime CertificationExpiry { get; set; }
}

