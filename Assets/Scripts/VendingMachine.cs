using UnityEngine;

public class VendingMachine : MonoBehaviour
{
    public GameObject keyPrefab;
    public GameObject keySpawn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DispenseItem()
    {
        keyPrefab.transform.position = keySpawn.transform.position;
        keyPrefab.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    }
}
