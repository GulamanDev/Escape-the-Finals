using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class PCDisplay : MonoBehaviour
{
    public GameObject Text;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag ("MainCamera"))
        { 
            Text.SetActive (true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            Text.SetActive(false);
        }
    }
}
