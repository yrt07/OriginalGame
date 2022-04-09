using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chestcontroller : MonoBehaviour
{
    public bool IsNear;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F3))
        {
            if (IsNear)
            {
                int key_Num = 0;

                GameObject key_Manager = GameObject.Find("Key_Image");
                key_Num = key_Manager.GetComponent<KeyManager>().keyNum;
                Debug.Log(key_Num);
                if (key_Num > 0)
                {

                    Debug.Log("チェストOPEN");
                    GetComponent<Animator>().SetBool("Is_Open", true);

                    //GameObject jewel_Num = GameObject.Find("Jewel_Images");
                    //jewel_Num.GetComponent<JewelManager>().addjewel();



                }

            }
        }
        /*if (Input.GetKeyDown(KeyCode.F4))
        {
            GetComponent<Animator>().SetBool("Is_Open", true);

        }*/
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
