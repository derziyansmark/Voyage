﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotObj : MonoBehaviour 
{
	float rotSpeed = 15;
	void OnMouseDrag()
	{
        float rotX = Input.GetAxis("Mouse X")*rotSpeed*Mathf.Deg2Rad;
	    

		transform.RotateAround(Vector3.up, -rotX);
		
	}
}
