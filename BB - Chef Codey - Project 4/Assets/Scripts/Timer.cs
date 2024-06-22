using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeSeconds = 60.0f;
    public TMP_Text textTime;
    public TMP_Text yessirText;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        timeSeconds -= Time.deltaTime;
        textTime.text = timeSeconds.ToString();
        textTime.text = Mathf.Round(timeSeconds).ToString();
        if (timeSeconds <= 0.0f)
        {
            timerEnd();
        }

        //if(timeSeconds >= 0.0f)
        //{
        //    yessirText.(true);
        //}
    }

    void timerEnd()
    {
        SceneManager.LoadScene(0);
    }
}
