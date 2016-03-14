using UnityEngine;
using System.Collections;

public class BaseSkill  {

    private string name;
    private int id;

    private int attackPower;
    private int cost;
    private int range;
    private float delay;
    private float cooldownTime;
    private float castTime;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int ID
    {
        get { return id; }
        set { id = value; }
    }

    public int AttackPower
    {
        get { return attackPower; }
        set { attackPower = value; }
    }

    public int Cost
    {
        get { return cost; }
        set { cost = value; }
    }

    public int Range
    {
        get { return range; }
        set { range = value; }

    }

    public float Delay
    {
        get { return delay; }
        set { delay = value; }
    }

    public float CooldownTime
    {
        get { return cooldownTime; }
        set { cooldownTime = value; }
    }

    public float CastTime
    {
        get { return castTime; }
        set { castTime = value; }
    }

}
