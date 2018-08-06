namespace Parcial1_logic.OOP
{
    public class Hero : Actor
    {
        public Weapon CurrentWeapon { get; protected set; }
        public Armor CurrentArmor { get; protected set; }

        public Hero(float atk, float def)
        {
            atk = baseATK;
            def = baseDEF;
        }

        public void Equipment(Gear equipamento)
        {
            if(equipamento is Armor)
            {
                
            }
            if(equipamento is Weapon)
            {

            }
        }
        
        
        public override MovementType Move(MovementType type)
        {
            if (type == MovementType.Input)
            {
                //me muevo jaja salu2 (soy un Heroe)
            }
            return type;
        }

        

        public void ResetEquipment()
        {
            CurrentArmor = null;
            CurrentWeapon = null;
        }
    }
}