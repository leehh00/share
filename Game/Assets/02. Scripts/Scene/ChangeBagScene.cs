using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeBagScene : MonoBehaviour
{
    public string bagScene; // �̵��� Scene�� �̸��� �����ϱ� ���� ����

    // ��ư�� Ŭ���Ǿ��� �� ȣ��� �޼���
    public void Bag_BtnClick()
    {
        // targetSceneName�� ��ȿ�ϴٸ� �ش� Scene���� �̵�
        if (!string.IsNullOrEmpty(bagScene))
        {
            SceneManager.LoadScene(bagScene);
        }
        else
        {
            Debug.LogError("Target Scene Name is not set!");
        }
    }
}

