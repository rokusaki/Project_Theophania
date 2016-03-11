using UnityEngine;
using DG.Tweening;
using System.Collections;

public class BookPageController : MonoBehaviour {

    public GameObject[] page;
    private bool isSwipeLeft;

    // Use this for initialization
    public void Swipe(bool isSwipeLeft) {
        this.isSwipeLeft = isSwipeLeft;
        if (isSwipeLeft)
        {
            transform.DOScaleX(-1, 1).OnUpdate(OnPageSwipe).OnComplete(OnSwipeFinish);
        }
        else
        {
            transform.DOScaleX(1, 1).OnUpdate(OnPageSwipe).OnComplete(OnSwipeFinish);
        }
    }


    void OnPageSwipe()
    {
        if (transform.localScale.x < 0 && isSwipeLeft)
        {
            page[0].SetActive(false);
            page[1].SetActive(true);

            transform.SetAsLastSibling();
            
        }
        else if(transform.localScale.x > 0 && !isSwipeLeft)
        {
            page[0].SetActive(true);
            page[1].SetActive(false);

            transform.SetAsLastSibling();

        }

    }

    void OnSwipeFinish()
    {
        //isSwipeLeft = false;
    }
}
