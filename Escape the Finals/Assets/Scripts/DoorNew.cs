using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DoorNew : MonoBehaviour
{
    public GameObject intText, lockedText;
    public bool interactable, toggle, locked;
    public Animator doorAnim;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            if (locked == true)
            {
                lockedText.SetActive(true);
            }
            else
            {
                intText.SetActive(true);
                interactable = true;
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intText.SetActive(false);
            lockedText.SetActive(false);
            interactable = false;
        }      
    }
    public void UnlockDoor()
    {
        Debug.Log("Door is unlocked");
        locked = false;
    }

    void Update()
    {
        if (interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("IT WORKS");
                //  Replace Debug.Log with the sceneloader to the next level
            }
        }
    }
}
