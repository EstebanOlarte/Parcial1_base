namespace Parcial1_logic.OOP
{
    public abstract class Actor: ICharacter
    {
        public float baseDEF = 1f;
        public float baseATK = 1f;

       

        public virtual MovementType Move(MovementType type)
        {
            //jaja nunca saldre
            return type;
        }
        

    }
}