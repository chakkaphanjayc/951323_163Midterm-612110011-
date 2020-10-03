using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomFall : MonoBehaviour
{
    
    private Vector3 Min;
    private Vector3 Max;
    private float _xAxis;
    private float _yAxis;
    private float _zAxis; //If you need this, use it
    private Vector3 _randomPosition;
    public bool _canInstantiate;
    private void Start()
    {
        InvokeRepeating( "SpawObject", 2f, 5f );
        SetRanges();
    }
    private void Update()
    {
        _xAxis = UnityEngine.Random.Range(Min.x, Max.x);
        _yAxis = UnityEngine.Random.Range(Min.y, Max.y);
        _zAxis = UnityEngine.Random.Range(Min.z, Max.z);
        _randomPosition = new Vector3(_xAxis, _yAxis, _zAxis);
    }
    //Here put the ranges where your object will appear, or put it in the inspector.
    private void SetRanges()
    {
        Min = new Vector3(-10, 4, 7); //Random value.
        Max = new Vector3(8, 6, 50); //Another ramdon value, just for the example.
    }
    private void SpawObject()
    {
            Instantiate(this.gameObject, _randomPosition, Quaternion.identity);
            Destroy(this.gameObject ,3.0f);
    }
    
}
