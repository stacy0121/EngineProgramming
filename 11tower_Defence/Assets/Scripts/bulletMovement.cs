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

        //this.transform.rotation = Quaternion.AngleAxis(canonMovement.angle, Vector3.forward);   // 대포 방향대로 총알 방향 설정
    }
    void OnBecameInvisible()   // 화면에서 벗어나면 오브젝트 제거
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision) //충돌감지
    {
        Debug.Log("GET");
        if (collision.gameObject.tag == "enemy") //만약에 적과 총알이 충돌하면
        {
            Debug.Log("COLLISION");
            Destroy(gameObject);   // 총알 없애기
        }
    }
}
