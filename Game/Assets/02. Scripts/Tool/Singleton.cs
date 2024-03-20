using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance; 
    public static T Instance { get { return _instance; } }
    void Awake()
    {
        if (_instance != null)
        {
            // 따라서 씬에 단일에 게임 오브젝트만 남도록 삭제한다.            
            Destroy(gameObject);
            return;
        }
        // 인스턴스를 할당한다.        
        _instance = GetComponent<T>();
        // 씬이 전환될 때에도 파괴가 되지 않도록 한다.      

        DontDestroyOnLoad(gameObject);
    }
}
