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
        //1T360“x‚É60•b=1•b‚Å6“xŒvü‚è‚ÉŠŠ‚ç‚©‚É‰ñ“]‚·‚é
        transform.Rotate(new Vector3(0, 0, -6*Time.deltaTime));
    }
}
