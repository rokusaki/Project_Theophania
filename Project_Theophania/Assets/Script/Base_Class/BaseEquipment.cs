using UnityEngine;
using System.Collections;
using System;

public class BaseEquipment {

    public enum UnitEquipmentType
    {
        Weapon,
        OffHand,
        Armor,
        Accessory

    }

    private UnitEquipmentType equipmentType;
    private int attack;
    private int defense;
    private int magicAttack;
    private int magicDefense;
    private int speed;
    private int hitRate;
    private int dodgeRate;
    private int blockRate;
    private int fireResistance = 0;
    private int waterResistance = 0;
    private int thunderResistance = 0;
    private int windResistance = 0;
    private int earthResistance = 0;
    private int amount = 0;
    private int id;
    private string name;

    

    #region public value

    public int ID
    {
        get { return id; }
        set { id = value; }


    }

    public string Name
    {
        get { return name; }
        set { name = value; }

    }

    public int GetAmount
    {
        get { return amount; }
    }

    public int SetAmount
    {
        set { amount = value; }
    }

    public UnitEquipmentType EquipmentType
    {
        get { return equipmentType; }
        set { equipmentType = value; }
    }

    public int Attack
    {
        get { return attack; }
        set { attack = value; }
    }

    public int Defense
    {
        get { return defense; }
        set { defense = value; }
    }

    public int MagicAttack
    {
        get { return magicAttack; }
        set { magicAttack = value; }
    }

    public int MagicDefense
    {
        get { return magicDefense; }
        set { magicDefense = value; }
    }

    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public int HitRate
    {
        get { return hitRate; }
        set { hitRate = value; }
    }

    public int DodgeRate
    {
        get { return dodgeRate; }
        set { dodgeRate = value; }
    }

    public int BlockRate
    {
        get { return blockRate; }
        set { blockRate = value; }
    }

    public int FireResistance
    {
        get { return fireResistance; }
        set { fireResistance = value; }
    }

    public int WaterResistance
    {
        get { return waterResistance; }
        set { waterResistance = value; }
    }

    public int ThunderResistance
    {
        get { return thunderResistance; }
        set { thunderResistance = value; }
    }

    public int WindResistance
    {
        get { return windResistance; }
        set { windResistance = value; }
    }

    public int EarthResistance
    {
        get { return earthResistance; }
        set { earthResistance = value; }
    }

    #endregion
}
