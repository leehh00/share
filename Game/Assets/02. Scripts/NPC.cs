using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public RectTransform uiGroup;

    Player enterPlayer;

    public void Enter(Player player)
    {
        enterPlayer = player;
        if (Input.GetKeyDown(KeyCode.E))
            uiGroup.anchoredPosition = Vector3.zero;
    }

    public void Exit()
    {
        uiGroup.anchoredPosition = Vector3.down * 1000;

    }
}
