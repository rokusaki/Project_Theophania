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

    }

    void LateStart()
    {


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

    bool TryGetWeapon(int weaponID, out BaseWeapon baseWeapon )
    {
        return (baseWeapon = GetWeapon(weaponID)) == null ?
            false : true ;
    }

    bool TryGetArmor(int armorID, out BaseArmor baseArmor)
    {
        return (baseArmor = GetArmor(armorID)) == null ?
            false : true;
    }

    bool TryGetAccessory(int accessoryID, out BaseAccessory baseAccesory)
    {
        return (baseAccesory = GetAccessory(accessoryID)) == null ?
            false : true;
    }

    bool TryGetOffHand(int offHandID, out BaseOffHand baseOffHand)
    {
        return (baseOffHand = GetOffHand(offHandID)) == null ?
            false : true;
    }

    BaseWeapon GetWeapon(int weaponID)
    {

        return (BaseWeapon)AllWeapon.instance.GetEquipmentByID(weaponID);
    }

    BaseArmor GetArmor(int armorID)
    {

        return (BaseArmor)AllWeapon.instance.GetEquipmentByID(armorID);
    }

    BaseAccessory GetAccessory(int accID)
    {

        return (BaseAccessory)AllWeapon.instance.GetEquipmentByID(accID);
    }

    BaseOffHand GetOffHand(int offHandID)
    {

        return (BaseOffHand)AllWeapon.instance.GetEquipmentByID(offHandID);
    }

    #endregion

    #region Destroyer




    #endregion

}
