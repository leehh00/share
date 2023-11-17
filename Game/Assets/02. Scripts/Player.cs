using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    float hAxis;
    float vAxis;

    

    Vector3 moveVec;

    GameObject nearObject;
    

    void Start()
    {
        
    }
    void Update()
    {
        Move();
        //Interaction(); // NPC ·ÎÁ÷
    }

    void Move()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");

        moveVec = new Vector3(hAxis, 0, vAxis).normalized;

        transform.position += moveVec * moveSpeed * Time.deltaTime;

        transform.LookAt(transform.position + moveVec);
    }
    
}
