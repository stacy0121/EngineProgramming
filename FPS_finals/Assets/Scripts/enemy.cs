using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private Transform player = bodyMovement.playerTransform;   // �÷��̾� ��ġ

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ������ ������ �ٰ����� ������� ������ (���� ����)
        float distance = Vector3.Distance(player.transform.position, transform.position);   // ����******************************
        if (distance < 5.0f)
        {
            transform.rotation = Quaternion.LookRotation(player.transform.position - transform.position).normalized;
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 0.01f);
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
