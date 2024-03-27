namespace Telefonok
{
    public class Telefon
    {
        public string Gyarto;
        public string Modell;
        public string Kiadas;
        public int Akkap;

        public Telefon(string v)
        {
        }

        public Telefon(string gyarto, string modell, string kiadas, int akkap)
        {
            Gyarto = gyarto;
            Modell = modell;
            Kiadas = kiadas;
            Akkap = akkap;
        }

        public override string? ToString()
        {
            return $"{Modell} telefon vagyok, {Gyarto} a gyártóm, {Kiadas} adtak ki, és {Akkap} az akkumlátorom kapacitása.";
        }
    }
}