using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyChecker : MonoBehaviour
{
    public GameObject intText, key1, key2, key3, lockedText;
    public bool interactable, toggle;
    //SHows e
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            intText.SetActive(true);
            interactable = true;
        }
    }

    //E gone
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            intText.SetActive(false);
            interactable = false;
        }
    }
    void Update()
    {
        //interacts with door
        if (interactable == true)
        {
            //Press E on door
            if (Input.GetKeyDown(KeyCode.E))
            {
                //When the player has the key
                if (key1.active == false && key2.active == false && key3.active == false)
                {
                    //switches to next scene
                    toggle = !toggle;
                    if (toggle == true)
                    {
                          Debug.Log("banana");
                        /*                        loadingScreen.SetActive(true);*/
                        //put the end scene here v
                        SceneManager.LoadScene("End");
                    }
                    intText.SetActive(false);
                    interactable = false;
                }
                //When the player doesnt ahve the key
                if (key1.active == true && key2.active == true && key3.active == true)
                {
                    lockedText.SetActive(true); 
                    StopCoroutine("disableText");
                    StartCoroutine("disableText");
                }

                if (key1.active == false && key2.active == true && key3.active == true)
                {
                    lockedText.SetActive(true);
                    StopCoroutine("disableText");
                    StartCoroutine("disableText");
                }

                if (key1.active == true && key2.active == false && key3.active == true)
                {
                    lockedText.SetActive(true);
                    StopCoroutine("disableText");
                    StartCoroutine("disableText");
                }

                if (key1.active == true && key2.active == true && key3.active == false)
                {
                    lockedText.SetActive(true);
                    StopCoroutine("disableText");
                    StartCoroutine("disableText");
                }

                if (key1.active == false && key2.active == false && key3.active == true)
                {
                    lockedText.SetActive(true);
                    StopCoroutine("disableText");
                    StartCoroutine("disableText");
                }

                if (key1.active == false && key2.active == true && key3.active == false)
                {
                    lockedText.SetActive(true);
                    StopCoroutine("disableText");
                    StartCoroutine("disableText");
                }

                if (key1.active == true && key2.active == false && key3.active == false)
                {
                    lockedText.SetActive(true);
                    StopCoroutine("disableText");
                    StartCoroutine("disableText");
                }
            }
        }
    }
IEnumerator disableText()
    {
        yield return new WaitForSeconds(2.0f);
        lockedText.SetActive(false);
    }

}
