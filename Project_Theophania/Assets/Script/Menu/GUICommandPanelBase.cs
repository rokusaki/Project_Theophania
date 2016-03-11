using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Collections;

public class GUICommandPanelBase : MonoBehaviour {

    public Button moveButton;
    public Button actionButton;
    public Button waitButton;
    public Button backButton;

    private Vector3 moveButtonPosition;
    private Vector3 actionButtonPosition;
    private Vector3 waitButtonPosition;
    private Vector3 backButtonPosition;

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
        if (isFadeIn)
        {
            moveButton.transform.DOScale(1, .5f).SetEase(Ease.OutBack).SetDelay(.1f);
            moveButton.transform.DOMove(Vector3.zero, .5f).From().SetEase(Ease.OutBack).SetDelay(.1f);
            actionButton.transform.DOScale(1, .5f).SetEase(Ease.OutBack).SetDelay(.2f);
            actionButton.transform.DOMove(Vector3.zero, .5f).From().SetEase(Ease.OutBack).SetDelay(.2f);
            waitButton.transform.DOScale(1, .5f).SetEase(Ease.OutBack).SetDelay(.3f);
            waitButton.transform.DOMove(Vector3.zero, .5f).From().SetEase(Ease.OutBack).SetDelay(.3f);
            backButton.transform.DOScale(1, .5f).SetEase(Ease.OutBack).SetDelay(.4f);
            backButton.transform.DOMove(Vector3.zero, .5f).From().SetEase(Ease.OutBack).SetDelay(.4f);
        }
        else
        {
            moveButton.transform.DOScale(0, .25f).SetEase(Ease.InBack).SetDelay(.1f);
           // moveButton.transform.DOMove(Vector3.zero, .5f).SetEase(Ease.OutBack).SetDelay(.1f);
            actionButton.transform.DOScale(0, .25f).SetEase(Ease.InBack).SetDelay(.2f);
           // actionButton.transform.DOMove(Vector3.zero, .5f).SetEase(Ease.OutBack).SetDelay(.2f);
            waitButton.transform.DOScale(0, .25f).SetEase(Ease.InBack).SetDelay(.3f);
           // waitButton.transform.DOMove(Vector3.zero, .5f).SetEase(Ease.OutBack).SetDelay(.3f);
            backButton.transform.DOScale(0, .25f).SetEase(Ease.InBack).SetDelay(.4f).OnComplete(OnCompleteDestroyObject);
           // backButton.transform.DOMove(Vector3.zero, .5f).SetEase(Ease.OutBack).SetDelay(.4f);

        }

        
    }

    void DestroyThis()
    {
        Destroy(gameObject);

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
    }

    void OnBackClick()
    {
        Debug.Log("Back Click");
        FadeOut();
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
