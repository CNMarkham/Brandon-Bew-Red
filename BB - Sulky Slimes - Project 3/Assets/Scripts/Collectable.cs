using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collectable : MonoBehaviour
{
    public Vector3 startingPosition;
    public Vector3 endingPosition;
    public AnimationCurve curve;

    [Header("Scene to Load")]
    public int sceneNumber;

    public static int NumberOfPigs;
    public int MaxPigs;
    // Update is called once per frame

    private void Start()
    {
        NumberOfPigs = MaxPigs;
    }
    void Update()
    {
        transform.position = Vector3.Lerp(startingPosition, endingPosition, curve.Evaluate(Time.time));
    
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            NumberOfPigs -= 1;
            if (NumberOfPigs == 0)
            {
                LoadNextScene();
            }
            gameObject.SetActive(false);
        }
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
