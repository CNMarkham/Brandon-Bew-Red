using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLock : MonoBehaviour
{
    public string BlackKey;
    public GameObject EiEiEi;

    private Timer StopTimer;
    // Start is called before the first frame update
    void Start()
    {
        StopTimer = EiEiEi.GetComponent<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(BlackKey))
        {
            gameObject.SetActive(false);
            EiEiEi.SetActive(true);
            StopTimer.stopTimer = true;
            
        }
    }
}
