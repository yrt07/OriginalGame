using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class JewelManager : MonoBehaviour
{
    [SerializeField] Image[] jewelImages;
    public int jewelNum;
    public void addjewel()
    {
        Debug.Log("addjewel");
        jewelNum++;
        showjewel(jewelNum);
    }
    private void showjewel(int num)
    {
        /*jewelImages[0].color = Color.white;
         jewelImages[1].color = Color.white;
         jewelImages[2].color = Color.black;*/

        for (int i = 0; i < 3; i++)
        {
            if (i < num)
            {
                jewelImages[i].color = Color.white;

            }
            else
            {
                jewelImages[i].color = Color.black;

            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //jewelNum = 1;
        showjewel(jewelNum);


    }

    // Update is called once per frame
    void Update()
    {

    }
}
