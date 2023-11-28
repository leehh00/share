using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeActScene : MonoBehaviour
{
    public string Actcene; // �̵��� Scene�� �̸��� �����ϱ� ���� ����

    // ��ư�� Ŭ���Ǿ��� �� ȣ��� �޼���
    public void Act_BtnClick()
    {
        // targetSceneName�� ��ȿ�ϴٸ� �ش� Scene���� �̵�
        if (!string.IsNullOrEmpty(Actcene))
        {
            SceneManager.LoadScene(Actcene);
        }
        else
        {
            Debug.LogError("Target Scene Name is not set!");
        }
    }
}
