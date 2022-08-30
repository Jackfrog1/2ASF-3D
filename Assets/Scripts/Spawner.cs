using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float range;                                             //Størrelsen på området den spawner i
    public float spawnCooldown;                                     //Cooldown på spawn, hold tallet over 0
    public GameObject objectToSpawn;                                //Træk det objekt ind der skal spawnes

    
    void Start()
    {
        InvokeRepeating("Spawn",1.5f,1);                               //InvokeRepeating kalder her Spawn-metoden efter 1.5 sekund, og efterfølgende én gang i sekundet
    }

    void Spawn()                                                    //Spawn-metoden som spawner et objekt i en random position
    {
        float randomX = Random.Range(-range,range);
        float randomY = Random.Range(-range,range);

        Instantiate(objectToSpawn,this.transform.position + new Vector3(randomX,0,randomY),Quaternion.identity);            //Spawner objektet på spanwnerens position lagt sammen med en ekstra position som indeholder en random x og y værdi

    }
}
