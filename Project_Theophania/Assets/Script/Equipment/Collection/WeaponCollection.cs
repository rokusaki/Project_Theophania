using UnityEngine;
using System.Collections;

public class Sword : BaseWeapon {
    
	public Sword(int id, string name , BaseWeapon baseWeapon): base(baseWeapon)
    {
        this.Name = name;
        this.ID = id;
        this.weaponType = WeaponType.Sword;
    }
}


public class Axe : BaseWeapon
{

    public Axe(int id, string name, BaseWeapon baseWeapon) : base(baseWeapon)
    {
        this.Name = name;
        this.ID = id;
        this.weaponType = WeaponType.Axe;
    }
}


public class Spear : BaseWeapon
{

    public Spear(int id, string name, BaseWeapon baseWeapon) : base(baseWeapon)
    {
        this.Name = name;
        this.ID = id;
        this.weaponType = WeaponType.Spear;
    }
}


public class Staff : BaseWeapon
{

    public Staff(int id, string name, BaseWeapon baseWeapon) : base(baseWeapon)
    {
        this.Name = name;
        this.ID = id;
        this.weaponType = WeaponType.Staff;
    }
}