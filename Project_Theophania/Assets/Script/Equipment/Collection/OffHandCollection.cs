using UnityEngine;
using System.Collections;

public class Shield : BaseOffHand
{

    public Shield(int id, string name, BaseOffHand baseOffhand) : base(baseOffhand)
    {
        this.Name = name;
        this.ID = id;
        this.offHandType = OffHandType.Shield;
    }
}
public class Orb : BaseOffHand
{

    public Orb(int id, string name, BaseOffHand baseOffhand) : base(baseOffhand)
    {
        this.Name = name;
        this.ID = id;
        this.offHandType = OffHandType.Orb;
    }
}

public class ElementGlove : BaseOffHand
{

    public ElementGlove(int id, string name, BaseOffHand baseOffhand) : base(baseOffhand)
    {
        this.Name = name;
        this.ID = id;
        this.offHandType = OffHandType.ElementGlove;
    }
}

public class Book : BaseOffHand
{

    public Book(int id, string name, BaseOffHand baseOffhand) : base(baseOffhand)
    {
        this.Name = name;
        this.ID = id;
        this.offHandType = OffHandType.Book;
    }
}