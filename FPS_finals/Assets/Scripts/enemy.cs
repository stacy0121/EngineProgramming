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

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "arrow")   // ȭ���� ���� ������ ���� ���ְ� �ٸ� ��ġ�� �ڵ� ����
        {
            Debug.Log("Collision");
            bodyMovement.sub = Instantiate(gameObject, new Vector3(Random.Range(-50f, 50f), 4, Random.Range(-50f, 50f)), Quaternion.identity);
            bodyMovement.speed += 0.005f;   // �ӵ��� ���� ������
            Destroy(gameObject);

            stamina_Text.stm--;   // ü�� ����
        }
    }
}
