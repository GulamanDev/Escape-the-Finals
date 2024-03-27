using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class TriggerKeypad : MonoBehaviour
{
    public GameObject intText, keypad;
    public bool interactable, toggle;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intText.SetActive(true);
            interactable = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intText.SetActive(false);
            interactable = false;
        }
    }
    void Update()
    {
        if (interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                toggle = !toggle;

                if (toggle == true)
                {
                    keypad.SetActive(true);
                }

                if (toggle == false)
                {
                    Debug.Log("Not Pressed");
                }

                intText.SetActive(false);
                interactable = false;
            }
        }
    }
}
