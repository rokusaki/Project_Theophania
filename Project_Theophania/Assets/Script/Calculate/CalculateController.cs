using UnityEngine;
using System.Collections;

public class CalculateController  {

	public static int GetDamage(UnitController attacker , UnitController defender )
    {
        int atk = attacker.UnitAttribute.Attack;
        int def = defender.UnitAttribute.Defense;
        return (atk - def) < 0 ? 1 : atk - def;
    }

    public static float GetWaitAmount(UnitController unit , float currentWait , float targetWait)
    {
        
        float targetFill = (currentWait + (unit.UnitAttribute.Speed/10)) > targetWait ?
            targetWait : currentWait + ((float)unit.UnitAttribute.Speed/10);
        
        return targetFill;
    }
}
