using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerCount : MonoBehaviour
{
    // ���ԕb���ݒ�B
    float counttimer = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // counttimer�ɁA�Q�[�����J�n���Ă���̕b�����i�[
        // �ݒ肵�����Ԃ�������Ă����B
        counttimer -= Time.deltaTime;

        // ����2���ɂ��Ď��ԕ\��
        GetComponent<Text>().text = counttimer.ToString("F2");

        // ���Ԃ�0�ɂȂ����烊�U���g��ʂɔ�ԁB
        if(counttimer <= 0)
        {
            SceneManager.LoadScene("ResultScene");
        }
    }
}
