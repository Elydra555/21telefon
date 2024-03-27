using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary.Models
{
    public class Emberek
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Building { get; set; }
        public string ZipCode { get; set; }
        public string Position { get; set; }
        public string Transportation { get; set; }

        public Emberek()
        {
        }

        public Emberek(string sor)
        {
            string[] t = sor.Split(';');
            Name = t[0];
            Building = t[1];
            ZipCode = t[2];
            Position = t[3];
            Transportation = t[4];
        }

        public override string? ToString()
        {
            return $"{Name}, nevű ember a(z) {Building} épületben dolgozik, ami a, {Position} pozícióban, {ZipCode} irányítószám alatt áll, és ezzel az eszközzel jut el a munkába: {Transportation}.";
        }
    }
}
