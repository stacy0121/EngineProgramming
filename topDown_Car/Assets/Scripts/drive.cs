using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drive : MonoBehaviour
{
    public Rigidbody2D rb2d;
    float xValue;
    float yValue;
    public float speed;
    public Camera camera;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        rb2d = GetComponent<Rigidbody2D>();
        yValue = Input.GetAxis("Vertical");
        xValue = Input.GetAxis("Horizontal");


        if (Input.GetKeyDown(KeyCode.LeftShift))   // 왼쪽 쉬프트키를 누르면 가속
        {
            speed = 7;
        }

        if (counter.count < 1)
            camera.transform.position = new Vector3(transform.position.x, transform.position.y+1.5f, -20);   // 카메라 위치
    }

    public void FixedUpdate()   // 물리엔진
    {
        //rb2d.velocity = new Vector2(0, yValue);    // 좌표 변경
        if (counter.count < 1)   // 시작하면 이동
        {
            rb2d.velocity = transform.up * yValue * speed;   // 자기자신 곱하기 up * 사용자 입력 방향 * 가속력
            transform.Rotate(0, 0, -1 * xValue * 1);

            camera.transform.Rotate(0, 0, -1 * xValue * 0.9f);    // 카메라 회전
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "wall")   // 충돌체(풀더미)에 부딪히면 충돌 수 증가
        {
            collision.scr += 1;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "coin")   // 코인을 먹으면 1점 추가
        {
            Object.Destroy(other.gameObject);
            score.scr += 1;
        }
    }
}
