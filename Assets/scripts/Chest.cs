using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chest : MonoBehaviour
{
    [SerializeField] Sprite defaultAnswerSprite;
    [SerializeField] Sprite correctAnswerSprite;

    void Start()
    {

    }


    void Update()
    {

    }

     void ClickingChest()
    {
        Debug.Log("chest clicked");
    }


   void OnClick()
    {
        Image buttonImage;

        if (ClickingChest())
        {
            buttonImage.sprite = correctAnswerSprite;
        }
        
    }

}
      
