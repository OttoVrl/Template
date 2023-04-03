using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : SingletonDestroyMono<UIManager>
{
    public List<GameObject> panels;

    public void DeactivatedAllPanels()
    {
        foreach (var panel in panels)
        {
            panel.SetActive(false);
        }
    }
}
