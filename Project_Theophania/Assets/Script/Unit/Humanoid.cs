using UnityEngine;
using System.Collections;

public class Humanoid : BaseUnitAttribute , IUnitInital {

	public Humanoid(int id , string name, BaseUnitAttribute baseUnitAttribute) : base (baseUnitAttribute){
        this.SetID = id;
        this.SetName = name;
    }

    #region IUnitInitial
    public void InitAttribute()
    {


    }

    public void UpdateAttribute()
    {


    }

    public void SaveAttribute()
    {


    }
    #endregion
}
