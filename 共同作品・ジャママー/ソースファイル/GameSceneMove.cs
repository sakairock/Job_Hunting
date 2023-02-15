using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            SceneManager.LoadScene("ControlerTextScene");
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            SceneManager.LoadScene("HakaseTextScene");
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            SceneManager.LoadScene("JyamamarTextScene");
        }
    }
}
