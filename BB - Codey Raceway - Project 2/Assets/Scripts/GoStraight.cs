using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoStraight : MonoBehaviour
{
    public float Nein;
    // Start is called before the first frame update
    void Start()
    {
        Nein = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Nein;
    }
}
