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
        Debug.Log("��ġ�̺�Ʈ�鰨");

        if (wall.activeSelf)
        {
            Debug.Log("�� ����");

            wall.SetActive(false);
        }
        else
        {
            Debug.Log("�� ����");

            wall.SetActive(true);
        }

    }
}
