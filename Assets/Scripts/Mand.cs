using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mand : MonoBehaviour
{
    public string navn;
    string undercoverNavn;
    string hemmeligtJob;

    
    void Start()
    {
        hemmeligtJob = "Hjemmehjælper";
        navn = "Kim Hot";
        undercoverNavn = "Kongen af Hundige";
    }

    public void skiftJob()
    {
        hemmeligtJob = "Bolche-fabrikant";
    }

    void skiftUndercoverNavn()
    {
        undercoverNavn = "Trylledejs-Kim";
    }


    //I må ændre koden herfra og ned
}
