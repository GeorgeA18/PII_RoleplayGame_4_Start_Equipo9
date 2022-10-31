namespace RoleplayGame.Items
{
    /// <summary>
    /// Interfaz que permite crear elementos de ataque.
    /// </summary>
    public class EscudoPicudo : IDefenseItem
    {
        /// <summary>
        /// El poder de defensa
        /// </summary>
        /// <value>20</value>
        public int DefensePower
        {
            get
            {
                return 20;
            }
        }

        public override string ToString()
        {
            return "Escudo picudo";
        }
    }
}