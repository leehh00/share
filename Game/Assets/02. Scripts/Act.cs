using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Act : MonoBehaviour
{
    public GameObject develop;

    // ��ư�� �ؽ�Ʈ ������Ʈ�� ������ ����
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

    // ���ڸ� ������ ����
    int healthNumber = 0;
    int ideaNumber = 0;
    int experienceNumber = 0;
    int codingNumber = 0;
    int fameNumber = 0;

    private int turnNumber = 10; // Ŭ���� ������ �����ϰ� �ʱ�ȭ
    private int actionNumber = 0; // Ŭ���� ������ �����ϰ� �ʱ�ȭ
    private int caseCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        // ��ư�� Ŭ�� �̺�Ʈ �����ʸ� �߰��ϰ�, OnButtonClick �޼ҵ带 ȣ���ϵ��� ����
        // �̶�, OnButtonClick �޼ҵ忡 buttonType�� ���ڿ��� ����
        healthButton.onClick.AddListener(() => OnButtonClick("health"));
        ideaButton.onClick.AddListener(() => OnButtonClick("idea"));
        experiencebutton.onClick.AddListener(() => OnButtonClick("experience"));
        codingButton.onClick.AddListener(() => OnButtonClick("coding"));
        fameButton.onClick.AddListener(() => OnButtonClick("fame"));
    }

    void Update()
    {
        // actionNumber�� 3���� ���� �������� 0�̰�, actionNumber�� 0�� �ƴ� ������ �˻�
        if ((actionNumber % 3 == 0) && (actionNumber != 0))
        {
            // develop ������Ʈ�� Ȱ��ȭ
            develop.SetActive(true);
            healthButton.interactable = false;
            ideaButton.interactable = false;
            experiencebutton.interactable = false;
            codingButton.interactable = false;
            fameButton.interactable = false;
        }
    }

    // ��ư�� Ŭ������ �� ������ �޼ҵ�
    // �Ű������� buttonType�̶�� ���ڿ��� ����
    void OnButtonClick(string buttonType)
    {
        // �������� 1 �Ǵ� 2�� ����
        int random = Random.Range(1, 3);

        // buttonType�� "health", "idea", "experience", "coding", "fame" �� �ϳ����� �˻�
        // buttonType�� ����, healthNumber, ideaNumber, experienceNumber, codingNumber, fameNumber �� �ϳ��� ������ ���ڷ� ������Ŵ
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

        // pp �پ��
        turnNumber--;

        // caseCount�� 3���� ������ ����������
        if ((caseCount % 3 == 0) && (caseCount != 0))
        {
            // actionNumber�� 1�� ����
            actionNumber++;
        }



        // �ؽ�Ʈ�� ���ڸ� ǥ����
        healthStatusText.text = healthNumber.ToString();
        ideaStatusText.text = ideaNumber.ToString();
        experienceStatusText.text = experienceNumber.ToString();
        codingStatusText.text = codingNumber.ToString();
        fameStatusText.text = fameNumber.ToString();
        turnText.text = turnNumber.ToString();
        actionText.text = actionNumber.ToString();

    }
}
