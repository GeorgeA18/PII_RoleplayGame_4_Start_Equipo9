namespace RoleplayGame.Items
{
    /// <summary>
    /// Gemas poderosas. 
    /// </summary>
    /// <remarks>
    /// Responsable: Milagros Varela
    /// </remarks>
    public class Gema
    {
        public int AttackPower{get; set;}
        public int DefensePower{get;}
        public Gema(int valorAtaque, int valorDefensa)
        {
            this.AttackPower = valorAtaque;
            this.DefensePower = valorDefensa;
        }
    }
}