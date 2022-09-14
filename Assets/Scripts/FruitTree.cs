using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitTree : MonoBehaviour
{
    public GameObject[] typesOfFruit;
    public Transform fruitSpawnPoint;
    
    void Start()
    {
        StartCoroutine(SpawnFruitsAllTheTime(1f));
    }

    IEnumerator SpawnFruitsAllTheTime(float timeBetweenFruits) 
    {
        while (true) 
        {
            yield return new WaitForSeconds(timeBetweenFruits);
            SpawnAFruit(fruitSpawnPoint, GetRandomFruit());
        }
    }

    GameObject GetRandomFruit() 
    {
        int a = GetARandomInt(0,typesOfFruit.Length);
        GameObject randomFruit = typesOfFruit[a];
        return randomFruit;
    }

    void SpawnAFruit(Transform spawnPoint, GameObject randomFruit) 
    {
        GameObject fruit = Instantiate(randomFruit, spawnPoint.position, Quaternion.identity);
        Destroy(fruit, 30f);
    }

    int GetARandomInt(int a, int b) 
    {
        int c = Random.Range(a, b);
        return c;
    }
}
