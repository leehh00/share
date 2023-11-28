using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeEmployeeScene : MonoBehaviour
{
    public string employeeScene; // �̵��� Scene�� �̸��� �����ϱ� ���� ����

    // ��ư�� Ŭ���Ǿ��� �� ȣ��� �޼���
    public void Employee_BtnClick()
    {
        // targetSceneName�� ��ȿ�ϴٸ� �ش� Scene���� �̵�
        if (!string.IsNullOrEmpty(employeeScene))
        {
            SceneManager.LoadScene(employeeScene);
        }
        else
        {
            Debug.LogError("Target Scene Name is not set!");
        }
    }
}

