using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Keypad : MonoBehaviour
{
    public TMP_InputField charHolder;
    public GameObject button1;      // I know i can make this cleaner using an array but I DONT WANT TO AND I HATE ARRAYS
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject button8;
    public GameObject button9;
    public GameObject button0;
    public GameObject clearButton;
    public GameObject enterButton;
    public GameObject exitButton;
    public GameObject keypad;
    public GameObject door;
    public SC_FPSController playerScript;

    public void b1()
    {
        charHolder.text += "1";
    }
    public void b2()
    {
        charHolder.text += "2";
    }
    public void b3()
    {
        charHolder.text += "3";
    }
    public void b4()
    {
        charHolder.text += "4";
    }
    public void b5()
    {
        charHolder.text += "5";
    }
    public void b6()
    {
        charHolder.text += "6";
    }
    public void b7()
    {
        charHolder.text += "7";
    }
    public void b8()
    {
        charHolder.text += "8";
    }
    public void b9()
    {
        charHolder.text += "9";
    }
    public void b0()
    {
        charHolder.text += "0";
    }
    public void clearEvent()
    {
        charHolder.text = null;
    }
    //  Couldn't figure it out in 20 mins so i gave up
/*    IEnumerator ShowError(string errorText)
    {
        yield return new WaitForSeconds(1);
        charHolder.text = null;
    }*/
    public void enterEvent()
    {
        if (charHolder.text == "17703")  //  keypad password
        {
            charHolder.text = "CORRECT";
            PostProcessVolume ppVolume = Camera.main.gameObject.GetComponent<PostProcessVolume>();
            ppVolume.enabled = !ppVolume.enabled;
            keypad.SetActive(false);
            AudioListener.pause = false;
            Time.timeScale = 1;
            playerScript.enabled = true;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            charHolder.text = null;

            //  Finds GameObject named "door" and grabs its component <DoorNew.cs>
            GameObject.Find("door").GetComponent<DoorNew>().UnlockDoor();
            Debug.Log("Success");   //  activate the door or smth
        }
        else
        {
            /*const string errorMessage = "ERROR";
            StartCoroutine(ShowError(errorMessage));*/
            charHolder.text = null;
        }
    }
    public void exitEvent()
    {
        PostProcessVolume ppVolume = Camera.main.gameObject.GetComponent<PostProcessVolume>();
        ppVolume.enabled = !ppVolume.enabled;
        keypad.SetActive(false);
        AudioListener.pause = false;
        Time.timeScale = 1;
        playerScript.enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
