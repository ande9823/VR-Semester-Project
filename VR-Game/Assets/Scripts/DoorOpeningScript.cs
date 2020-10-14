﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpeningScript : MonoBehaviour
{
    // the speed the door should open with
    public float speed = 1;
    // the position of the door when open
    public float xPos;
    public float yPos;
    public float zPos;


    // Update is called once per frame
    void Update()
    {
        //the script that opens the door
        this.transform.position = Vector3.MoveTowards(this.transform.position, new Vector3(xPos, yPos, zPos), Time.deltaTime * speed);
    }
}