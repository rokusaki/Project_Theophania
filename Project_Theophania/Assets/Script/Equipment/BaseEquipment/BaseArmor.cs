using UnityEngine;
using System.Collections;

public class BaseArmor : BaseEquipment
{

    public enum ArmorType
    {
        Armor,
        Head,
        Foot,
        Hand
    }

    public ArmorType armorType;

    public BaseArmor()
    {

    }

    public BaseArmor(BaseArmor BaseArmor)
    {
        this.EquipmentType = UnitEquipmentType.Armor;
        this.Attack = BaseArmor.Attack;
        this.Defense = BaseArmor.Defense;
        this.MagicAttack = BaseArmor.MagicAttack;
        this.MagicDefense = BaseArmor.MagicDefense;
        this.Speed = BaseArmor.Speed;
        this.HitRate = BaseArmor.HitRate;
        this.DodgeRate = BaseArmor.DodgeRate;
        this.BlockRate = BaseArmor.BlockRate;
    }

    public BaseArmor(int attack, int defense, int magicAttack, int magicDefense,
        int speed, int hitRate, int dodgeRate, int blockRate)
    {
        this.EquipmentType = UnitEquipmentType.Armor;
        this.Attack = attack;
        this.Defense = defense;
        this.MagicAttack = magicAttack;
        this.MagicDefense = magicDefense;
        this.Speed = speed;
        this.HitRate = hitRate;
        this.DodgeRate = dodgeRate;
        this.BlockRate = blockRate;
    }

}
