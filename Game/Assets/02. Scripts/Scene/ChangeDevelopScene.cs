using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeDevelopScene : MonoBehaviour
{
    public string developScene; // �̵��� Scene�� �̸��� �����ϱ� ���� ����

    // ��ư�� Ŭ���Ǿ��� �� ȣ��� �޼���
    public void Develop_BtnClick()
    {
        // targetSceneName�� ��ȿ�ϴٸ� �ش� Scene���� �̵�
        if (!string.IsNullOrEmpty(developScene))
        {
            SceneManager.LoadScene(developScene);
        }
        else
        {
            Debug.LogError("Target Scene Name is not set!");
        }
    }
}

