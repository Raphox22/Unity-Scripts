using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseLightScript : MonoBehaviour
{
    
    public int LightMode;
    public GameObject HouseLight;


    void Update()
    {
        if ( LightMode == 0 )
        {
            StartCoroutine(AnimateLight());

        }

    }

    IEnumerator AnimateLight ()
    {
        LightMode = Random.Range(1, 3);
        if ( LightMode == 1 )
        {

            HouseLight.GetComponent<Animation>().Play("HouseLightFlash");

        }
        if (LightMode == 2)
        {

            HouseLight.GetComponent<Animation>().Play("HouseLightFlash2");

        }
        yield return new WaitForSeconds (0.99f);
        LightMode = 0;
    }

}
