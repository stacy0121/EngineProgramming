using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "arrow")   // ȭ���� ���� ������ ���� ���ְ� �ٸ� ��ġ�� �ڵ� ����
        {
            if (bodyMovement.finish == false)   // ���� ���ᰡ �ƴ� ��
            {
                Debug.Log("Collision");
                bodyMovement.boss = Instantiate(gameObject, new Vector3(Random.Range(-40f, 40f), 4, Random.Range(-40f, 40f)), Quaternion.identity);
                bodyMovement.speed += 0.005f;   // �ӵ��� ���� ������
            }
            Destroy(gameObject);
            enemyStamina_Text.stm2--;   // ü�� ����
        }
    }
}
