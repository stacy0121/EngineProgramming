using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour
{
    //Rigidbody2D rb2D;
    //bool fire;

    // Start is called before the first frame update
    void Start()
    {
        //rb2D = GetComponent<Rigidbody2D>();
        //fire = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0)&&fire==false)
        //{
        //    fire = true;
        //    rb2D.AddForce(canonMovement.objPosition * 20);
        //}

        //this.transform.rotation = Quaternion.AngleAxis(canonMovement.angle, Vector3.forward);   // ���� ������ �Ѿ� ���� ����
    }
    void OnBecameInvisible()   // ȭ�鿡�� ����� ������Ʈ ����
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision) //�浹����
    {
        Debug.Log("GET");
        if (collision.gameObject.tag == "enemy") //���࿡ ���� �Ѿ��� �浹�ϸ�
        {
            Debug.Log("COLLISION");
            Destroy(gameObject);   // �Ѿ� ���ֱ�
        }
    }
}
