using UnityEngine;
using System.Collections;

public class WorldTickingEventHandler
{
    public void SetupListeners()
    {
        EventManager.Instance.AddListener<WorldTickingEvent>(OnWorldTicking);
    }

    public void DisposeListeners()
    {
        EventManager.Instance.RemoveListener<WorldTickingEvent>(OnWorldTicking);
    }


    void OnWorldTicking(WorldTickingEvent e)
    {


    }
}
