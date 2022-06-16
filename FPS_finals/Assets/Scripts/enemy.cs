using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // ������ ������ �ٰ����� ������� ������ (���� ����)
        float distance = Vector3.Distance(bodyMovement.playerPosition, transform.position);
        Debug.Log("distance: " + distance);
        transform.rotation = Quaternion.LookRotation(bodyMovement.playerPosition - transform.position).normalized;   //*******************************************     
        if (distance <= 6.0f)
        {
            transform.position = Vector3.MoveTowards(transform.position, bodyMovement.playerPosition, 0.01f);
            //Debug.Log(Vector3.Distance(bodyMovement.playerTransform.transform.position, transform.position));
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "arrow")   // ȭ���� ���� ������ ���� ���ְ� �ٸ� ��ġ�� �ڵ� ����
        {
            enemyStamina_Text.stm2--;   // ü�� ����
        }
    }
}
