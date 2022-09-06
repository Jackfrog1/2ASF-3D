using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Horse : MonoBehaviour
{

    public enum State                                       //enum som viser hvilke states der findes 
    { 
        Sleep,
        Eat,
    }

    public List<GameObject> allGrass = new List<GameObject>();  //Liste til alt gr�sset i scenen
    public State myState;                                       //enum-objekt som holder styr p� hvilken state man er i
    public GameObject bed;                                  //senge-objekt
    public NavMeshAgent agent;                              //navmesh-agent
    
    void Start()
    {
        bed = GameObject.Find("Bed");                       //Finder et gameobject i scenen der hedder "Bed" og gemmer det i bed-variablen
    }
    
    void Update()
    {
        switch (myState)                                    //switch case som kigger p� myState og afvikler den state
        {
            case State.Sleep:
                Sleep();                                    //sleep-metoden kaldes
                break;

            case State.Eat:
                Eat();
                break;
        }

        
    }

    void Sleep()                                            //sleep-metode
    {
                                               
    }

    void Eat()                                              //Eat-metoden
    {
        


        GameObject closestGrass;                            //Lokal gameobject-variabel til det n�rmeste stykke gr�s
        float shortestDistance = 9999;                      //lokal float-variabel til at holde den korteste afstand til et stykke gr�s

        foreach (GameObject grass in allGrass)              //foreach er ligesom et for-loop, bare det k�rer igennem alle elementer i en liste eller et array
        {
            if (grass == null)                              //Hvis gr�sset ikke eksisterer
            {
                continue;                                   //foreach-loopet springer resten af sin kode over, og k�rer videre til n�ste iteration
            }

            if (Vector3.Distance(grass.transform.position,this.transform.position) < shortestDistance)              //this afstanen mellem gr�s og hest er mindre end shortestDistance
            {
                

                shortestDistance = Vector3.Distance(grass.transform.position, this.transform.position);             //shortestDistance = afstanden mellem gr�s og hest
                closestGrass = grass;                                                                               //Det stykke gr�s foreach-loopet arbejder p� lige nu, gemmes i variablen closestGrass
                agent.SetDestination(closestGrass.transform.position);                                              //Dette stykke gr�s s�ttes som agentens (hesten) destination
            }
        }       
    }

    private void OnTriggerEnter(Collider other)             //metode som bliver kaldt n�r et gameobject rammer ind i den runde trigger der sidder p� hesten
    {
        if (other.tag == "Grass")
        {
            allGrass.Add(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)              //metode som bliver kaldt n�r et gameobject bev�ger sig ud af den runde trigger der sidder p� hesten
    {
        if (other.tag == "Grass")
        {
            allGrass.Remove(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)          //Metode som kaldes n�r hesten fysisk rammer ind i noget
    {
        if (collision.collider.tag == "Grass")                  //Hvis det hesten rammer er tagget "Grass"
        {
            allGrass.Remove(collision.collider.gameObject);     //Fjern det stykke gr�s fra listen allGrass
            Destroy(collision.collider.gameObject);             //Fjern det stykke gr�s helt fra spillet
        }
    }


}
