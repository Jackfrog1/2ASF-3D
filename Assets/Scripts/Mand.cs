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
        hemmeligtJob = "Hjemmehj�lper";
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


    //I m� �ndre koden herfra og ned
}
