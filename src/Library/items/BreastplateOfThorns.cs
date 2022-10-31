using System;

namespace RoleplayGame.Items;

/// <summary>
/// Item de defensa 
/// </summary>
/// </remark>Esta clase es responsablidad de Jorge Avila</remark>
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

}