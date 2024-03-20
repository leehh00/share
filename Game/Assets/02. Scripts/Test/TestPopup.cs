using UnityEngine;

public class TestPopup : PopupBase
{
    private void Awake()
    {
        SetPopupType(PopupType.Profile);
    }

    public override void OnShow()
    {
        Debug.Log($"{GetType().Name} Popup is Open");
    }

    public override void OnClose()
    {
        Debug.Log($"{GetType().Name} Popup is Closed");
    }
}
