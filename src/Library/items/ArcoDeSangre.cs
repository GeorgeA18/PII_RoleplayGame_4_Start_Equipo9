using System;
namespace RoleplayGame.Items
{
    /// <summary>
    /// Arco de sangre. Permite atacar.
    /// </summary>
    /// <remarks>
    /// Responsable: Franciso Alvarez
    /// </remarks>
    public class ArcoDeSangre : IAttackItem
    {
        public int AttackPower
        {
            get
            {
                return 25;
            }
        }
        public override string ToString()
        {
            return "Arco de Sangre";
        }
    }
}