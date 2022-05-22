using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class counter : MonoBehaviour
{
    private Text text;
    public static float count;
    // Start is called before the first frame update
    void Start()
    {
        count = 3;
        text = this.gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        count -= Time.deltaTime;
        text.text = string.Format("{0:N0}", count);
        Debug.Log(count);
        if (count < 1)
        {
            text.text = "Start!";
            Destroy(this.gameObject);
        }

    }
}
