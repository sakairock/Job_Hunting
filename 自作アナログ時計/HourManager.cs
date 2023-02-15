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
            //1�T360�x��12����=1���Ԃ�30�x�A2����1�x���v����Ɋ��炩�ɉ�]����
            transform.Rotate(new Vector3(0, 0, -1 * Time.deltaTime));
            hourcount = 0;
        }
    }   
}
