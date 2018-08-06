namespace Parcial1_logic.OOP
{
    public class Enemy: Actor
    {
        public override MovementType Move(MovementType type)
        {
            if (type == MovementType.AI)
            {
                //me muevo jaja salu2 (soy un Enemigo buajajaja)
            }
            return type;
        }

        public Enemy(float baseAttack, float baseDefense)
        {
            baseATK = baseAttack;
            baseDEF = baseDefense;
        }

    }
}