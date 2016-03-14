using UnityEngine;
using System.Collections;

public enum Events
{
    WorldTicking,
    WorldWaiting
}

public class WorldTickingEvent : GameEvent  {
    
    public WorldController world { get; private set; }

    public WorldTickingEvent(WorldController world)
    {
        this.world = world;
        
    }
}

public class TakeDamageEvent : GameEvent
{
    public UnitController attacker;
    public UnitController defender;

    public TakeDamageEvent(UnitController attacker , UnitController defender)
    {
        this.attacker = attacker;
        this.defender = defender;
    }
}

public class UnitTakeTurnEvent : GameEvent
{
    public UnitController activeUnit;

    public UnitTakeTurnEvent(UnitController activeUnit)
    {
        this.activeUnit = activeUnit;
    }
}

public class UnitEndTurnEvent : GameEvent
{
    public UnitController activeUnit;

    public UnitEndTurnEvent(UnitController activeUnit)
    {
        this.activeUnit = activeUnit;
    }
}

public class MoveUnitEvent : GameEvent
{
    public UnitController activeUnit;
    public Vector2 startPosition;
    public Vector2 targetPosition;

    public MoveUnitEvent(UnitController activeUnit , Vector2 startPosition , Vector2 targetPosition)
    {
        this.activeUnit = activeUnit;
        this.startPosition = startPosition;
        this.targetPosition = targetPosition;
    }
}