using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canonMovement : MonoBehaviour
{
    public static float angle;
    Vector2 target;
    public static Vector3 objPosition;
    public GameObject bullet;
    public GameObject enemyMove;
    public static GameObject cloneEnemy;

    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
        cloneEnemy = Instantiate(enemyMove, new Vector3(9.42f, 0, 0), Quaternion.identity);   // 시작할 때 적 생성
    }

    // Update is called once per frame
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
            Debug.Log("bulletAngle");
        }

        cloneEnemy.transform.position = Vector3.MoveTowards(cloneEnemy.transform.position, new Vector3(0, 0, 0), 0.01f);   //적이 대포로 접근
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")   // 대포가 적과 부딪히면
        {
            Debug.Log("DEAD"); //디버그창에 글씨... 이안에 다른것을 넣어 끝난 것을 알려주셔도 좋겠죠?!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        }
    }
}
