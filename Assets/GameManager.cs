using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Transform spawnPoint1, spawnPoint2, spawnPoint3;
    public GameObject milkBottlePrefab;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(spawnPoint2.position);

        //GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        //Instantiate(cube, spawnPoint2.position, Quaternion.identity);
        MoreBottles();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoreBottles()
    {
        Instantiate(milkBottlePrefab, new Vector3(spawnPoint1.position.x, spawnPoint1.position.y, spawnPoint1.position.z), Quaternion.identity);
        Instantiate(milkBottlePrefab, new Vector3(spawnPoint2.position.x, spawnPoint2.position.y, spawnPoint2.position.z), Quaternion.identity);
        Instantiate(milkBottlePrefab, new Vector3(spawnPoint3.position.x, spawnPoint3.position.y, spawnPoint3.position.z), Quaternion.identity);

    }
}
