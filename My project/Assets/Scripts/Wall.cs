using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*Rigidbody rb = player.GetComponent<Rigidbody>();

        // print("player x : " + player.transform.position.x);
        // ���� ���� �浹�ߴ°�
        if(player.transform.position.x >= transform.position.x-0.5 &&
            player.transform.position.x <= transform.position.x+0.5)   // ������ �Ȱ��� �ϴ� �� �����(player.transform.position.x == transform.position.x)
        {
            // print("same");
            // �������� ƨ��� (��ǥ ���� �̵�)
            // player.transform.position = new Vector3(player.transform.position.x - 3, player.transform.position.y, player.transform.position.z);
            // ���� ������ ���� �ش�. (��ݰ� ����)
            // rb.AddForce(Vector3.left*5, ForceMode.VelocityChange);
            rb.AddForce(new Vector3(-8, 0, 0), ForceMode.VelocityChange);
        }
        // ���� �ٱ��� �����Ϸ��� if(player.transform.position.x <= transform.position.x-1 || player.transform.position.x >= transform.position.x + 1)*/

        
    }

    // Box Collider ��� - �浹���� �� �ñ׳� ���
    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = player.GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(-100, 0, 0), ForceMode.VelocityChange);   // Vector3.left * 100
    }
}
