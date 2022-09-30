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
        // 범위 내에 충돌했는가
        if(player.transform.position.x >= transform.position.x-0.5 &&
            player.transform.position.x <= transform.position.x+0.5)   // 완전히 똑같게 하는 건 어려움(player.transform.position.x == transform.position.x)
        {
            // print("same");
            // 왼쪽으로 튕기기 (좌표 순간 이동)
            // player.transform.position = new Vector3(player.transform.position.x - 3, player.transform.position.y, player.transform.position.z);
            // 물리 엔진에 힘을 준다. (충격값 적용)
            // rb.AddForce(Vector3.left*5, ForceMode.VelocityChange);
            rb.AddForce(new Vector3(-8, 0, 0), ForceMode.VelocityChange);
        }
        // 범위 바깥을 감지하려면 if(player.transform.position.x <= transform.position.x-1 || player.transform.position.x >= transform.position.x + 1)*/

        
    }

    // Box Collider 사용 - 충돌했을 때 시그널 사용
    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = player.GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(-100, 0, 0), ForceMode.VelocityChange);   // Vector3.left * 100
    }
}
