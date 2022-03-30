using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject ground;

    public Transform player;
    void Start()
    {
        Instantiate(ground, new Vector3(0,-1.5f,-2.6f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void GenerateWorld(Vector3 startpoint)
    {
        Instantiate(ground, startpoint, Quaternion.identity);
    }
}
