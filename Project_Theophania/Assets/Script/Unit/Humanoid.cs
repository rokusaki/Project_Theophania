using UnityEngine;
using System.Collections;

public class Humanoid : BaseUnitAttribute , IUnitInital {

	public Humanoid(int id , string name, BaseUnitAttribute baseUnitAttribute) : base (baseUnitAttribute){
        this.SetID = id;
        this.SetName = name;
        InitAttribute();
    }

    #region IUnitInitial
    public void InitAttribute()
    {

        SaveAttribute();
    }

    public void UpdateAttribute()
    {

        SaveAttribute();
    }

    public void SaveAttribute()
    {


    }
    #endregion
}
