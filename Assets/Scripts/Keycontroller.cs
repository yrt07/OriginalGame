using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keycontroller : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            GameObject key_Num = GameObject.Find("Key_Image");
            key_Num.GetComponent<KeyManager>().addkey();

            Destroy(gameObject);

        }
    }
}
