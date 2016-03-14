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
