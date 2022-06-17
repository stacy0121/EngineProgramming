using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyMovement : MonoBehaviour
{
    public static GameObject boss;
    public GameObject originalBoss;
    public static Vector3 playerPosition;

    public GameObject bullet;   // prefeb 사용
    GameObject cloneBullet;

    float rotationX;
    public static float speed = 0.01f;

    public static bool finish = false;   // 체력이 0이 되거나 적을 모두 죽였을 때 true
    bool spawn = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 몸의 회전
        float angle = transform.eulerAngles.y;   // 몸이 회전하는 값 중 y회전값만 추출

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.Translate(movement / 50);
        playerPosition = transform.position;

        float headX = Input.GetAxis("Mouse X");   // 마우스로 몸통 좌우로만 회전 (위아래 회전할 경우 기울어짐)
        //float headY = Input.GetAxis("Mouse Y");

        rotationX = rotationX + headX;     // 회전값 가중
        //rotationY = rotationY + headY;

        transform.eulerAngles = new Vector3(0.0f, rotationX, 0.0f);   // 플레이어 회전값

        // 화살 생성 위치
        Vector3 cloneArrow = new Vector3(Screen.width*6/8, Screen.height /2, 1f); // 현재 화면에서 화살이 생성될 위치 업데이트 (정가운데) *왼쪽 아래가 (0, 0)*
        Vector3 cloneArrowInUnity = Camera.main.ScreenToWorldPoint(cloneArrow);      // 화면 좌표를 유니티 위치값으로 변환 *정가운데가(0, 0). 크기도 다름*

        // 마우스 버튼을 눌렀다가 떼었을 때 화살 발사
        if (Input.GetMouseButtonUp(0) && Time.frameCount % 3 == 0)   // 화살 발사 딜레이
        {
            cloneBullet = Instantiate(bullet);   // 화살 prefeb에서 인스턴스화
            cloneBullet.transform.position = cloneArrowInUnity;   // 지정한 스폰 위치로 화살 옮김
            Vector3 screenPositon = new Vector3(Screen.width /2, Screen.height*3/5, 500f);   // 현재 화면에서 화살의 도착 위치
            Vector3 aimPosition = Camera.main.ScreenToWorldPoint(screenPositon);   // 화면 좌표를 유니티 좌표로 변경
            cloneBullet.GetComponent<Rigidbody>().AddForce(aimPosition * 5f);      // 위치*힘
       
            cloneBullet.transform.eulerAngles = new Vector3(0, angle+80, -head.rotationY-5);   // 플레이어가 회전하면 화살의 방향도 회전. headY?*****************************************************
        }

        // 서브몹을 다 처치하면 보스 등장
        if (enemyStamina_Text.stm1 == 0)
        {
            if(spawn != true)   // 한 번만 스폰
            {
                boss = Instantiate(originalBoss, new Vector3(0, 5.86f, 0), Quaternion.identity);
                spawn = true;
            }

            boss.transform.rotation = Quaternion.LookRotation(transform.position - boss.transform.position).normalized;
            boss.transform.position = Vector3.MoveTowards(boss.transform.position, transform.position, speed);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")   // 대포에 적이 부딪히면
        {
            playerStamina_Text.stm--;          // 대포 체력 닳게 하기

            if (playerStamina_Text.stm == 0)   // 만약 체력이 0이 되면
                finish = true;           // 게임 종료 (failed 보여주기)
        }
    }
}
