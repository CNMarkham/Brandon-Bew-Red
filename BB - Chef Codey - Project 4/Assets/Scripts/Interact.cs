using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public string triggerName = "";

    public GameObject Red;
    public GameObject Green;
    public GameObject Black;
    public GameObject Blue;

    public GameObject heldItem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (heldItem == null)
            {
                pickup();
            }
            else
            { 
            heldItem.transform.localPosition = new Vector3(0, 0, 0);
            heldItem.transform.parent = null;
                pickup();
            }
        }

    }
    private void pickup()
    {
        if(triggerName == "red key")
                {
            heldItem = Red;
            Red.transform.parent = gameObject.transform;
            print("Red");
            heldItem.transform.localPosition = new Vector3(0.54f, 3.3333f, 0.217f);
        }

        if (triggerName == "blue key")
        {
            heldItem = Blue;
            Blue.transform.parent = gameObject.transform;
            print("Blue");
            heldItem.transform.localPosition = new Vector3(0.54f, 3.3333f, 0.217f);
        }

        if (triggerName == "black key")
        {
            heldItem = Black;
            Black.transform.parent = gameObject.transform;
            print("Black");
            heldItem.transform.localPosition = new Vector3(0.54f, 3.3333f, 0.217f);
        }

        if (triggerName == "green key")
        {
            heldItem = Green;
            Green.transform.parent = gameObject.transform;
            print("Green");
            heldItem.transform.localPosition = new Vector3(0.54f, 3.3333f, 0.217f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        triggerName = other.name;
    }

    private void OnTriggerExit(Collider other)
    {
        triggerName = "";
    }
}
