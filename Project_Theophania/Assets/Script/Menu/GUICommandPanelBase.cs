using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Collections;

public class GUICommandPanelBase : MonoBehaviour {

    public GameObject MovingPanel;

    public Button moveButton;
    public Button actionButton;
    public Button waitButton;
    public Button backButton;

    private GameObject movingPanel;
    private UnitController activeUnit;

    TweenCallback OnCompleteDestroyObject;

    private bool isLock;

    void Awake()
    {
        
        moveButton.transform.localScale = Vector3.zero;
        actionButton.transform.localScale = Vector3.zero;
        waitButton.transform.localScale = Vector3.zero;
        backButton.transform.localScale = Vector3.zero;

        OnCompleteDestroyObject += DestroyThis;
    }

    void Start()
    {
        //Get Some Script
        DOTween.Init(true, true, LogBehaviour.ErrorsOnly);
        StartCoroutine(StartInit());
    }

    public void InitButton(UnitController activeUnit)
    {
        this.activeUnit = activeUnit;
    }

    IEnumerator StartInit()
    {
       
        moveButton.onClick.AddListener(() => OnMoveClick());
        actionButton.onClick.AddListener(() => OnActionClick());
        waitButton.onClick.AddListener(() => OnWaitClick());
        backButton.onClick.AddListener(() => OnBackClick());

        yield return new WaitForEndOfFrame();
        PlayButtonOnTween(true);

    }

    

    void PlayButtonOnTween(bool isFadeIn)
    {
        //LockButton(true);
        if (isFadeIn)
        {
            moveButton.transform.DOScale(1, .5f).SetEase(Ease.OutBack).SetDelay(.1f);
            moveButton.transform.DOLocalMove(Vector3.zero, .5f).From().SetEase(Ease.OutBack).SetDelay(.1f);
            actionButton.transform.DOScale(1, .5f).SetEase(Ease.OutBack).SetDelay(.2f);
            actionButton.transform.DOLocalMove(Vector3.zero, .5f).From().SetEase(Ease.OutBack).SetDelay(.2f);
            waitButton.transform.DOScale(1, .5f).SetEase(Ease.OutBack).SetDelay(.3f);
            waitButton.transform.DOLocalMove(Vector3.zero, .5f).From().SetEase(Ease.OutBack).SetDelay(.3f);
            backButton.transform.DOScale(1, .5f).SetEase(Ease.OutBack).SetDelay(.4f);
            backButton.transform.DOLocalMove(Vector3.zero, .5f).From().SetEase(Ease.OutBack).SetDelay(.4f).OnComplete(OnCompleteFadeIn);
        }
        else
        {
            moveButton.transform.DOScale(0, .25f).SetEase(Ease.InBack).SetDelay(.1f);     
            actionButton.transform.DOScale(0, .25f).SetEase(Ease.InBack).SetDelay(.2f);    
            waitButton.transform.DOScale(0, .25f).SetEase(Ease.InBack).SetDelay(.3f);
            backButton.transform.DOScale(0, .25f).SetEase(Ease.InBack).SetDelay(.4f).OnComplete(OnCompleteDestroyObject);
        }

        
    }

    void DestroyThis()
    {
        EventManager.Instance.QueueEvent(new UnitEndTurnEvent(activeUnit));
        Destroy(gameObject);

    }

    void OnCompleteFadeIn()
    {
        LockButton(false);
    }

    void FadeOut()
    {
        PlayButtonOnTween(false);
    }


    void OnMoveClick()
    {
        
        Debug.Log("Move Click");
    }

    void OnActionClick()
    {
        Debug.Log("Action Click");
    }

    void OnWaitClick()
    {
        Debug.Log("Wait Click");
        FadeOut();
    }

    void OnBackClick()
    {
        Debug.Log("Back Click");
        
        
    }

    protected virtual void LockButton(bool lockButton)
    {
        if (lockButton)
        {
            moveButton.interactable = false;
            actionButton.interactable = false;
            waitButton.interactable = false;
            backButton.interactable = false;
        }
        else
        {
            moveButton.interactable = true;
            actionButton.interactable = true;
            waitButton.interactable = true;
            backButton.interactable = true;
        }

    }
}
