using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    public GameObject Particle1;
    public GameObject Particle2;
    public GameObject wall;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (wall.activeInHierarchy == false)
        {
            Particle1.SetActive(true);
            Particle2.SetActive(true);
        }
    }
}
