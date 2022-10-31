namespace RoleplayGame.Items
{
    /// <summary>
    /// Tipos de elementos
    /// </summary>
    public enum ItemType
    {
        Magic = 1,
        Robes = 2,
        EspadaCorta = 3,
        EscudoPicudo = 4,
        CorazaDeEspinas = 5,
        ArcoDeSangre = 6,
        BastonMagico = 7,
        GuanteDePoder = 8,
    }

    /// <summary>
    /// Creador de elementos. 
    /// </summary>
    public class ItemFactory
    {
        /// <summary>
        /// Permite crear elementos dado un tipo de elemento.
        /// </summary>
        /// <param name="type">El tipo de elemento</param>
        /// <returns>El elemento</returns>
        public static IItem GetItem(ItemType type)
        {
            switch (type)
            {
                case ItemType.Magic: return new Magic();
                case ItemType.Robes: return new Robes();
                case ItemType.EspadaCorta: return new EspadaCorta();
                case ItemType.EscudoPicudo: return new EscudoPicudo();
                case ItemType.CorazaDeEspinas: return new CorazaDeEspinas();
                case ItemType.ArcoDeSangre: return new ArcoDeSangre();
                case ItemType.BastonMagico: return new BastonMagico();
                case ItemType.GuanteDePoder: return new GuanteDePoder();

                default: return null;
            }
        }
    }
}