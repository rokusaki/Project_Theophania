using UnityEngine;
using System.Collections;

public class WorldController : MonoBehaviour {

    public enum WorldStatus
    {
        Ticking,
        Waiting
    }

    public static WorldController instance;
    public GameObject unitPrefabs;
    public GameObject commandPanel;

    private WorldStatus worldStatus;
    private UnitController[] allUnitsInField;

    public WorldStatus GetWorldStatus {
        get { return worldStatus; }
    }

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            worldStatus = WorldStatus.Ticking;
        }

    }

    void Start()
    {
        EventManager.Instance.AddListener<WorldTickingEvent>(OnWorldTicking);
        EventManager.Instance.AddListener<UnitEndTurnEvent>(OnUnitEndTurn);
        allUnitsInField = GetComponentsInChildren<UnitController>();
        
    }

    void FixedUpdate()
    {
        if (worldStatus == WorldStatus.Ticking)
        {
            EventManager.Instance.QueueEvent(new WorldTickingEvent(this));
        }
    }

    public void SetWorldStatus(WorldStatus worldStatus)
    {
        this.worldStatus = worldStatus;
        Debug.Log(worldStatus);
    }

    public void ActiveUnit(UnitController unit)
    {
        if (worldStatus == WorldStatus.Ticking)
        {
            worldStatus = WorldStatus.Waiting;
            

        }
    }

    void OnUnitEndTurn(UnitEndTurnEvent e)
    {
        if(worldStatus == WorldStatus.Waiting)
        {
            worldStatus = WorldStatus.Ticking;
        }
    }

    void OnWorldTicking(WorldTickingEvent e)
    {
        foreach(UnitController unit in allUnitsInField)
        {
            if(unit.CurrentWaitAmount >= unit.TargetWaitAmount)
            {
                if (worldStatus == WorldStatus.Ticking)
                {
                    worldStatus = WorldStatus.Waiting;
                    EventManager.Instance.QueueEvent(new UnitTakeTurnEvent(unit));
                }
            }
        }
    }
}
