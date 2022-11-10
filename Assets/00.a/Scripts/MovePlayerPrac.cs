using Autohand;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerPrac : MonoBehaviour
{
    public List<GameObject> point;

    public AutoHandPlayer playerBody;


    private void Start()
    {
        // playerBody = FindObjectOfType<AutoHandPlayer>();
        Debug.Log(playerBody.name);
    }


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            playerBody.transform.position = point[0].transform.position;
            //playerBody.SetPosition(point[0].transform.position);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //playerBody.transform.position = point[1].transform.position;
            playerBody.SetPosition(point[1].transform.position);

        }
    }
}
