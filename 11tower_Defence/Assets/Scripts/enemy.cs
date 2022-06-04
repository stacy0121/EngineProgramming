using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private int count;   // 적의 개수
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)  // 충돌여부
    {
        if (collision.gameObject.tag == "bullet")   // 총알과 부딪히면
        {
            if(canonMovement.finish == false)   // 게임 종료가 아닐 때
            {
                // 랜덤 확률로 여러 위치에서 적 생성
                if (Random.Range(0, 100) < 40)
                    canonMovement.cloneEnemy = Instantiate(gameObject, new Vector3(13.77f, 0, 0), Quaternion.identity);
                else if (Random.Range(0, 100) < 50)
                {
                    canonMovement.cloneEnemy = Instantiate(gameObject, new Vector3(9.77f, 5.7f, 0), Quaternion.identity);
                    canonMovement.cloneEnemy.transform.rotation = Quaternion.AngleAxis(31.468f, Vector3.forward);
                }
                else if (Random.Range(0, 100) < 60)
                {
                    canonMovement.cloneEnemy = Instantiate(gameObject, new Vector3(8.23f, -6.08f, 0), Quaternion.identity);
                    canonMovement.cloneEnemy.transform.rotation = Quaternion.AngleAxis(-41.283f, Vector3.forward);
                }
                else
                {
                    canonMovement.cloneEnemy = Instantiate(gameObject, new Vector3(-13.75f, 1.52f, 0), Quaternion.identity);
                    canonMovement.cloneEnemy.transform.rotation = Quaternion.AngleAxis(-188.47f, Vector3.forward);
                }
            }
            Destroy(gameObject);   // 부딪힌 나(적)은 삭제
            // 게임이 종료되면 더이상 적을 생성하지 않는다.
        }
    }
}
