using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door : MonoBehaviour
{
    public GameObject intText, key, lockedText, loadingScreen;
    public bool interactable, toggle;
    public Animator doorAnim;

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
                //WHen the player has the key
                if (key.active == false)
                {
                    //switches to next scene
                    toggle = !toggle;
                    if (toggle == true)
                    {
                        loadingScreen.SetActive(true);
                        SceneManager.LoadScene("Level2");
                        //doorAnim.ResetTrigger("close");
                        //doorAnim.SetTrigger("open");
                    }
                    //discard code
                    //if (toggle == false)
                    //{
                        //doorAnim.ResetTrigger("open");
                        //doorAnim.SetTrigger("close");
                    //}
                    intText.SetActive(false);
                    interactable = false;
                }
                //WHen the player doesnt ahve the key
                if (key.active == true)
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
