namespace RoleplayGame.Items
{
    /// <summary>
    /// Espada corta. Permite atacar levemente. 
    /// </summary>
    public class EspadaCorta: IAttackItem
    {
        /// <summary>
        /// El poder de ataque.
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 15;
            }
        }

        public override string ToString()
        {
            return "Espada corta";
        }
    }
}