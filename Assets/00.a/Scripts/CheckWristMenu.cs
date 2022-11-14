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
        Debug.Log("[CheckWristMenu] 터치이벤트들감");

        if (wall.activeSelf)
        {
            Debug.Log("[CheckWristMenu] 벽사라짐");

            wall.SetActive(false);
        }
        else
        {
            Debug.Log("[CheckWristMenu] 벽생김");

            wall.SetActive(true);
        }
    }
}
