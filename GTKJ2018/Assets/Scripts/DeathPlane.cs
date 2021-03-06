﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlane : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.GetComponent<EnemyFlierController>() && !collision.GetComponent<EnemyBase>())
        {
            Debug.Log("triggering death on " + collision.gameObject.name);
            if (collision.GetComponent<EnemyBase>() || collision.GetComponent<PlayerController>())
            {
                if (collision.GetComponent<PlayerController>() != null)
                {
                    collision.GetComponent<PlayerController>().deadPlaned = true;
                }
                collision.gameObject.SendMessage("Die");

            }
        }
        
        
    }
}
