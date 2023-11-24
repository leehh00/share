using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Menu : MonoBehaviour
{
    public GameObject menuOpen;
    public GameObject menuClose;

    public GameObject mainMenu1;
    public GameObject mainMenu2;
    public GameObject mainMenu3;
    public GameObject mainMenu4;

    public void openBtn_clicked()
    {
        menuOpen.SetActive(false);
        mainMenu1.SetActive(true);
        mainMenu2.SetActive(true);
        mainMenu3.SetActive(true);
        mainMenu4.SetActive(true);
        menuClose.SetActive(true);
    }

    public void closeBtn_clicked()
    {
        mainMenu1.SetActive(false);
        mainMenu2.SetActive(false);
        mainMenu3.SetActive(false);
        mainMenu4.SetActive(false);
        menuClose.SetActive(false);
        menuOpen.SetActive(true);
    }
}
