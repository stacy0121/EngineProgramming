using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private bool IsJumping;
    private GameObject fallingLand;
    public static bool finish;

    // Start is called before the first frame update
    void Start()
    {
        IsJumping = false;
        fallingLand = GameObject.FindGameObjectWithTag("fallingLand");
        finish = false;   // 게임 끝 여부 확인
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //transform.Translate(movement / 15);
        GetComponent<Rigidbody>().AddForce(movement*8);

        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (!IsJumping)
            {
                IsJumping = true;
                GetComponent<Rigidbody>().AddForce(Vector3.up * 10.0f, ForceMode.Impulse);   // Impulse - 질량의 영향을 받으면서 힘을 가하는 옵션
            }

            else
                return;
        }        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Land"))
            IsJumping = false;

        if (collision.gameObject.tag.Equals("obstacle"))
        {
            textControl.po -= 1;   // 층돌시 text에서 충돌 횟수로 만든 변수 po를 textControl.cs에서 불러와서 계산
            Object.Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("fallingLand"))   // 땅에 닿으면 떨어뜨리기
        {
            collision.gameObject.GetComponent<Rigidbody>().useGravity = true;
            Object.Destroy(collision.gameObject, 5);
        }

        if (collision.gameObject.CompareTag("enemy"))   // 적에게 닿으면 1점 감점
        {
            textControl.po -= 1;
        }

        if (collision.gameObject.CompareTag("finish"))   // 끝 지점에 닿으면 게임 끝
        {
            finish = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // 코인을 먹으면 코인이 사라지고 점수가 1점 올라감
        if (other.gameObject.tag == "coin")   // IsTrigger 체크
        {
            Object.Destroy(other.gameObject);
            textControl.po += 1;

        }
    }
}
