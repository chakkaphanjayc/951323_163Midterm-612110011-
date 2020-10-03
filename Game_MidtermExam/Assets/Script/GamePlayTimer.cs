using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayTimer : MonoBehaviour
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
        if (seconds >= 30)
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
