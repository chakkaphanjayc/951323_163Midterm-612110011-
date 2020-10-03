using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door1 : MonoBehaviour
{
    int red = 5;
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
        SceneManager.LoadScene ("SceneMainMenu");
        SceneManager.UnloadSceneAsync ("SceneGameplayStage2");
        }
    }
}
