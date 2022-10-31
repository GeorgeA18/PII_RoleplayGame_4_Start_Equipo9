using System.Collections.Generic;
using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Personaje Dwarves
    /// </summary>
    public class Dwarves : Character
    {
        public Dwarves(string name) : base(name)
        {
            this.health = 100;
            this.AddItem(new CorazaDeEspinas());
            this.AddItem(new EspadaCorta());
        }
    }
}