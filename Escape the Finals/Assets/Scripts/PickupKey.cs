using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupKey : MonoBehaviour
{
    public GameObject inttext, key;
    public bool interactable;


    //Views [E] when looked at
    private void OnTriggerStay(Collider other)
    {
       if (other.CompareTag("Player"))
        {
            inttext.SetActive(true);
            interactable = true;
        }
    }

    //deletes [E] when away
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inttext.SetActive(false);
            interactable = false;
        }
    }

    //When picked up, key acquired
    void Update()
    {
        if(interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                inttext.SetActive(false);
                interactable=false;
                key.SetActive(false);
            }
        }
    }
}
