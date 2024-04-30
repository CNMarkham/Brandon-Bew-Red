using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    [Header("Mouse Info")]
    public Vector3 clickStartLocation;

    [Header("Physics")]
    public Vector3 launchVector;
    public float launchForce;

    [Header("RedBird")]
    public Transform redBirdTransform;
    public Rigidbody redBirdRigidbody;
    public Vector3 originalRedBirdPosition;
    // Start is called before the first frame update
    void Start()
    {
        originalRedBirdPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickStartLocation = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 mouseDifference = clickStartLocation - Input.mousePosition;
            launchVector = new Vector3(mouseDifference.x * 1f, mouseDifference.y * 1.2f, mouseDifference.y * 1.5f);
            launchVector.Normalize();
            redBirdTransform.position = originalRedBirdPosition - launchVector / 400;
        }

        if (Input.GetMouseButtonUp(0))
        {
            redBirdRigidbody.isKinematic = false;
            redBirdRigidbody.AddForce(launchVector * launchForce, ForceMode.VelocityChange);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            redBirdTransform.position = originalRedBirdPosition;
            redBirdRigidbody.isKinematic = true;
        }
    }
}