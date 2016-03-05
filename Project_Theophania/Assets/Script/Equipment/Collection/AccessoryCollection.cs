using UnityEngine;
using System.Collections;

public class Ring : BaseAccessory
{

    public Ring(int id, string name, BaseAccessory baseAcessory) : base(baseAcessory)
    {
        this.Name = name;
        this.ID = id;
        this.accessoryType = AccessoryType.Ring;
    }
}

public class Necklace : BaseAccessory
{

    public Necklace(int id, string name, BaseAccessory baseAcessory) : base(baseAcessory)
    {
        this.Name = name;
        this.ID = id;
        this.accessoryType = AccessoryType.Necklace;
    }
}

public class Belt : BaseAccessory
{

    public Belt(int id, string name, BaseAccessory baseAcessory) : base(baseAcessory)
    {
        this.Name = name;
        this.ID = id;
        this.accessoryType = AccessoryType.Belt;
    }
}

public class Earring : BaseAccessory
{

    public Earring(int id, string name, BaseAccessory baseAcessory) : base(baseAcessory)
    {
        this.Name = name;
        this.ID = id;
        this.accessoryType = AccessoryType.Earring;
    }
}