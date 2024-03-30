using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class PCDisplayDialogue : MonoBehaviour
{
    public GameObject Text;
    private int i;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            i = 1;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            Text.SetActive(false);
            i = 0;
        }
    }
    private void Update()
    {
        if (i == 1)
        {
            Text.SetActive(true);
        }
    }
}
