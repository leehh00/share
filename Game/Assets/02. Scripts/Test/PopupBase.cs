using UnityEngine;

public class PopupBase : MonoBehaviour
{
    private PopupType _popupType = PopupType.None;

    protected void SetPopupType(PopupType popupType)
    {
        _popupType = popupType;
    }

    public virtual void OnShow()
    {
        
    }

    public virtual void OnClose()
    {
        
    }

    public PopupType GetPopupType() => _popupType;
}
