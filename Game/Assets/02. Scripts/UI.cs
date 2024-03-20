using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public RectTransform actUI;
    public RectTransform bagUI;
    public RectTransform developUI;
    public RectTransform employeeUI;
    public RectTransform gachaUI;
    public RectTransform storeUI;
    public RectTransform systemUI;

    public void ACT_BtnClick()
    {
        actUI.anchoredPosition = Vector3.zero;
    }

    public void ACT_BtnOut()
    {
        actUI.anchoredPosition = Vector3.down * 1500;
    }

    public void BAG_BtnClick()
    {
        bagUI.anchoredPosition = Vector3.zero;
    }

    public void BAG_BtnOut()
    {
        bagUI.anchoredPosition = Vector3.down * 1500;
    }
    public void Develop_BtnClick()
    {
        developUI.anchoredPosition = Vector3.zero;
    }

    public void Develop_BtnOut()
    {
        developUI.anchoredPosition = Vector3.down * 1500;
    }
    public void Employee_BtnClick()
    {
        employeeUI.anchoredPosition = Vector3.zero;
    }

    public void Employee_BtnOut()
    {
        employeeUI.anchoredPosition = Vector3.down * 1500;
    }
    public void Gacha_BtnClick()
    {
        gachaUI.anchoredPosition = Vector3.zero;
    }

    public void Gacha_BtnOut()
    {
        gachaUI.anchoredPosition = Vector3.down * 1500;
    }
    public void Store_BtnClick()
    {
        storeUI.anchoredPosition = Vector3.zero;
    }

    public void Store_BtnOut()
    {
        storeUI.anchoredPosition = Vector3.down * 1500;
    }
    public void System_BtnClick()
    {
        systemUI.anchoredPosition = Vector3.zero;
    }

    public void System_BtnOut()
    {
        systemUI.anchoredPosition = Vector3.down * 1500;
    }
}
