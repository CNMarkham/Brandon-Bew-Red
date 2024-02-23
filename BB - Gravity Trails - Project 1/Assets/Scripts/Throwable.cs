using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Throwable : MonoBehaviour
{
    public GameObject objectThrown;
    public Vector3 offset;
    public int throwableCounter;
    public TextMeshProUGUI collectableCounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (throwableCounter > 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                offset = transform.localScale.x * new Vector3(1, 0, 0);
                Vector3 throwablePosition = transform.position + offset;
                Instantiate(objectThrown, throwablePosition, transform.rotation);
                throwableCounter -= 1;
                collectableCounter.text = throwableCounter.ToString();
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Collectable")
        {
            throwableCounter += 1;
            collectableCounter.text = throwableCounter.ToString();
            collision.gameObject.SetActive(false);
        }
    }
}
