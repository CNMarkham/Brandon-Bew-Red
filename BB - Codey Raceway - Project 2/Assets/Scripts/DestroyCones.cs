using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCones : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacles")
        {
            collision.gameObject.SetActive(false);
            gameObject.SetActive(false);
            
        }
    }
}