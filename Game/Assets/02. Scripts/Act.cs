using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Act : MonoBehaviour
{
    public GameObject develop;

    // 버튼과 텍스트 오브젝트를 연결할 변수
    public Button healthButton;
    public Button ideaButton;
    public Button experiencebutton;
    public Button codingButton;
    public Button fameButton;

    public Text healthStatusText;
    public Text ideaStatusText;
    public Text experienceStatusText;
    public Text codingStatusText;
    public Text fameStatusText;

    public Text turnText;
    public Text actionText;

    // 숫자를 저장할 변수
    int healthNumber = 0;
    int ideaNumber = 0;
    int experienceNumber = 0;
    int codingNumber = 0;
    int fameNumber = 0;

    private int turnNumber = 10; // 클래스 레벨에 선언하고 초기화
    private int actionNumber = 0; // 클래스 레벨에 선언하고 초기화
    private int caseCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        // 버튼에 클릭 이벤트 리스너를 추가하고, OnButtonClick 메소드를 호출하도록 설정
        // 이때, OnButtonClick 메소드에 buttonType을 문자열로 전달
        healthButton.onClick.AddListener(() => OnButtonClick("health"));
        ideaButton.onClick.AddListener(() => OnButtonClick("idea"));
        experiencebutton.onClick.AddListener(() => OnButtonClick("experience"));
        codingButton.onClick.AddListener(() => OnButtonClick("coding"));
        fameButton.onClick.AddListener(() => OnButtonClick("fame"));
    }

    void Update()
    {
        // actionNumber를 3으로 나눈 나머지가 0이고, actionNumber가 0이 아닌 조건을 검사
        if ((actionNumber % 3 == 0) && (actionNumber != 0))
        {
            // develop 오브젝트를 활성화
            develop.SetActive(true);
            healthButton.interactable = false;
            ideaButton.interactable = false;
            experiencebutton.interactable = false;
            codingButton.interactable = false;
            fameButton.interactable = false;
        }
    }

    // 버튼을 클릭했을 때 실행할 메소드
    // 매개변수로 buttonType이라는 문자열을 받음
    void OnButtonClick(string buttonType)
    {
        // 랜덤으로 1 또는 2를 생성
        int random = Random.Range(1, 3);

        // buttonType이 "health", "idea", "experience", "coding", "fame" 중 하나인지 검사
        // buttonType에 따라서, healthNumber, ideaNumber, experienceNumber, codingNumber, fameNumber 중 하나를 랜덤한 숫자로 증가시킴
        switch (buttonType)
        {
            case "health":
                healthNumber += random;
                caseCount++;
                break;
            case "idea":
                ideaNumber += random;
                caseCount++;
                break;
            case "experience":
                experienceNumber += random;
                caseCount++;
                break;
            case "coding":
                codingNumber += random;
                caseCount++;
                break;
            case "fame":
                fameNumber += random;
                caseCount++;
                break;
            default:
                break;
        }

        // pp 줄어듦
        turnNumber--;

        // caseCount가 3으로 나누어 떨어지는지
        if ((caseCount % 3 == 0) && (caseCount != 0))
        {
            // actionNumber를 1씩 증가
            actionNumber++;
        }



        // 텍스트에 숫자를 표시함
        healthStatusText.text = healthNumber.ToString();
        ideaStatusText.text = ideaNumber.ToString();
        experienceStatusText.text = experienceNumber.ToString();
        codingStatusText.text = codingNumber.ToString();
        fameStatusText.text = fameNumber.ToString();
        turnText.text = turnNumber.ToString();
        actionText.text = actionNumber.ToString();

    }
}
