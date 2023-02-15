using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HourManager : MonoBehaviour
{
    float hourcount = 0;

    // Start is called before the first frame update
    void Start()
    {
        int h = DateTime.Now.Hour;
        transform.eulerAngles = new Vector3(0, 0, -30 * h);
    }

    // Update is called once per frame
    void Update()
    {
        hourcount += Time.deltaTime;
        if (hourcount >= 120)
        {
            //1週360度に12時間=1時間で30度、2分で1度時計周りに滑らかに回転する
            transform.Rotate(new Vector3(0, 0, -1 * Time.deltaTime));
            hourcount = 0;
        }
    }   
}
