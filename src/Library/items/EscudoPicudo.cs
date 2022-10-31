namespace RoleplayGame.Items
{
    /// <summary>
    /// Escudo picudo. Permite defenderse.
    /// </summary>
    /// <remarks>
    /// Responsable: Manuel Mongelós
    /// </remarks>
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