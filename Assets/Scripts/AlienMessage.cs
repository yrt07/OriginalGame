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
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(txt_speed());
    }

    // Update is called once per frame
    void Update()
    {
        if (alien_msg.text == font[i])
        {
            button.SetActive(true);
        }
        else
        {
            button.SetActive(true);
        }

        //button.SetActive(true);
    }

    /*public void msg_start()
    {
        StartCoroutine(txt_speed());

    }

    public void msg_Updata()
    {
        button.SetActive(true);

    }*/

    IEnumerator txt_speed()
    {
        foreach (char l in font[i].ToCharArray())
        {
            alien_msg.text += l;
            yield return new WaitForSeconds(0.1f);

        }
    }

    public void goToNextMessage()
    {
        if (i < font.Length - 1)
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
