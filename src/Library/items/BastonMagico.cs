namespace RoleplayGame.Items
{
    /// <summary>
    /// Bastón mágico. Permite más ataque mágico.
    /// </summary>
    public class BastonMagico: IAttackItem, IDefenseItem
    {
        private Magic magic = new Magic();
        private Stick stick = new Stick();

        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return magic.AttackPower + stick.AttackPower;
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