using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeStoreScene : MonoBehaviour
{
    public string storeScene; // �̵��� Scene�� �̸��� �����ϱ� ���� ����

    // ��ư�� Ŭ���Ǿ��� �� ȣ��� �޼���
    public void Store_BtnClick()
    {
        // targetSceneName�� ��ȿ�ϴٸ� �ش� Scene���� �̵�
        if (!string.IsNullOrEmpty(storeScene))
        {
            SceneManager.LoadScene(storeScene);
        }
        else
        {
            Debug.LogError("Target Scene Name is not set!");
        }
    }
}

