using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayTimer1 : MonoBehaviour
{
    public  static float timer = 0.0f;
    public static int seconds;
    public static float ScoreBack;
    public static float timeC = 20f;
    public static float timea;
    Text TimeCount;
    // Start is called before the first frame update
    void Start()
    {
        TimeCount = GetComponent<Text>();
        
    }
    // Update is called once per frame
    void Update()   
    {
        Timer();
        timea = timeC - seconds;
        TimeCount.text = "Time = " + (timea);
    }
    public void Timer()
    {
        timer += Time.deltaTime;
        seconds = (int)(timer % 60);
    }
}
