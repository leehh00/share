using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
// ī�޶� �÷��̾� ����ٴ�
    public Transform target;
    public Vector3 offset;

    void Update()
    {
        transform.position = target.position + offset;
    }
}
