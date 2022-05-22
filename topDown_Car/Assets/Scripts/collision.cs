using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collision : MonoBehaviour
{
    private Text text;
    public static float scr;
    // Start is called before the first frame update
    void Start()
    {
        scr = 0;
        text = this.gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Ãæµ¹: " + scr.ToString();
    }
}
