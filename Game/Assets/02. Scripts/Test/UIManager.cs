using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// 싱글톤으로 교체해야함.
public class UIManager : MonoBehaviour
{
    private Dictionary<PopupType, string> popupResourceMap = new Dictionary<PopupType, string>();
    private Stack<PopupBase> popupStack = new Stack<PopupBase>();
    private PopupType currentPopup = PopupType.None;

    private void Awake()
    {
        popupResourceMap.Add(PopupType.Profile, "Prefabs/UI/Act"); // dictionary의 value값은 띄울 UI 팝업 프리팹의 주소인데 Rosources 폴더 이하 주소를 적습니다. 쉽게 하려면  프리팹 우클릭하고 copy path 하고 필요없는부분 지워요
        // popupResourceMap.Add(PopupType.Profile, "Prefabs/profilePopup"); // dictionary의 value값은 띄울 UI 팝업 프리팹의 주소인데 Rosources 폴더 이하 주소를 적습니다. 쉽게 하려면  프리팹 우클릭하고 copy path 하고 필요없는부분 지워요
        // popupResourceMap.Add(PopupType.Profile, "Prefabs/profilePopup"); // dictionary의 value값은 띄울 UI 팝업 프리팹의 주소인데 Rosources 폴더 이하 주소를 적습니다. 쉽게 하려면  프리팹 우클릭하고 copy path 하고 필요없는부분 지워요
        // popupResourceMap.Add(PopupType.Profile, "Prefabs/profilePopup"); // dictionary의 value값은 띄울 UI 팝업 프리팹의 주소인데 Rosources 폴더 이하 주소를 적습니다. 쉽게 하려면  프리팹 우클릭하고 copy path 하고 필요없는부분 지워요
        // popupResourceMap.Add(PopupType.Profile, "Prefabs/profilePopup"); // dictionary의 value값은 띄울 UI 팝업 프리팹의 주소인데 Rosources 폴더 이하 주소를 적습니다. 쉽게 하려면  프리팹 우클릭하고 copy path 하고 필요없는부분 지워요
        // popupResourceMap.Add(PopupType.Profile, "Prefabs/profilePopup"); // dictionary의 value값은 띄울 UI 팝업 프리팹의 주소인데 Rosources 폴더 이하 주소를 적습니다. 쉽게 하려면  프리팹 우클릭하고 copy path 하고 필요없는부분 지워요
        //이렇게 모든 팝업 추가.,
    }

    public void OpenPopup<T>(PopupType popupType) where T : PopupBase
    {
        if (popupStack.FirstOrDefault(x => x.GetType() == typeof(T)))
        {
            Debug.LogError($"Already exist type. type is {typeof(T)}");
        }
        
        if (false == popupResourceMap.ContainsKey(popupType))
        {
            Debug.LogError($"popupResourceMap dosent have key. key is {popupType}");
            return;
        }

        var prefab = Resources.Load(popupResourceMap[popupType]);
        var rawInstance =  Instantiate(prefab) as GameObject;
        T popup = rawInstance.GetComponent<T>();
        if (popup == null)
        {
            Debug.LogError($"Popup Scrip is null. type is {typeof(T)}");
            return;
        }
        
        popupStack.Push(popup);
        popup.OnShow();
        
        currentPopup = popup.GetPopupType();
    }
    
    public void ClosePopup()
    {
        if(!popupStack.Any()) return;
        var popup = popupStack.Pop();
        popup.OnClose();

        currentPopup = popupStack.TryPeek(out var result) ? result.GetPopupType() : PopupType.None;
    }

    public void CloseAllPopup()
    {
        var enumerator = popupStack.GetEnumerator();
        while (enumerator.MoveNext())
        {
            ClosePopup();
        }
    }
}
