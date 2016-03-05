using UnityEngine;
using System.Collections;

public class BaseAccessory : BaseEquipment
{

    public enum AccessoryType
    {
        Ring,
        Necklace,
        Belt,
        Earring
    }

    public AccessoryType accessoryType;

    public BaseAccessory()
    {

    }

    public BaseAccessory(BaseAccessory BaseAccessory)
    {
        this.EquipmentType = UnitEquipmentType.Accessory;
        this.Attack = BaseAccessory.Attack;
        this.Defense = BaseAccessory.Defense;
        this.MagicAttack = BaseAccessory.MagicAttack;
        this.MagicDefense = BaseAccessory.MagicDefense;
        this.Speed = BaseAccessory.Speed;
        this.HitRate = BaseAccessory.HitRate;
        this.DodgeRate = BaseAccessory.DodgeRate;
        this.BlockRate = BaseAccessory.BlockRate;
    }

    public BaseAccessory(int attack, int defense, int magicAttack, int magicDefense,
        int speed, int hitRate, int dodgeRate, int blockRate)
    {
        this.EquipmentType = UnitEquipmentType.Accessory;
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
