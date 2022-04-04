using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform target;
    private Transform tr;

    /*public float offsetX;
    public float offsetY;
    public float offsetZ;

    public float DelayTime;*/


    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 FixedPos = new Vector3(target.position.x + offsetX, target.position.y + offsetY, target.position.z + offsetZ);
        //transform.position = Vector3.Lerp(transform.position, FixedPos, Time.deltaTime * DelayTime);
    }
    void LateUpdate()
    {
        tr.position = new Vector3(target.position.x, tr.position.y, target.position.z - 20);

        tr.LookAt(target);
    }
}
