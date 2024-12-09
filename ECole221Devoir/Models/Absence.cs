namespace ECole221Devoir.Models
{
    public class Absence
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int EtudiantId { get; set; }
        public int CoursId { get; set; }
        public virtual Etudiant Etudiant { get; set; }
        public virtual Cours Cours { get; set; }
    }
}
