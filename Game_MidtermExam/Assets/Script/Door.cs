using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    int red = 5;
    public static float ScoreStage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ScoreStage = GamePlayTimer.timea * 1000;
            SceneManager.LoadScene ("SceneGameplayStage2");
        SceneManager.UnloadSceneAsync ("SceneGameplayStage1");
        }
    }
}
