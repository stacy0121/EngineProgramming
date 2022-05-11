using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour
{
    Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb2D.AddForce(canonMovement.objPosition * 20);
        }
        //if (Input.GetMouseButtonUp(0))
        //{
        //    Instantiate(this, new Vector3(0, 0, 0), Quaternion.identity);   // 인스턴스 생성(재장전)
        //}
    }
}
