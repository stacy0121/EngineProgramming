using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    float rotationX;
    public static float distance;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // ���� �ٶ󺸴� ��
        float headX = Input.GetAxis("Mouse X");
        rotationX = rotationX + headX;
        transform.eulerAngles = new Vector3(-90, rotationX + 180, 0.0f);

        // ������ ������ �ٰ����� ������� ������ (���� ����)
        distance = Vector3.Distance(bodyMovement.playerPosition, transform.position);
        Debug.Log("distance: " + distance);

        if (distance <= 15.0f)   // ������ �Ÿ��� 15 ������ ��
        {
            transform.position = Vector3.MoveTowards(transform.position, bodyMovement.playerPosition, 0.01f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "arrow")   // ȭ���� ���� ������ ���� ���ְ� �ٸ� ��ġ�� �ڵ� ����
        {
            enemyStamina_Text.stm1--;   // ü�� ����
            if (enemyStamina_Text.stm1 == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
