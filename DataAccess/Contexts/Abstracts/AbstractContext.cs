using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;

/// <summary>
/// Classe abstraite de généralisation des contextes.
/// </summary>
public abstract class AbstractContext : DbContext {

    /// <summary>
    /// Méthode générique permettant d'obtenir le <see cref="DbSet{TEntity}"/> d'une entité
    /// spécifique défini dans une classe de contexte concrète.<br/>
    /// Retourne le <see cref="DbSet{TEntity}"/> pour l'entité dont la classe est passée
    /// en paramètre dans <typeparamref name="DtoType"/>.
    /// </summary>
    /// <remarks>
    /// Cette méthode au code assez compliqué est nécessaire pour généraliser dans 
    /// <see cref="DAOs.Abstracts.AbstractDao{DtoType, DtoIdType}"/> les méthodes d'opérations
    /// de base des DAOs. Elle utilise ls fonctionnalité de Réflection pour analyser la classe 
    /// de contexte concrète qui hérite de <see cref="AbstractContext"/>, obtenir la liste 
    /// de ses <see cref="PropertyInfo">propriétés</see>, comparer le type des propriétés avec 
    /// celui passé à <typeparamref name="DtoType"/> et retourner la valeur de la propriété 
    /// dont les types correspondent.
    /// </remarks>
    /// <typeparam name="DtoType">La classe de l'entité dont on veut obtenir le DbSet.</typeparam>
    /// <returns>Le DbSet pour le type d'entité reçu.</returns>
    public virtual DbSet<DtoType>? GetDbSet<DtoType>() where DtoType : class, IDto {
        IEnumerable<PropertyInfo> contextProperties = this.GetType().GetProperties();
        List<PropertyInfo> matchingProps = new List<PropertyInfo>();
        foreach (PropertyInfo property in contextProperties) {
            if (property.PropertyType == typeof(DbSet<DtoType>)) {
                matchingProps.Add(property);
            }
        }
        return (DbSet<DtoType>?) matchingProps.Single().GetValue(this);
    }

}
