﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchActionLeft : MonoBehaviour
{	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if(Input.GetMouseButtonDown(0)) {
			transform.Translate(transform.forward * 1.5f);
		}
    }
}
