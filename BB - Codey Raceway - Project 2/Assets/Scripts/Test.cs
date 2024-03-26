using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private int []Testing;
    // Start is called before the first frame update
    void Start()
    {
     


    }

    // Update is called once per frame
    void Update()
    {

        
    }

    void Banana(int test)
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        Banana(Testing[0]);
    }
}
