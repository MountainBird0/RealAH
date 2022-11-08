using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMove : MonoBehaviour
{
    public Vector3 pressOffset;
    public GameObject button;

    public Color pressColor = Color.white;
    public Color unpressColor = Color.white;

    public void Press()
    {
        button.transform.localPosition += pressOffset;
        button.GetComponent<MeshRenderer>().material.color = pressColor;
    }

    public void UnPress()
    {
        button.transform.localPosition -= pressOffset;
        button.GetComponent<MeshRenderer>().material.color = unpressColor;
    }
}
