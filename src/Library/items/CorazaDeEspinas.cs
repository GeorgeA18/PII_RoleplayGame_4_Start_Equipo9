using System;

namespace RoleplayGame.Items;

/// <summary>
/// Coraza de espinas. Permite defenderse.
/// </summary>
/// <remarks>
/// Responsable: Jorge Avila
/// </remarks>
public class CorazaDeEspinas : IDefenseItem
{
    /// <summary>
    /// El poder de defensa.
    /// </summary>
    /// <value>Poder de defensa</value>
    public int DefensePower
    {
        get
        {
            return 80;
        }
    }
    public override string ToString()
        {
            return "Coraza de espinas";
        }

}