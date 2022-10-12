using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : Plant
{
    // Start is called before the first frame update
    void Start()
    {
        numberOfPlants++;                                                           //lægger én til antal planter
        myRenderer = GetComponent<Renderer>();                                      //finder rendereren på planten og gemmer den i myRenderer-variablen så vi senere kan referere til den
        ResetGlobalVariableValues();                                                //kalder metode
        InvokeRepeating("Reproduce", reproductionCooldown, reproductionCooldown);   //kalder metoden Reproduce() hver gang der er gået "reproductionCooldown"-sekunder
        StartCoroutine("Grow");                                                     //starter Grow() coroutinen
        GetRandomColor();
    }

    // Update is called once per frame
    void Update()
    {
        timeLived = timeLived + Time.deltaTime;                                     //der lægges lidt til tiden planten har levet

        if (timeLived > lifeExpectancy && startedDying == false)                    //hvis tiden planten har levet er større end plantens levetid
        {
            StartCoroutine("Die");                                                  //starter coroutine Die()
        }
    }

    void GetRandomColor()
    {
        Color randomColor;
        int randomNumber = Random.Range(1,4); // 1,2 or 3

        if (randomNumber == 1)
        {
            randomColor = new Color(Random.Range(0.5f, 1f), Random.Range(0.5f, 1f), 0);
        }

        else if (randomNumber == 2)
        {
            randomColor = new Color(Random.Range(0.5f, 1f), 0, Random.Range(0.5f, 1f));
        }

        else
        {
            randomColor = new Color(0, Random.Range(0.5f, 1f), Random.Range(0.5f, 1f));
        }

        myRenderer.material.color = randomColor;
    }

    
}
