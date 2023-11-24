using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSystemScene : MonoBehaviour
{
    public string systemScene; // �̵��� Scene�� �̸��� �����ϱ� ���� ����

    // ��ư�� Ŭ���Ǿ��� �� ȣ��� �޼���
    public void System_BtnClick()
    {
        // targetSceneName�� ��ȿ�ϴٸ� �ش� Scene���� �̵�
        if (!string.IsNullOrEmpty(systemScene))
        {
            SceneManager.LoadScene(systemScene);
        }
        else
        {
            Debug.LogError("Target Scene Name is not set!");
        }
    }
}

