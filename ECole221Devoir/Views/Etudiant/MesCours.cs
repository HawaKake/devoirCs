using ECole221Devoir.Models;
using System.Reflection;
using System.Threading;

namespace ECole221Devoir.Views.Etudiant
@model IEnumerable<GestionEcole.Models.Cours>

<h1>Mes Cours</h1>
<table>
    <thead>
        <tr>
            <th>Module</th>
            <th>Date</th>
            <th>Heure Début</th>
            <th>Heure Fin</th>
        </tr>
    </thead>
    <tbody>
        @foreach (var cours in Model)
{
            < tr >
                < td > @cours.Module </ td >
                < td > @cours.Date.ToShortDateString() </ td >
                < td > @cours.HeureDebut </ td >
                < td > @cours.HeureFin </ td >
            </ tr >
        }
    </tbody>
</table>

