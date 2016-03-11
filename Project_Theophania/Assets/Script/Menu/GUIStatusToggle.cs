using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GUIStatusToggle : MonoBehaviour {

    public GUIStatusPanel statusPanel;
    public int thisPageID;

    private Toggle toggle;

	// Use this for initialization
	void Start () {
        toggle = GetComponent<Toggle>();

    }
	
	public void ChangePage(bool isOn)
    {
        if (isOn)
        {
            statusPanel.OnChangePage(thisPageID);
        }

    }
}
