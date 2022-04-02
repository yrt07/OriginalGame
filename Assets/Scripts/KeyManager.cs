using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyManager : MonoBehaviour
{
    [SerializeField] Image[] Keyimage;

    public int keyNum;
    public void addkey()
    {
        Debug.Log("addkey");

        keyNum++;
        showkey(keyNum);

    }
    private void showkey(int num)
    {
        for (int i = 0; i < 1; i++)
        {
            if (i < num)
            {
                Keyimage[i].color = Color.white;

            }
            else
            {
                Keyimage[i].color = Color.black;

            }

        }


    }
    // Start is called before the first frame update
    void Start()
    {
        showkey(keyNum);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
