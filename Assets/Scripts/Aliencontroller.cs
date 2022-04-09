using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Aliencontroller : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame

    bool IsNear;
    public AlienMessage alianMessage;

    private void Start()
    {
        alianMessage.gameObject.SetActive(false);
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F2))
        {

            if (IsNear && alianMessage.gameObject.activeSelf == false)
            {
                alianMessage.gameObject.SetActive(true);
                //Debug.Log("カギGet!");
                //var Alien_Message = GameObject.Find("MessagePanel_a").GetComponent<AlienMessage>();

                alianMessage.msg_start();
                alianMessage.msg_Updata();
                //Alien_Message.goToNextMessage();



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

