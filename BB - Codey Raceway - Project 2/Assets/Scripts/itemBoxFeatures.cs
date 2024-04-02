using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBoxFeatures : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * 50f);
        
    }

    private void itemBoxRespawn()
    {
        gameObject.SetActive(true);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            Invoke("itemBoxRespawn", 5);
        }
    }
}
