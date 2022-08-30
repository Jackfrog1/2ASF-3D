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

    public State myState;                                   //enum-objekt som holder styr på hvilken state man er i
    public GameObject grass;                                //græs-objekt
    public GameObject bed;                                  //senge-objekt
    public NavMeshAgent agent;                              //navmesh-agent
    
    void Start()
    {
        
    }
    
    void Update()
    {
        switch (myState)                                    //switch case som kigger på myState og afvikler den state
        {
            case State.Sleep:
                Sleep();                                    //sleep-metoden kaldes
                break;

            case State.Eat:
                agent.SetDestination(grass.transform.position);         //agenten går til græssets position
                break;
        }
    }

    void Sleep()                                            //sleep-metode
    {
                                               
    }
}
