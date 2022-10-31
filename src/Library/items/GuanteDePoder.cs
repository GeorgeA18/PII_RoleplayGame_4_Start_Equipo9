namespace RoleplayGame.Items
{
    /// <summary>
    /// Guante de poder. Permite aumentar su poder mediante la adquisición de gemas.
    /// </summary>
    /// <remarks>
    /// Responsable: Milagros Varela
    /// </remarks>
    public class GuanteDePoder: IAttackItem, IDefenseItem
    {
        public int AttackPower{get;set;}
        public int DefensePower{get;set;}
        public int Gemas{get;set;}

        public void AddGem(Gema gema)
        {
            this.Gemas =+ 1;
            this.AttackPower =+ gema.AttackPower;
            this.DefensePower =+ gema.DefensePower;
        }
    }
}