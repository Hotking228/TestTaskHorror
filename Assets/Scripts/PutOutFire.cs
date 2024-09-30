using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutOutFire : MonoBehaviour
{
    [SerializeField] private float timeToPutOut;

    private void OnTriggerEnter(Collider other)
    {
        
        CandleController c = other.GetComponent<CandleController>();
        if (c != null)
        {
            c.SetPutOut(timeToPutOut);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        CandleController c = other.GetComponent<CandleController>();
        if (c != null)
        {
            c.SetPutOn();
        }
    }

   
}
