using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class regimeСhange : MonoBehaviour
{
    public GameObject text;

    public void OnClick()
    {
        transform.GetComponent<Cam>().enabled = false;
        transform.GetComponent<movementCam>().Star();

        text.SetActive(true);
    } 

    public void OffClick()
    {
        transform.GetComponent<Cam>().enabled = true;
        text.SetActive(false);
    }
}
