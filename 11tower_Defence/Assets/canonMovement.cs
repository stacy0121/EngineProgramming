using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canonMovement : MonoBehaviour
{
    float angle;
    Vector2 target;
    public static Vector3 objPosition;

    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5);   // 마우스는 vector2
        objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Debug.Log(objPosition+", "+mousePosition);

        // 마우스를 따라가는 대포
        angle = Mathf.Atan2(objPosition.y - target.y, objPosition.x - target.x) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
    }
}
