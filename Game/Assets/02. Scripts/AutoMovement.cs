using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMovement : MonoBehaviour
{
    public float speed = 5f;
    public float changeDirectionInterval = 2f; // �̵� ������ �����ϴ� �ֱ�
    public float raycastDistance = 1f; // ����ĳ��Ʈ �Ÿ�
    public float maxGroundDistance = 0.5f; // ĳ���Ͱ� ���� ��� �ִ��� Ȯ���� �ִ� �Ÿ�

    private float timer = 0f;
    private Rigidbody rb;

    void Start()
    {
        // Rigidbody ������Ʈ�� �����ɴϴ�.
        rb = GetComponent<Rigidbody>();

        // �߷��� Ȱ��ȭ�մϴ�.
        rb.useGravity = true;
    }

    void Update()
    {
        // Ÿ�̸Ӹ� ������Ʈ�մϴ�.
        timer += Time.deltaTime;

        // �ֱ⸶�� ���ο� �������� �̵��մϴ�.
        if (timer >= changeDirectionInterval)
        {
            ChangeDirection();
            timer = 0f;
        }

        // ���� �������� �̵��մϴ�.
        Move();
    }

    void Move()
    {
        // ���� ��ġ�� �����ɴϴ�.
        Vector3 currentPosition = transform.position;

        // Rigidbody�� ���� �̵��մϴ�.
        rb.velocity = transform.forward * speed;

        // ���� ����ĳ��Ʈ�� ���� �տ� ��ֹ��� �ִٸ� ������ �����մϴ�.
        if (CheckObstacle())
        {
            ChangeDirection();
        }
    }

    void ChangeDirection()
    {
        // �������� ���ο� ������ �����մϴ�.
        Vector3 randomDirection = GetRandomDirection();

        // ������ �������� ȸ���մϴ�.
        transform.rotation = Quaternion.LookRotation(randomDirection);
    }

    Vector3 GetRandomDirection()
    {
        // �������� ���ο� ������ �����մϴ�.
        return new Vector3(Random.Range(-1f, 1f), 0f, Random.Range(-1f, 1f)).normalized;
    }

    bool CheckObstacle()
    {
        // ĳ���� ���� ��ġ���� ������ ����ĳ��Ʈ�� �߻��մϴ�.
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        // ���� �տ� ���𰡿� �ε����ٸ� true ��ȯ
        if (Physics.Raycast(ray, out hit, raycastDistance))
        {
            // �浹�� �������� �������� ���ο� ������ �����մϴ�.
            Vector3 newDirection = GetRandomDirection();

            // ���� ������ ������ �浹 ������ ������ ���ٸ� 90�� ȸ����ŵ�ϴ�.
            if (Vector3.Dot(newDirection, hit.normal) > 0.9f)
            {
                newDirection = Quaternion.AngleAxis(90f, Vector3.up) * newDirection;
            }

            // ���⸸ �����մϴ�. ��ġ ������ Move �Լ����� ó���Ǿ�� �մϴ�.
            transform.rotation = Quaternion.LookRotation(newDirection);

            // �浹 ������ ����� ���� true ��ȯ
            return true;
        }

        return false;
    }
}