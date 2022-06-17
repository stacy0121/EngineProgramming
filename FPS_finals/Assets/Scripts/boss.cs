using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "arrow")   // 화살이 적에 닿으면 적을 없애고 다른 위치에 자동 생성
        {
            if (bodyMovement.finish == false)   // 게임 종료가 아닐 때
            {
                Debug.Log("Collision");
                bodyMovement.boss = Instantiate(gameObject, new Vector3(Random.Range(-40f, 40f), 4, Random.Range(-40f, 40f)), Quaternion.identity);
                bodyMovement.speed += 0.005f;   // 속도가 점점 빨라짐
            }
            Destroy(gameObject);
            enemyStamina_Text.stm2--;   // 체력 차감
        }
    }
}
