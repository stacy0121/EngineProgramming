using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour    // ctrl 클릭 -> 원형 소스 보기
{
    // Start is called before the first frame update
    // 카메라를 GameObject처럼. Main Camera에 연결. 전역변수로 선언
    public GameObject camera;
    public Rigidbody rb;
    public ConstantForce cf;   // player의 힘(중력)만 바꾸기
    float current_y = 0;
    float current_angle = 0;

    // 힙 영역
    void Start()
    {
        // 큐 영역
    }

    // Update is called once per frame
    void Update()   // 초당 60번 호출
    {

        // jump
        if (Input.GetKeyDown(KeyCode.Space))   // 클릭(외부 입력 - Input)했을 때 한 번
        {
            //transform.position = new Vector3(transform.position.x, 5, transform.position.y);   // transform은 component가 아님(GetComponent 안 됨)   좌표 만들기
            rb.AddForce(Vector3.up * 7, ForceMode.VelocityChange);   // up이 static 메소드. y방향으로 1만큼 (0, 1, 0)
        }

        /*if (rb.velocity.y != 0)
            print("velocity" + rb.velocity.y);*/

        // right
        /*if (Input.GetKey(KeyCode.D))   // 누르고 있을 때 오른쪽으로
        {
            //rb.AddForce(Vector3.right, ForceMode.VelocityChange);   // 가속도가 붙음
            rb.velocity = new Vector3(3, rb.velocity.y, 0);   // 양수면 오른쪽?
        }*/

        int speed = 3;
        // shift키 달리기
        if (Input.GetKey(KeyCode.LeftShift))
            speed = 10;

        // left&right    
        // rb.velocity = new Vector3(Input.GetAxis("Horizontal")*speed, rb.velocity.y, rb.velocity.z);
        // 3인칭 앞뒤
        rb.velocity = new Vector3(Input.GetAxis("Vertical") * speed, rb.velocity.y, 0);


        // Player에 따른 카메라 좌표 변경 (현재 객체-Player 위치값에서 z값만 변경)
        // 땅 위나 아래에 따른 시점 변경
        int camera_angle = 4;
        int camera_angle_value = 0;
        float gap = 0.1f;

        // 땅 위에 있을 때
        if (transform.position.y > 0)
        {
            // 카메라 위치를 camera_angle 높이까지 +0.1만큼 움직임 (애니메이션처럼)
            if (current_y < camera_angle)
                current_y += gap;

            if (current_angle < camera_angle_value)
                current_angle += gap;
        }
        else
        {   // 땅 밑에 있을 때
            camera_angle = -5;   // 카메라 y축 높이 최소값
            camera_angle_value = -10;   // x축 각도 최소값

            if (current_y > camera_angle)
                current_y -= gap;

            if (current_angle > camera_angle_value)
                current_angle -= gap;
            
        }

        // 대각선으로 내려보기 (고정)
        camera.transform.rotation = Quaternion.Euler(current_angle, 90, 0);   // 360도 단위로 계산(오일러 공식). 원래는 -1~1
        // camera.transform.Rotate(camera_angle_value, 0, 0);   // 누적 회전

        // camera.transform.position = new Vector3(this.transform.position.x, transform.position.y, transform.position.z - 10);   // 횡 스크롤
        camera.transform.position = new Vector3(this.transform.position.x - 10, transform.position.y + current_y, transform.position.z);   // 3인칭
        // getter, setter 메소드(ex. Vector3.right, zero)는 메모리 공간이 필요없음
        

        // 중력 방향 바꾸기
        // 땅 밑으로 떨어지고 있는가 (한 번 일어나는 상황)
        if (transform.position.y < -3 && cf.force.y < 0)   // 기준점
        {
            cf.force = new Vector3(0, 30, 0);
        }  // 땅 위로 올라가고 있는가
        else if (transform.position.y > 2 && cf.force.y > 0)
        {
            cf.force = new Vector3(0, -3, 0);
        }

        // 발판 점프
        // 이단 점프
        
    }
}


