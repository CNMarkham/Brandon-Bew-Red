using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IfYouLose : MonoBehaviour
{
    public TimesCountdown tc;
    public TextMeshProUGUI You;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Finish")
        {
            if (tc.totalLapTime >= 0)
            {
                You.text = "You Win!";
            }
 
        }

    }
}
