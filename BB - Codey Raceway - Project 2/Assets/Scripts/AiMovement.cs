using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class ShellScript : MonoBehaviour
{
    public Transform goal;
    private NavMeshAgent agent;
    GameObject[] obstables;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        obstables = GameObject.FindGameObjectsWithTag("Obstacles");
        SetTargetToRandom(obstables);
        agent.destination = goal.position;

    }

    void SetTargetToRandom(GameObject[] obstacles)
    {
        goal = obstables[Random.Range(0, obstables.Length - 1)].transform;
        Debug.Log("Goal is "+goal.name);
    }
    // Update is called once per frame
    void Update()
    {
 
    }
}
