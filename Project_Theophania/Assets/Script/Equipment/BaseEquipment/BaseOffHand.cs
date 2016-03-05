using UnityEngine;
using System.Collections;

public class BaseOffHand : BaseEquipment
{

    public enum OffHandType
    {
        Shield,
        Book,
        Orb,
        ElementGlove
    }

    public OffHandType offHandType;

    public BaseOffHand()
    {

    }

    public BaseOffHand(BaseOffHand BaseOffHand)
    {
        this.EquipmentType = UnitEquipmentType.OffHand;
        this.Attack = BaseOffHand.Attack;
        this.Defense = BaseOffHand.Defense;
        this.MagicAttack = BaseOffHand.MagicAttack;
        this.MagicDefense = BaseOffHand.MagicDefense;
        this.Speed = BaseOffHand.Speed;
        this.HitRate = BaseOffHand.HitRate;
        this.DodgeRate = BaseOffHand.DodgeRate;
        this.BlockRate = BaseOffHand.BlockRate;
    }

    public BaseOffHand(int attack, int defense, int magicAttack, int magicDefense,
        int speed, int hitRate, int dodgeRate, int blockRate)
    {
        this.EquipmentType = UnitEquipmentType.OffHand;
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
