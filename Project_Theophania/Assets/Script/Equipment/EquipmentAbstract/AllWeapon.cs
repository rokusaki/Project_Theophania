using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class AllWeapon : MonoBehaviour , IEquipmentManager
{

    public static AllWeapon instance;

    private int runningID = 0;
    public static Dictionary<int, BaseWeapon> allWeapon;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            allWeapon = new Dictionary<int,BaseWeapon>();
           
        }
        InitialAllWeapon();
    }

    void InitialAllWeapon()
    {
        BaseWeapon newWeapon = CreateShortSword();
        Debug.Log(newWeapon.ID);
        allWeapon.Add(newWeapon.ID, newWeapon);

    }

	BaseWeapon CreateWeaponBaseMethod(BaseWeapon baseWeapon)
    {
        BaseWeapon newWeapon = baseWeapon;

        return newWeapon;
    }

    BaseWeapon CreateShortSword()
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

        BaseWeapon thisWeaponAttribute = new BaseWeapon(atk,def,mag,res,spd,hit,dodge,blk);

       return CreateWeaponBaseMethod(new Sword(id,name, thisWeaponAttribute));

    }

    public BaseEquipment GetEquipmentByID(int id)
    {
        return allWeapon[id];
    }

    public BaseEquipment GetEquipmentByName()
    {
        throw new NotImplementedException();
    }

    public BaseEquipment[] GetAllEquipment()
    {
        throw new NotImplementedException();
    }

    public string[] GetAllEquipmentName()
    {
        throw new NotImplementedException();
    }

    public int[] GetAllEquipmentId()
    {
        throw new NotImplementedException();
    }
}
