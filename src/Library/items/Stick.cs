namespace RoleplayGame.Items
{
    /// <summary>
    /// Palo. Permite atacar levemente. 
    /// </summary>
    public class Stick: IAttackItem
    {
        /// <summary>
        /// El poder de ataque.
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 10;
            }
        }

        public override string ToString()
        {
            return "Palo";
        }
    }
}