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
            bodyMovement.sub = Instantiate(gameObject, new Vector3(Random.Range(-100f, 100f), 10, Random.Range(-100f, 100f)), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
