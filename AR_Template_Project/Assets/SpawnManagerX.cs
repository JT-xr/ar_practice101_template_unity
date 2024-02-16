using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    private float timeDelay = .5f;
    private float intervalTime = 2.0f;
    public GameObject cubePrefab;
    
    // Start is called before the first frame update
    // Spawn cubes at a specific time interval
    void Start()
    {
        InvokeRepeating("SpawnTimedCube", timeDelay, intervalTime);
    }

    // Update is called once per frame
    void Update()
    {
    }

    //Defines the cubes (location and rotation) of where and how it will spawn 
    void SpawnTimedCube (){
        Vector3 RandomSpawnPos = new Vector3 (Random.Range (-0.5f,0.5f), Random.Range(-3.0f,3.0f), -30.0f);
        Instantiate (cubePrefab, RandomSpawnPos, cubePrefab.transform.rotation);    
       

       //Instantiate (cubePrefab, cubePrefab.transform.position, cubePrefab.transform.rotation);
    } 
    

}
