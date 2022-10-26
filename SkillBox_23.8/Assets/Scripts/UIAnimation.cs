using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIAnimation : MonoBehaviour
{
    public Transform uiMainMenu;
    public Transform uiSelectMenu;

    private void Start()
    {
        
    }

    public void ShowMainMenu()
    {
        uiMainMenu.DOMoveY(0, 1f).SetEase(Ease.OutFlash);
        uiSelectMenu.DOMoveY(-100f, 1f);
    }

    public void ShowSelectLvlMenu()
    {
        uiMainMenu.DOMoveY(100f, 1f);
        uiSelectMenu.DOMoveY(0, 1f).SetEase(Ease.OutFlash);
    }
}
