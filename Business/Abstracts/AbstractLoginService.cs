using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.Business.Abstracts;

/// <summary>
/// Classe abstraite pour représenter un service de login gardant en mémoire l'<see cref="User">utilisateur</see> connecté.
/// Utilisé à plusieurs places dans les <see cref="AbstractFacade">facades</see>.
/// </summary>
/// <remarks>
/// Hérite de <see cref="AbstractService"/>.
/// Cette classe a du être créée pour que vous puissiez créer votre propre service de login tout en maintenant la
/// relation contractuelle obligatoire dans les <see cref="AbstractFacade">facades</see> d'avoir un service de login passé/reçu.
/// </remarks>
public abstract class AbstractLoginService : AbstractService {

    protected User? LoggedInUser { get; set; }

    /// <summary>
    /// Retourne l'utilisateur authentifié (logged in).
    /// </summary>
    /// <remarks>
    /// J'ai créé cette méthode abstraite pour vous forcer à l'implémenter dans votre propre classe de login concrète
    /// vu que vous ALLEZ avoir besoin de l'utilisateur connecté (et de ses objets enfants, genre sa warehouse) à de 
    /// multiples occasions.
    /// </remarks>
    /// <returns>L'utilisateur authentifié</returns>
    public abstract User GetLoggedInUser();

}
