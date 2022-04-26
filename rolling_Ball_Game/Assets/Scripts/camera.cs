using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform target;
    private Transform tr;

    public float offsetX;
    public float offsetY;
    public float offsetZ;

    public float DelayTime;


    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 FixedPos = new Vector3(target.position.x + offsetX, target.position.y + offsetY, target.position.z + offsetZ);   // 부드러운 움직임
        transform.position = Vector3.Lerp(transform.position, FixedPos, Time.deltaTime * DelayTime);   // 위치 갱신
    }
    void LateUpdate()
    {
        tr.position = new Vector3(target.position.x, target.position.y+10, target.position.z - 10);   // 카메라 위치 고정

        tr.LookAt(target);
    }
}
