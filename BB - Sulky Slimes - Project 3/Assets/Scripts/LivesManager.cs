using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LivesManager : MonoBehaviour
{
    public int lives;
    public GameObject[] hearts;

    [Header("Lives")]
    public LivesManager livesManager;

    public int SN;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lives == 0)
        {
            SceneManager.LoadScene(SN);
        }
    }

    public void RemoveLife()
    {
        lives -= 1;
        print("U Lost a bird on the screen" + lives);
        hearts[lives].SetActive(false);
    }
}
