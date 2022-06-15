using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private Transform player = bodyMovement.playerTransform;   // 플레이어 위치

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 적에게 가까이 다가가면 서브몹이 움직임 (게임 시작)
        float distance = Vector3.Distance(player.transform.position, transform.position);   // 오류******************************
        if (distance < 5.0f)
        {
            transform.rotation = Quaternion.LookRotation(player.transform.position - transform.position).normalized;
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 0.01f);
            //Debug.Log(Vector3.Distance(bodyMovement.playerTransform.transform.position, transform.position));
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "arrow")   // 화살이 적에 닿으면 적을 없애고 다른 위치에 자동 생성
        {
            enemyStamina_Text.stm2--;   // 체력 차감
        }
    }
}
