using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Collections;

public class GUIStatusPanel : MonoBehaviour {

    #region widget
    public BookPageController[] paperPage;
    public RectTransform[] statusPage;
    public RectTransform[] skillPage;
    public RectTransform[] equipmentPage;
    public Toggle[] toggleTab;
    #endregion

    #region member
    private int initPage = 0;
    private int currentPage = 0;
    private int maxPage;
    #endregion

    void Awake()
    {
        maxPage = toggleTab.Length;
        DOTween.Init(true, true, LogBehaviour.ErrorsOnly);
    }



    public void OnChangePage(int page)
    {
        if (currentPage < page)
        {
            while (currentPage < page) {
                paperPage[currentPage].Swipe(true);
                currentPage++;
                if (currentPage > maxPage) currentPage = maxPage;
            }
        }
        else if(currentPage > page)
        {
            while (currentPage > page)
            {
                paperPage[currentPage - 1].Swipe(false);
                currentPage--;
                if (currentPage < 0) currentPage = 0;
            }
        }

       
    }

}
