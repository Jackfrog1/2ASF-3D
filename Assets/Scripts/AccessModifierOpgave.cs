using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccessModifierOpgave : MonoBehaviour
{
    public Mand mand;

    void Start()
    {
        print("Mandens navn er: ");
        print(mand.navn);
        mand.skiftJob();
    }
}
