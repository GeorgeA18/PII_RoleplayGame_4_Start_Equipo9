using System;

namespace RoleplayGame.Items;

/// <summary>
/// Coraza de Troll. Permite defenderse.
/// </summary>
/// <remarks>
/// Responsable: Jorge Avila
/// </remarks>
public class Coraza : IDefenseItem
{
    /// <summary>
    /// El poder de defensa.
    /// </summary>
    /// <value>Poder de defensa</value>
    public int DefensePower
    {
        get
        {
            return 40;
        }

    }
    public override string ToString()
        {
            return "Coraza de espinas";
        }

}