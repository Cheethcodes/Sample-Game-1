﻿/*
 * 
 *  Author:         Gabriel Hansley Chong Suarez
 *  Date Created:   December 4, 2018
 *  Notes:          Timer for level
 * 
 */
 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {

    public GameObject retryMenu, player;
    Animator anim;
    public Text displayTime;

    float timeBase = 120.00f;

    void Start()
    {
        anim = player.GetComponent<Animator>();
    }

	void Update () {
        if (anim.GetBool("isWin") == false){

            timeBase -= Time.deltaTime;

            if (timeBase <= 0)
            {
                retryMenu.SetActive(true);
            }
        }
        else
        {
            timeBase += 0;
        }

        displayTime.text = timeBase.ToString();
	}
}
