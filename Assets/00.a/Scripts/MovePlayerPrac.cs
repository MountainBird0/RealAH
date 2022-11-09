using Autohand;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerPrac : MonoBehaviour
{
    public GameObject player;

    public List<GameObject> point;

    AutoHandPlayer playerBody;

    private void Start()
    {
        playerBody = FindObjectOfType<AutoHandPlayer>();
    }


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            //player.transform.position = point[0].transform.position;
            playerBody.SetPosition(point[0].transform.position);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //player.transform.position = point[1].transform.position;
            playerBody.SetPosition(point[1].transform.position);

        }
    }
}
