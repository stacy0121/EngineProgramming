using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnBecameInvisible()   // 화면에서 벗어나면
    {
        Destroy(gameObject);   // 총알 오브젝트 제거
    }

    private void OnCollisionEnter(Collision collision)   // 충돌 감지
    {
        if (collision.gameObject.tag == "enemy")   // 만약에 적과 총알이 충돌하면
        {
            Destroy(gameObject);    // 총알 없애기
        }
    }
}
