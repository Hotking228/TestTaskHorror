using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoverCandle : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private string handToCandle = "toCandle";

    private bool isCovered;

    public bool IsCovered => isCovered;



    private void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            animator.SetBool(handToCandle, true);
            isCovered = true;
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            animator.SetBool(handToCandle, false);
            isCovered = false;
        }
    }
}
