using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Vector3 direction;
    public float speed;
    void Start()
    {
        direction = GameObject.FindGameObjectWithTag("Player").GetComponent<Throwable>().offset;
        Invoke("DestroyThrowable", 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * Time.deltaTime * speed;
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pessi")
        {
            gameObject.SetActive(false);
            collision.gameObject.SetActive(false);
        }
    }
    
    private void DestroyThrowable()
    {
        Destroy(gameObject);
    }
}
