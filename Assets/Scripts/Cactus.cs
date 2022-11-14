using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactus : Plant
{
    public GameObject spike;

    // Start is called before the first frame update
    void Start()
    {
        numberOfPlants++;                                                           //l�gger �n til antal planter
        myRenderer = GetComponent<Renderer>();                                      //finder rendereren p� planten og gemmer den i myRenderer-variablen s� vi senere kan referere til den
        ResetGlobalVariableValues();                                                //kalder metode
        InvokeRepeating("Reproduce", reproductionCooldown, reproductionCooldown);   //kalder metoden Reproduce() hver gang der er g�et "reproductionCooldown"-sekunder
        StartCoroutine("Grow");                                                     //starter Grow() coroutinen
    }

    // Update is called once per frame
    void Update()
    {
        timeLived = timeLived + Time.deltaTime;                                     //der l�gges lidt til tiden planten har levet

        if (timeLived > lifeExpectancy && startedDying == false)                    //hvis tiden planten har levet er st�rre end plantens levetid
        {
            GrowSpikes();
            StartCoroutine("Die");                                                  //starter coroutine Die()
        }
    }

    public void GrowSpikes()
    {
        for (int i = 0; i < 10; i++)
        {
            Vector3 randomPos = new Vector3(Random.Range(-1,1), Random.Range(-1, 1), Random.Range(-1, 1));

            Instantiate(spike, this.transform.position+randomPos, Quaternion.identity);
        }
    }
}
