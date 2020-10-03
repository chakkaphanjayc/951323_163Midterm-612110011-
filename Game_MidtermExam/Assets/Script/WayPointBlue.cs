using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointBlue : MonoBehaviour
{
    public GameObject Cube;
    public static int ScoreCount;
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
            GameApplicationManager.Instance.Score = ScoreCount + 500;
            Destroy(Cube);
        }
    }
}
