using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
<<<<<<< Updated upstream
=======
<<<<<<< HEAD

    //public Transform target;   // 따라다닐 타겟 오브젝트(player)의 transform
    private Transform tr;
    public GameObject target;
    public float offsetX;
    public float offsetY;
    public float offsetZ;

    public float DelayTime;
=======
>>>>>>> Stashed changes
    public Transform target;
    private Transform tr;

    /*public float offsetX;
    public float offsetY;
    public float offsetZ;

    public float DelayTime;*/

<<<<<<< Updated upstream
=======
>>>>>>> a9a913c7bf586566e2ecda92fdebdb5cbac4ed3a
>>>>>>> Stashed changes

    // Start is called before the first frame update
    void Start()
    {
<<<<<<< Updated upstream
        tr = GetComponent<Transform>();
=======
<<<<<<< HEAD
        tr = GetComponent<Transform>();      // 카메라 자신의 transform
=======
        tr = GetComponent<Transform>();
>>>>>>> a9a913c7bf586566e2ecda92fdebdb5cbac4ed3a
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
        Vector3 FixedPos = new Vector3(target.transform.position.x + offsetX, target.transform.position.y + offsetY, target.transform.position.z + offsetZ);

        transform.position = Vector3.Lerp(transform.position, FixedPos, Time.deltaTime * DelayTime);   // 부드럽게 움직이기(선형보간)  *deltaTime-이전 프레임이 나오는 시간
    }

    private void LateUpdate()
    {
        tr.position = new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z - 10); ;   // player로부터 거리를 둠

        tr.LookAt(target.transform);
=======
>>>>>>> Stashed changes
        //Vector3 FixedPos = new Vector3(target.position.x + offsetX, target.position.y + offsetY, target.position.z + offsetZ);
        //transform.position = Vector3.Lerp(transform.position, FixedPos, Time.deltaTime * DelayTime);
    }
    void LateUpdate()
    {
        tr.position = new Vector3(target.position.x, tr.position.y, target.position.z - 20);

        tr.LookAt(target);
<<<<<<< Updated upstream
=======
>>>>>>> a9a913c7bf586566e2ecda92fdebdb5cbac4ed3a
>>>>>>> Stashed changes
    }
}
