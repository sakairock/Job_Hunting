using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SecondManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int s = DateTime.Now.Second;
        transform.eulerAngles = new Vector3(0, 0, -6 * s);
    }

    // Update is called once per frame
    void Update()
    {
        //1�T360�x��60�b=1�b��6�x���v����Ɋ��炩�ɉ�]����
        transform.Rotate(new Vector3(0, 0, -6*Time.deltaTime));
    }
}
