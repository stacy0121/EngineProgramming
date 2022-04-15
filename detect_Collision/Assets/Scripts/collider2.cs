using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider2 : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Debug.Log("E2");
            textControl.po += 3;
            Destroy(GameObject.FindWithTag("E2"));
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        textControl.po = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
