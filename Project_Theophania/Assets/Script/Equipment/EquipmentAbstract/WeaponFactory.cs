using UnityEngine;
using System.Collections;

public class WeaponFactory  {

   
    public static BaseWeapon CreateWeaponBaseMethod(BaseWeapon baseWeapon)
    {
        BaseWeapon newWeapon = baseWeapon;

        return newWeapon;
    }

    public static BaseWeapon CreateShortSword()
    {
        string name = "Short Sword";
        int id = 0,
            atk = 10,
            def = 0,
            mag = 2,
            res = 0,
            spd = 5,
            hit = 10,
            dodge = 5,
            blk = 5;

        BaseWeapon thisWeaponAttribute = new BaseWeapon(atk, def, mag, res, spd, hit, dodge, blk);

        return CreateWeaponBaseMethod(new Sword(id, name, thisWeaponAttribute));

    }

    public static BaseWeapon CreateWeapon(BaseWeapon.WeaponType weaponType, string name, int id , int atk , int def , int mag
        , int res , int spd , int hit , int dodge , int blk)
    {
        BaseWeapon thisWeaponAttribute = new BaseWeapon(atk, def, mag, res, spd, hit, dodge, blk);
        return CreateWeaponBaseMethod(CastEnumType.GetWeaponByType(weaponType, id, name, thisWeaponAttribute));
    }

    public static BaseWeapon CreateWeapon(BaseWeapon.WeaponType weaponType, string name , int id , BaseWeapon baseWeapon)
    {
        return CreateWeaponBaseMethod(CastEnumType.GetWeaponByType(weaponType, id, name, baseWeapon));
    }
}
