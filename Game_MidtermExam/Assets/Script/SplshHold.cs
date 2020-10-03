using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SplshHold : MonoBehaviour
{
    public float KeydownTime, KeyupTime, pressTime = 0;
    public float countDown = 10.0f;
    public bool ready = false;
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && ready == false)
        {
            KeydownTime = Time.time;
            pressTime = KeydownTime + countDown;
            ready = true;
            Debug.Log(KeydownTime);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            ready = false;
        }
        if (Time.time >= pressTime && ready == true)
        {
            SceneManager.LoadScene ("SceneMainMenu");
        }
    }
}
