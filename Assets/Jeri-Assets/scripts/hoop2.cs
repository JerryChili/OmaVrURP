using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoop2 : MonoBehaviour
{
    int hoop2score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider backboard2)
    {
        hoop2score++;
        Debug.Log("Ball passed through hoop 2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
