using UnityEngine;
using System.Collections;

public class CastEnumType : BaseEquipment{

    public static BaseWeapon GetWeaponByType(BaseWeapon.WeaponType weaponType,
        int id , string name , BaseWeapon baseWeapon)
    {
        BaseWeapon newWeapon = new BaseWeapon();
        switch (weaponType)
        {
            case BaseWeapon.WeaponType.Sword:
                return new Sword(id , name , baseWeapon);
            case BaseWeapon.WeaponType.Axe:
                return new Axe(id, name, baseWeapon);
            case BaseWeapon.WeaponType.Spear:
                return new Spear(id, name, baseWeapon);
            case BaseWeapon.WeaponType.Staff:
                return new Staff(id, name, baseWeapon);
            default:
                Debug.LogError("Weapon type exception : " + weaponType.ToString());
                break;
        }


        return newWeapon;
    }
	
}