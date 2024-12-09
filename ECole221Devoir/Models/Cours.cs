namespace ECole221Devoir.Models
{
    public class Cours
    {
        public int Id { get; set; }
        public string Libellé { get; set; }
        public DateTime DateDébut { get; set; }
        public DateTime DateFin { get; set; }
        public string Semestre { get; set; }
        public int NombreHeures { get; set; }
        public virtual ICollection<Absence> Absences { get; set; }
    }
}
