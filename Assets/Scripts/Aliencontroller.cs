﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Aliencontroller : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame

    bool IsNear;
    public int Alian_Message;
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F2))
        {

            if (IsNear)
            {
                Debug.Log("カギGet!");

                //GameObject AlienMessage = GameObject.Find("MessagePanel_a").GetComponent<AlienMessage>();

                //AlienMessage.StartCoroutine("txt_speed");



            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            IsNear = true;

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            IsNear = false;
        }
    }


}

