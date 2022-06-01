using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canonMovement : MonoBehaviour
{
    public static float angle;
    Vector2 target;
    public static Vector3 objPosition;
    public GameObject bullet;      // 총알 Prefeb
    public GameObject enemyMove;   // 적 Prefeb
    public static GameObject cloneEnemy;

    public static bool finish;   // 체력이 0이 되거나 적을 모두 죽였을 때 true

    void Start()
    {
        target = transform.position;
        cloneEnemy = Instantiate(enemyMove, new Vector3(9.42f, 0, 0), Quaternion.identity);   // 시작할 때 적 생성
        finish = false;
    }

    void Update()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5);   // 마우스는 vector2
        objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // 마우스를 따라가는 대포
        angle = Mathf.Atan2(objPosition.y - target.y, objPosition.x - target.x) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);

        // 하나씩 생성되고 발사
        if (Input.GetMouseButtonUp(0))
        {
            GameObject cloneBullet = Instantiate(bullet, new Vector3(0, 0, 0), Quaternion.identity);   // 총알 인스턴스 생성(재장전)
            cloneBullet.GetComponent<Rigidbody2D>().AddForce(objPosition * 50);
            cloneBullet.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);   // 총알 방향을 마우스 방향(대포 방향)으로 설정
        }

        cloneEnemy.transform.position = Vector3.MoveTowards(cloneEnemy.transform.position, new Vector3(0, 0, 0), 0.02f);   //적이 대포로 접근
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")   // 대포에 적이 부딪히면
        {
            stamina_Text.stm--;          // 대포 체력 닳게 하기
            Debug.Log("stm--");

            if (stamina_Text.stm == 0)   // 만약 체력이 0이 되면
                finish = true;           // 게임 종료 (failed 보여주기)
        }
    }
}
