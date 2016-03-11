using UnityEngine;
using System.Collections;


public class BaseUnitAttribute  {


    private string name;
    private int id;

    private int hp;
    private int maxHP;
    private int mp;
    private int maxMP;
    private int stregnth;
    private int agility;
    private int magic;
    private int resistance;
    private int vitality;

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


    private BaseUnitAttribute()
    {

    }

    public BaseUnitAttribute(BaseUnitAttribute baseUnitAttribute)
    {
        this.stregnth = baseUnitAttribute.Stregnth;
        this.agility = baseUnitAttribute.Agility;
        this.magic = baseUnitAttribute.Magic;
        this.vitality = baseUnitAttribute.Vitality;
        this.resistance = baseUnitAttribute.Resistance;
        this.maxHP = InitMaxHp(stregnth, vitality);
        this.maxMP = InitMaxMp(magic, resistance);
        this.Hp = this.maxHP;
        this.Mp = this.maxMP;
        this.speed += baseUnitAttribute.agility;
    }

    public BaseUnitAttribute(int str , int agi , int mag , int vit , int res)
    {
        this.stregnth = str;
        this.agility = agi;
        this.magic = mag;
        this.vitality = vit;
        this.resistance = res;
        this.maxHP = InitMaxHp(str,vit);
        this.maxMP = InitMaxMp(mag,res);
        this.Hp = this.maxHP;
        this.Mp = this.maxMP;
        this.speed += agi;
    }

    int InitMaxHp(int str , int vit)
    {
        return (str) + (vit * 3);
    }

    int InitMaxMp(int mag, int res)
    {
        return (res) + (mag * 2);
    }

    


    #region public value

    public string GetName
    {
        get { return name; }
    }

    public string SetName
    {
        set { name = value; }
    }

    public int GetID
    {
        get { return id; }
    }

    public int SetID
    {
        set { id = value; }
    }

    public int Hp{
        get { return hp; }
        set {
            int newHp = value;
            if(maxHP > 0)
            {
                if (newHp > maxHP) hp = maxHP;
                else hp = newHp;
            }
        }
    }

    public int Mp
    {
        get { return mp; }
        set {
            int newMP = value;
            if (maxMP > 0)
            {
                if (newMP > maxMP) mp = maxMP;
                else mp = newMP;
            }
        }
    }

    public int MaxHP
    {
        get { return maxHP; }
    }

    public int MaxMP
    {
        get { return maxMP; }
    }

    public int Stregnth
    {
        get { return stregnth; }
        set { stregnth =  value; }
    }

    public int Agility
    {
        get { return agility; }
        set { agility = value; }
    }

    public int Magic
    {
        get { return magic; }
        set { magic = value; }
    }

    public int Vitality
    {
        get { return vitality; }
        set { vitality = value; }
    }

    public int Resistance
    {
        get { return resistance; }
        set { resistance = value; }
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

    #endregion



}
