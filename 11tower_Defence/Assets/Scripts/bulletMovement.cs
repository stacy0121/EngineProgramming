using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {

    }

    void OnBecameInvisible()   // 화면에서 벗어나면
    {
        Destroy(gameObject);   // 총알 오브젝트 제거
    }

    private void OnCollisionEnter2D(Collision2D collision)   // 충돌 감지
    {
        if (collision.gameObject.tag == "enemy")   // 만약에 적과 총알이 충돌하면
        {
            Destroy(gameObject);    // 총알 없애기
            stamina_Text.enemy++;   // 킬 수 추가

            if (stamina_Text.enemy == 20)      // 적 20마리를 모두 죽이면
                canonMovement.finish = true;   // 게임 종료
        }
    }
}
