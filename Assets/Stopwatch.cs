using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stopwatch : MonoBehaviour
{

    public Text Disvar;
    float val;
    public bool str;

    // Start is called before the first frame update
    void Start()
    {
        val = 0;
        str = true;

    }

    // Update is called once per frame
    void Update()
    {
        if(str) {
            val+=Time.deltaTime;  
        }
        Disvar.text=val.ToString();
    }

}
