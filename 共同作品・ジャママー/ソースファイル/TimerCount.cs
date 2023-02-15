using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerCount : MonoBehaviour
{
    // 時間秒数設定。
    float counttimer = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // counttimerに、ゲームが開始してからの秒数を格納
        // 設定した時間から引いていく。
        counttimer -= Time.deltaTime;

        // 小数2桁にして時間表示
        GetComponent<Text>().text = counttimer.ToString("F2");

        // 時間が0になったらリザルト画面に飛ぶ。
        if(counttimer <= 0)
        {
            SceneManager.LoadScene("ResultScene");
        }
    }
}
