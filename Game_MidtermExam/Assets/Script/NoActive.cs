using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NoActive : MonoBehaviour
{
    public float timer = 0.0f;
    public int seconds;
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        Timer();
        if (seconds >= 5)
        {
            SceneManager.LoadScene("Splash");
            timer = 0.0f;
        }
         if (seconds < 5&&Input.anyKey)
        {
            timer = 0.0f;
        }

    }
    public void Timer()
    {
        timer += Time.deltaTime;
        seconds = (int)(timer % 60);
    }
}
