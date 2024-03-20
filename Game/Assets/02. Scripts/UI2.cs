using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI2 : MonoBehaviour
{
    public GameObject prefab;
    Vector2 createPoint;
    // Start is called before the first frame update
    public void Button_Clicked()
    {
        Instantiate(prefab, createPoint, Quaternion.identity, GameObject.Find("Main Canvas").transform);
    }

    public void ExitButton_Clicked()
    {
        Destroy(prefab);
    }

    
}
