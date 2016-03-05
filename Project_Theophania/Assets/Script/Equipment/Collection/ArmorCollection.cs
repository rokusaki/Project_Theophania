using UnityEngine;
using System.Collections;

public class Cloth : BaseArmor {

    public Cloth(int id, string name, BaseArmor baseArmor): base(baseArmor)
    {
        this.Name = name;
        this.ID = id;
        this.armorType = ArmorType.Armor;
    }
}

public class Hat : BaseArmor
{

    public Hat(int id, string name, BaseArmor baseArmor) : base(baseArmor)
    {
        this.Name = name;
        this.ID = id;
        this.armorType = ArmorType.Head;
    }
}


public class Wristband : BaseArmor
{

    public Wristband(int id, string name, BaseArmor baseArmor) : base(baseArmor)
    {
        this.Name = name;
        this.ID = id;
        this.armorType = ArmorType.Hand;
    }
}


public class Sandals : BaseArmor
{

    public Sandals(int id, string name, BaseArmor baseArmor) : base(baseArmor)
    {
        this.Name = name;
        this.ID = id;
        this.armorType = ArmorType.Foot;
    }
}

