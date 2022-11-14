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
        Debug.Log("[CheckWristMenu] ��ġ�̺�Ʈ�鰨");

        if (wall.activeSelf)
        {
            Debug.Log("[CheckWristMenu] �������");

            wall.SetActive(false);
        }
        else
        {
            Debug.Log("[CheckWristMenu] ������");

            wall.SetActive(true);
        }
    }
}
