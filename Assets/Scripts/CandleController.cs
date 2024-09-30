using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleController : MonoBehaviour
{
    [SerializeField] private GameObject fire;
    private float timeToPutOut;
    private bool isPutOut;
    private float timer;
    [SerializeField] private CoverCandle coverCandle;

    public void SetPutOut(float time)
    {
        isPutOut = true;
        SetTimer(time);
    }

    public void SetPutOn()
    {
        isPutOut = false;
        


        // Опционально можно добавить этот кусок кода или другую логику этот кусок позволяет зажигать свечу сразу по выходе из зоны потухания
        /*  if (fire != null)
            fire.SetActive(true);*/


    }


    private void SetTimer(float time)
    {
        timeToPutOut = time;
        timer = 0;
        
    }

    private void Update()
    {
        if (isPutOut)
        {
            if (!coverCandle.IsCovered)
            {
                timer += Time.deltaTime;
                if (timer >= timeToPutOut)
                {
                    PutOut();
                }
            }
        }
        if (coverCandle.IsCovered)
        {
            timer = 0;
        }
       
    }


    private void PutOut()
    {
        isPutOut = false;
        if (fire != null)
            fire.SetActive(false);
    }
}
