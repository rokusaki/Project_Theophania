using UnityEngine;
using System.Collections;
using System;

public class EquipmentController : MonoBehaviour
{

    public static EquipmentController instance;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }

    }

    void Start()
    {

        StartCoroutine(LateGetWeapon());
    }

    IEnumerator LateGetWeapon()
    {
        yield return new WaitForSeconds(1);
        Debug.Log(CollectWeapon(0).Name);

    }

    #region Storer
    void StoreWeapon(BaseWeapon weapon)
    {
        

    }

    void StoreArmor(BaseArmor armor)
    {


    }

    void StoreAccessory(BaseAccessory accessory)
    {


    }

    void StoreOffHand(BaseOffHand offHand)
    {


    }

    void StoreAllEquipment()
    {


    }

    #endregion

    #region Collector

    BaseWeapon CollectWeapon(int weaponID)
    {

        return (BaseWeapon)AllWeapon.instance.GetEquipmentByID(weaponID);
    }

    void CollectArmor(int armorID)
    {


    }

    void CollectAccessory(int accID)
    {


    }

    void CollectOffHand(int offHandID)
    {


    }

    #endregion

    #region Destroyer




    #endregion

}
