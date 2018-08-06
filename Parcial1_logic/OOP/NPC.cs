namespace Parcial1_logic.OOP
{
    public class NPC: ICharacter
    {
        public virtual MovementType Move(MovementType type)
        {
            if(type==MovementType.Waypoint)
            {
                //me muevo jaja salu2 (soy un ENEPECE)
            }
            return type;
        }
    }
}