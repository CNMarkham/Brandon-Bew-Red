using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimesCountdown : MonoBehaviour
{
    public TextMeshProUGUI lapTime;
    public TextMeshProUGUI startCountdown;
    public float totalLapTime;
    public float totalStartCountdown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totalLapTime -= Time.deltaTime;
        totalStartCountdown -= Time.deltaTime;

        lapTime.text = Mathf.Round(totalLapTime).ToString();
        startCountdown.text = Mathf.Round(totalStartCountdown).ToString();
        
        //if (startCountdown.text = )
        {
            gameObject.SetActive(false);
        }
    }
}
