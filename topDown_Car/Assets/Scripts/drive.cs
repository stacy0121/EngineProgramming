using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drive : MonoBehaviour
{
    public Rigidbody2D rb2d;
    float xValue;
    float yValue;
    public float speed;   // 가속력
    public Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb2d = GetComponent<Rigidbody2D>();
        yValue = Input.GetAxis("Vertical");
        xValue = Input.GetAxis("Horizontal");


        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 7;
        }

        camera.transform.position = new Vector3(transform.position.x, transform.position.y, -10);
    }

    public void FixedUpdate()   // 물리엔진
    {
        //rb2d.velocity = new Vector2(0, yValue);   // 좌표 변경
        rb2d.velocity = transform.up*yValue*speed;   // 자기자신 곱하기 up
        transform.Rotate(0, 0, -1 * xValue * 1);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "wall")
        {
            Debug.Log("충돌!");
        }
    }
}
