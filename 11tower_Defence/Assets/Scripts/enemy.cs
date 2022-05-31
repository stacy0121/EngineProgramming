using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)  // 충돌여부
    {
        if (collision.gameObject.tag == "bullet")   // 총알과 부딪히면
        {
            // 랜덤 확률로 여러 위치에서 적 생성
            if (Random.Range(0, 100) < 40)
                canonMovement.cloneEnemy = Instantiate(gameObject, new Vector3(9.42f, 0, 0), Quaternion.identity);
            else if (Random.Range(0, 100) < 50)
            {
                canonMovement.cloneEnemy = Instantiate(gameObject, new Vector3(8.89f, 5.6f, 0), Quaternion.identity);
                canonMovement.cloneEnemy.transform.rotation = Quaternion.AngleAxis(53.754f, Vector3.forward);
            }
            else if (Random.Range(0, 100) < 60)
            {
                canonMovement.cloneEnemy = Instantiate(gameObject, new Vector3(7.7f, -6.1f, 0), Quaternion.identity);
                canonMovement.cloneEnemy.transform.rotation = Quaternion.AngleAxis(-41.876f, Vector3.forward);
            }
            else if (Random.Range(0, 100) < 70)
            {
                canonMovement.cloneEnemy = Instantiate(gameObject, new Vector3(-10.29f, 0.66f, 0), Quaternion.identity);
                canonMovement.cloneEnemy.transform.rotation = Quaternion.AngleAxis(161.499f, Vector3.forward);
            }
            Destroy(gameObject);   // 부딪힌 적은 삭제
        }
    }
}
