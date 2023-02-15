using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MinuteManager : MonoBehaviour
{
    float minutecount = 0;

    // Start is called before the first frame update
    void Start()
    {
        int m = DateTime.Now.Minute;
        transform.eulerAngles = new Vector3(0, 0, -6 * m);
    }

    // Update is called once per frame
    void Update()
    {
        minutecount += Time.deltaTime;
        if(minutecount >= 10)
        {
            //1T360“x‚É60•ª=10•b‚Å1“xŒvü‚è‚ÉŠŠ‚ç‚©‚É‰ñ“]‚·‚é
            transform.Rotate(new Vector3(0, 0, -1 * Time.deltaTime));
            minutecount = 0;
        }
    }
}
