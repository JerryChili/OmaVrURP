using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoop1 : MonoBehaviour
{
    int hoop1score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider backboard)
    {
        hoop1score++;
        Debug.Log("Ball passed through hoop 1");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
