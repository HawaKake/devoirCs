namespace ECole221Devoir.Models
{
   


        public class Etudiant
        {
            public int Id { get; set; }
            public string Matricule { get; set; }
            public string NomComplet { get; set; }
            public string Adresse { get; set; }
            public virtual ICollection<Absence> Absences { get; set; }
        }
    
}
