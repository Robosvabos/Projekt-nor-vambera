DateTime cas = DateTime.Now;
int cisloMesice = cas.Month;
string[] poleMesicu = { "Leden", "Únor", "Březen", "Duben", "Květen", "Červen", "Červenec", "Srpen", "Září", "Říjen", "Listopad", "Prosinec" };
//Tady jsem zjistil co je za měsíc a dal ho do proměnné zároveň jsem si vytvořil string se všemi měsíci z kterého se pak budou vypisovat

int cisloTedMesice = cisloMesice - 1;
int cisloDalsihoMesice = cisloMesice;
int cisloPredeslehoMesice = cisloMesice - 2;
//Tohle je tu pro to aby když někdo napíše 3 aby mu to opravdu ukázalo Březen a ne Duben protože by se to počítalo od 0 do 11 ne od 1 do 12
if (cisloPredeslehoMesice < 0) 
    cisloPredeslehoMesice = 11;
if (cisloDalsihoMesice == 12 ) //Ohlídávám si aby když někdo napíše 12 aby mi to nehodilo error
    cisloDalsihoMesice = 0;

Console.WriteLine($"Nyní je {poleMesicu[cisloTedMesice]}, další měsíc bude {poleMesicu[cisloDalsihoMesice]}a předchozí měsíc byl {poleMesicu[cisloPredeslehoMesice]}");
Console.WriteLine($"-------------------------------------------------------------------------------------------");

Console.WriteLine($"Zadejte číslo od 1 do 12 (číslo měsíce)");
int zadanyMesic = Convert.ToInt32(Console.ReadLine());
int zadaneCisloMesicTed = zadanyMesic - 1;
int zadaneCisloDalsiMesic = zadanyMesic;
int zadaneCisloPredMesice = zadanyMesic - 2;
//*Tohle je tu pro to aby když někdo napíše 3 aby mu to opravdu ukázalo Březen a ne Duben protože by se to počítalo od 0 do 11 ne od 1 do 12
if (zadaneCisloPredMesice < 0)
    zadaneCisloPredMesice = 11;
if (zadaneCisloDalsiMesic == 12)
    zadaneCisloDalsiMesic = 0;//*Ohlídávám si aby když někdo napíše 12 aby mi to nehodilo error
Console.WriteLine($"Nyní je {poleMesicu[zadaneCisloMesicTed]}, další měsíc bude {poleMesicu[zadaneCisloDalsiMesic]}a předchozí měsíc byl {poleMesicu[zadaneCisloPredMesice]}");
Console.WriteLine($"-------------------------------------------------------------------------------------------");

Console.WriteLine($"Chceš vypsat všechny měsíce? Y/N");
string YesOrNo = Console.ReadLine();
if (YesOrNo == "Y" | YesOrNo == "y") // tady aby fungovalo jak Y tak y
{
    for (int forMesic = 0; forMesic < 12; forMesic++)
    {
        Console.WriteLine(poleMesicu[forMesic]);
    }
}//Abych nemusel vypisovat jednotlivě měsíce tak takhle to vypíše jeden a vždycky to k němu jen připisuje další

