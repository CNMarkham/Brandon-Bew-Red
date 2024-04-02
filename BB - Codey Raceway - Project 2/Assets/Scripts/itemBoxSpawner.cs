using UnityEngine;

public class itemBoxSpawner : MonoBehaviour
{
    public GameObject itemBox;
    public int numberOfBoxes;
    public GameObject Spawn;
    public float modY;
    public float modZ;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfBoxes; i++)
        {
            Vector3 rightOffset = new Vector3(2.5f * i, modY * i, modZ * i);
           // Vector3 leftOffset = new Vector3(-0.2f + i, 0, 0);
            GameObject itemBoxClone = Instantiate(itemBox, Spawn.transform.position + rightOffset, Quaternion.identity);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
