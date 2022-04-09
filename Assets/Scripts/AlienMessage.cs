using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlienMessage : MonoBehaviour
{
    public Text alien_msg;
    public GameObject button;
    public string[] font;
    int i;
    public bool Is_speach;

    void Start()
    {
        //StartCoroutine(txt_speed());
    }


    void Update()
    {
        /*f (alien_msg.text == font[i])
         {
             button.SetActive(true);
         }
         else
         {
             button.SetActive(true);
         }

        button.SetActive(true);*/
    }

    public void msg_start()
    {
        StartCoroutine(txt_speed());

    }

    public void msg_Updata()
    {

        button.SetActive(true);

    }

    IEnumerator txt_speed()
    {
        Is_speach = true;

        foreach (char l in font[i].ToCharArray())
        {
            alien_msg.text += l;
            yield return new WaitForSeconds(0.1f);
            if (Is_speach == false)
            {
                break;
            }
        }
        alien_msg.text = font[i];
        Is_speach = false;
    }

    public void goToNextMessage()
    {
        if (Is_speach == true)
        {
            Is_speach = false;
        }
        else if (i < font.Length - 1)
        {
            i++;
            alien_msg.text = "";
            StartCoroutine(txt_speed());
        }
        else
        {
            alien_msg.text = "";

        }
    }
}
