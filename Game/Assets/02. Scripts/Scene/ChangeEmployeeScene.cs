using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeEmployeeScene : MonoBehaviour
{
    public string employeeScene; // 이동할 Scene의 이름을 설정하기 위한 변수

    // 버튼이 클릭되었을 때 호출될 메서드
    public void Employee_BtnClick()
    {
        // targetSceneName이 유효하다면 해당 Scene으로 이동
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

