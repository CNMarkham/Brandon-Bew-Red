using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public int pessiCount;
    // Start is called before the first frame update
    void Start()
    {
        pessiCount = GameObject.FindGameObjectsWithTag("Pessi").Length;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && pessiCount == 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}
