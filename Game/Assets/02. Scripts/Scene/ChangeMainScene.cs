using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeMainScene : MonoBehaviour
{
    public string mainScene; // �̵��� Scene�� �̸��� �����ϱ� ���� ����

    // ��ư�� Ŭ���Ǿ��� �� ȣ��� �޼���
    public void Main_BtnClick()
    {
        // targetSceneName�� ��ȿ�ϴٸ� �ش� Scene���� �̵�
        if (!string.IsNullOrEmpty(mainScene))
        {
            SceneManager.LoadScene(mainScene);
        }
        else
        {
            Debug.LogError("Target Scene Name is not set!");
        }
    }
}

