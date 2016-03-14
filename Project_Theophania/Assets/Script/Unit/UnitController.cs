using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Collections;

public class UnitController : MonoBehaviour  {

    #region public field
    public int id;
    public string unitName;
    public StartAttribute startAttribute;
    public UIComponent ui;
    [HideInInspector] public float CurrentWaitAmount
    {
        get { return currentWaitAmount; }
    }
    [HideInInspector]
    public float TargetWaitAmount
    {
        get { return targetWaitAmount; }
    }
    #endregion

    #region private field
    private BaseUnitAttribute unitAttribute;
    private WorldTickingEventHandler worldEvent;
    private Humanoid thisUnit;
    private GameObject commandPanel;
    private float currentWaitAmount;
    private float baseWaitAmount = 0;
    private float extraWaitAmount = 0;
    private float targetWaitAmount = 0;

    #endregion

    #region InitSetup
    public BaseUnitAttribute UnitAttribute
    {
        get { return unitAttribute; }
    }

    void Awake()
    {
        unitAttribute = new BaseUnitAttribute(startAttribute.stregnth,
            startAttribute.agility,
            startAttribute.magic,
            startAttribute.vitality,
            startAttribute.resistance);
    }

    void Start()
    {
        EventManager.Instance.AddListener<WorldTickingEvent>(OnWorldTicking);
        EventManager.Instance.AddListener<TakeDamageEvent>(OnHPGaugeChange);
        EventManager.Instance.AddListener<UnitTakeTurnEvent>(OnUnitActive);
        EventManager.Instance.AddListener<UnitEndTurnEvent>(OnEndTurn);
        EventManager.Instance.AddListener<MoveUnitEvent>(OnMoveUnit);


        thisUnit = new Humanoid(id, unitName, unitAttribute);
        baseWaitAmount = 1000.0f / unitAttribute.Speed;
        targetWaitAmount = baseWaitAmount;
        name = unitName;
    }

    #endregion


    #region EventHandler

    void OnHPGaugeChange(TakeDamageEvent e)
    {
        unitAttribute.Hp -= CalculateController.GetDamage(e.attacker, e.defender);

        float targetFill = (float)unitAttribute.Hp / (float)unitAttribute.MaxHP;
        ui.HPGauge.DOFillAmount(targetFill, .1f);

        
    }

    void OnMPGaugeChange()
    {

    }


    void OnWorldTicking(WorldTickingEvent e)
    {
        float targetFill = CalculateController.GetWaitAmount(this , currentWaitAmount , targetWaitAmount);
        currentWaitAmount = targetFill;
        ui.WTGauge.DOFillAmount(targetFill / targetWaitAmount, .025f);

    }

    void OnUnitActive(UnitTakeTurnEvent e)
    {
        if (e.activeUnit == this) { 
            commandPanel = Instantiate(ui.CommandPanel) as GameObject;
            GUICommandPanelBase panel = commandPanel.GetComponent<GUICommandPanelBase>();
            panel.InitButton(this);


            commandPanel.transform.SetParent(ui.parentCanvas);
            commandPanel.transform.localScale = Vector3.one ;
            commandPanel.transform.localPosition = Vector3.zero;
            commandPanel.SetActive(true);
        }
    }

    void OnMoveUnit(MoveUnitEvent e)
    {
        if(e.activeUnit == this)
        {

        }
    }

    void OnEndTurn(UnitEndTurnEvent e)
    {
        if (e.activeUnit == this)
        {
            currentWaitAmount = 0;
            ui.WTGauge.DOFillAmount(0, .005f);
            targetWaitAmount = baseWaitAmount + extraWaitAmount;
        }
    }


    void OnDestroy()
    {
        if (EventManager.Instance != null)
        {
            EventManager.Instance.RemoveListener<WorldTickingEvent>(OnWorldTicking);
            EventManager.Instance.RemoveListener<TakeDamageEvent>(OnHPGaugeChange);
            EventManager.Instance.RemoveListener<UnitTakeTurnEvent>(OnUnitActive);
            EventManager.Instance.RemoveListener<UnitEndTurnEvent>(OnEndTurn);
        }
    }

    #endregion

    #region inner Class

    [System.Serializable]
    public class StartAttribute
    {
        public int stregnth;
        public int agility;
        public int magic;
        public int resistance;
        public int vitality;

    }

    [System.Serializable]
    public class UIComponent
    {
        public RectTransform parentCanvas;
        public Image HPGauge;
        public Image MPGauge;
        public Image WTGauge;
        public GameObject CommandPanel;
    }

    #endregion
}
