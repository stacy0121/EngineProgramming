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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "me")   // 적과 내가 부딪히면 적을 없애고 자신을 자동 생성
        {
            Debug.Log("Collision");
            bodyMovement.sub = Instantiate(gameObject, new Vector3(Random.Range(-10f, 10f), 10, Random.Range(-10f, 10f)), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
