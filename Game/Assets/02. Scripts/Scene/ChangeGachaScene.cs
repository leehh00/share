using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeGachaScene : MonoBehaviour
{
    public string gachaScene; // �̵��� Scene�� �̸��� �����ϱ� ���� ����

    // ��ư�� Ŭ���Ǿ��� �� ȣ��� �޼���
    public void Gacha_BtnClick()
    {
        // targetSceneName�� ��ȿ�ϴٸ� �ش� Scene���� �̵�
        if (!string.IsNullOrEmpty(gachaScene))
        {
            SceneManager.LoadScene(gachaScene);
        }
        else
        {
            Debug.LogError("Target Scene Name is not set!");
        }
    }
}

