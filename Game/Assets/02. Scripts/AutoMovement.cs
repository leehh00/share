using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMovement : MonoBehaviour
{
    public float speed = 5f;
    public float changeDirectionInterval = 2f; // 이동 방향을 변경하는 주기
    public float raycastDistance = 1f; // 레이캐스트 거리
    public float maxGroundDistance = 0.5f; // 캐릭터가 땅에 닿아 있는지 확인할 최대 거리

    private float timer = 0f;
    private Rigidbody rb;

    void Start()
    {
        // Rigidbody 컴포넌트를 가져옵니다.
        rb = GetComponent<Rigidbody>();

        // 중력을 활성화합니다.
        rb.useGravity = true;
    }

    void Update()
    {
        // 타이머를 업데이트합니다.
        timer += Time.deltaTime;

        // 주기마다 새로운 방향으로 이동합니다.
        if (timer >= changeDirectionInterval)
        {
            ChangeDirection();
            timer = 0f;
        }

        // 현재 방향으로 이동합니다.
        Move();
    }

    void Move()
    {
        // 현재 위치를 가져옵니다.
        Vector3 currentPosition = transform.position;

        // Rigidbody를 통해 이동합니다.
        rb.velocity = transform.forward * speed;

        // 만약 레이캐스트를 통해 앞에 장애물이 있다면 방향을 변경합니다.
        if (CheckObstacle())
        {
            ChangeDirection();
        }
    }

    void ChangeDirection()
    {
        // 무작위로 새로운 방향을 선택합니다.
        Vector3 randomDirection = GetRandomDirection();

        // 선택한 방향으로 회전합니다.
        transform.rotation = Quaternion.LookRotation(randomDirection);
    }

    Vector3 GetRandomDirection()
    {
        // 무작위로 새로운 방향을 선택합니다.
        return new Vector3(Random.Range(-1f, 1f), 0f, Random.Range(-1f, 1f)).normalized;
    }

    bool CheckObstacle()
    {
        // 캐릭터 현재 위치에서 앞으로 레이캐스트를 발사합니다.
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        // 만약 앞에 무언가에 부딪힌다면 true 반환
        if (Physics.Raycast(ray, out hit, raycastDistance))
        {
            // 충돌한 지점에서 무작위로 새로운 방향을 선택합니다.
            Vector3 newDirection = GetRandomDirection();

            // 만약 선택한 방향이 충돌 지점의 법선과 같다면 90도 회전시킵니다.
            if (Vector3.Dot(newDirection, hit.normal) > 0.9f)
            {
                newDirection = Quaternion.AngleAxis(90f, Vector3.up) * newDirection;
            }

            // 방향만 변경합니다. 위치 변경은 Move 함수에서 처리되어야 합니다.
            transform.rotation = Quaternion.LookRotation(newDirection);

            // 충돌 지점을 벗어나기 위해 true 반환
            return true;
        }

        return false;
    }
}