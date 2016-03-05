using UnityEngine;
using System.Collections;

public class BaseWeapon : BaseEquipment {

    public enum WeaponType
    {
        Sword,
        Axe,
        Mace,
        Spear,
        Bow,
        Staff,
        Knife
    }

    public WeaponType weaponType;

    public BaseWeapon()
    {

    }

    public BaseWeapon(BaseWeapon baseWeapon)
    {
        this.EquipmentType = UnitEquipmentType.Weapon;
        this.Attack = baseWeapon.Attack;
        this.Defense = baseWeapon.Defense;
        this.MagicAttack = baseWeapon.MagicAttack;
        this.MagicDefense = baseWeapon.MagicDefense;
        this.Speed = baseWeapon.Speed;
        this.HitRate = baseWeapon.HitRate;
        this.DodgeRate = baseWeapon.DodgeRate;
        this.BlockRate = baseWeapon.BlockRate;
    }

    public BaseWeapon(int attack,int defense , int magicAttack , int magicDefense , 
        int speed , int hitRate , int dodgeRate , int blockRate)
    {
        this.EquipmentType = UnitEquipmentType.Weapon;
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
