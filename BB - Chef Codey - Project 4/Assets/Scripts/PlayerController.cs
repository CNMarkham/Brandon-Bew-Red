using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class PlayerController : MonoBehaviour
{
    private Animator anim;
    private Rigidbody rb;
    private Quaternion lastLook;
    public float speed;
    public CinemachineVirtualCameraBase vCam;
    [SerializeField] private int rotateAmount = 45;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
        anim = GetComponent<Animator>();
        lastLook = transform.rotation;
        vCam = FindObjectOfType<CinemachineVirtualCameraBase>();
    }

    void Update()
    {
        var cam = Camera.main.transform.TransformVector(transform.forward).normalized;
        var newforward = new Vector3(transform.forward.x, 0, transform.forward.z);

        //velocity.y += gravity * Time.deltaTime;

        var forward = Input.GetAxis("Vertical");
        var sideward = Input.GetAxis("Horizontal");

        var direction = newforward * forward + Camera.main.transform.TransformVector(transform.right).normalized * 0;
        transform.eulerAngles += new Vector3(0, sideward, 0);

        // Vector3 movement = new Vector3(horizontal, 0, vertical)  * speed / 100;

        rb.MovePosition( transform.position + direction * speed * Time.deltaTime);

       // vCam.
    }
}
