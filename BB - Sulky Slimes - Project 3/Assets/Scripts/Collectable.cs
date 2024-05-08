using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public Vector3 startingPosition;
    public Vector3 endingPosition;
    public AnimationCurve curve;
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(startingPosition, endingPosition, curve.Evaluate(Time.time));

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
        }
    }
}
