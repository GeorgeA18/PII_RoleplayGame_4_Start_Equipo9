namespace RoleplayGame.Items
{
    /// <summary>
    /// Bastón mágico. Permite más ataque mágico.
    /// </summary>
    public class BastonMagico: IAttackItem, IDefenseItem
    {
        private Magic magic = new Magic();
        private Palo palo = new Palo();

        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return magic.AttackPower + palo.AttackPower;
            }
        }

        /// <summary>
        /// El poder de defensa
        /// </summary>
        /// <value></value>
        public int DefensePower
        {
            get
            {
                return magic.DefensePower;
            }
        }

        public override string ToString()
        {
            return "Baston mágico";
        }
    }
}