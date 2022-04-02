using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemcontroller : MonoBehaviour
{
    // Start is called before the first frame update
    /*public void GetItem()
    {
        Destroy(this.gameObject);//仮処理
    }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("テスト");

        if (collision.gameObject.tag == "Player")
        {
            GameObject jewel_Num = GameObject.Find("Jewel_Images");
            /*Debug.Log(jewel_Num);
             Debug.Log(jewel_Num.GetComponent<JewelManager>());*/
            jewel_Num.GetComponent<JewelManager>().addjewel();

            Destroy(gameObject);

        }
    }

}
