using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Throwable direction;
    public float speed;
    public GameObject Pessi;
    // Start is called before the first frame update
    void Start()
    {
        direction = GameObject.FindGameObjectWithTag("Player").GetComponent<Throwable>();
        Pessi = GameObject.FindGameObjectWithTag("Pessi");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction.offset * Time.deltaTime * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pessi")
        {
            gameObject.SetActive(false);
            Pessi.SetActive(false);
        }
    }
    
    private void DestroyThrowable()
    {
        Destroy(gameObject);
    }
}
