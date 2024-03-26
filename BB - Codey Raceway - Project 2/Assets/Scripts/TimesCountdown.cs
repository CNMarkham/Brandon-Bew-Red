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
    public CodeyMove cm;
    // Start is called before the first frame update
    void Start()
    {
        cm.Speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        totalStartCountdown -= Time.deltaTime;

        lapTime.text = Mathf.Round(totalLapTime).ToString();
        startCountdown.text = Mathf.Round(totalStartCountdown).ToString();
        
        if (totalStartCountdown <= 0)
        {
            startCountdown.text = " ";
            totalLapTime -= Time.deltaTime;
            cm.Speed = 800;
        }

        if (totalLapTime <= 0)
        {
            lapTime.text = " ";
            print("Time is up");
            cm.Speed = 0;
        }
    }
}
