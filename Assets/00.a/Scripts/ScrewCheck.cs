using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrewCheck : MonoBehaviour
{
    HingeJoint joint;


    void Start()
    {
        joint = GetComponent<HingeJoint>();

    }

    void Update()
    {
        //Debug.Log(joint.angle);        
    }

    //private void MoveScrew() // zรเ
    //{
        
    //}
}
