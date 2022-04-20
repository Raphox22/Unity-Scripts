using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpFlashlight : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject FakeFlashlight;
    public GameObject RealFlashlight;
    public GameObject InvisibleWall;


    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;


    }

    void OnMouseOver ()
    {
        if (TheDistance <= 4)
        {
            ActionDisplay.SetActive (true);
            ActionText.SetActive (true);
            ActionText.GetComponent<Text>().text = "Pick up Flashlight";

        }
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 4)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive (false);
                ActionText.SetActive (false);
                FakeFlashlight.SetActive (false);
                RealFlashlight.SetActive (true);
                InvisibleWall.SetActive (false);

            }


        }
        if (TheDistance >= 4.1)
        {
            ActionDisplay.SetActive(false);
            ActionText.SetActive(false);


        }

    }
    void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);

    }
}
