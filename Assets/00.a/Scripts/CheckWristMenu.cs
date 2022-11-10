using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWristMenu : MonoBehaviour
{
    public GameObject button;
    public GameObject wall;

    public void LookWrist()
    {
        button.gameObject.layer = 0;
        button.SetActive(true);
    }

    public void LookWristOut()
    {
        button.SetActive(false);
    }

    public void TouchBu()
    {
        Debug.Log("ÅÍÄ¡ÀÌº¥Æ®µé°¨");

        if (wall.activeSelf)
        {
            Debug.Log("º® ¼û±è");

            wall.SetActive(false);
        }
        else
        {
            Debug.Log("º® ³ª¿È");

            wall.SetActive(true);
        }

    }
}
