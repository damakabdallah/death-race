using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerCtrl : MonoBehaviour
{
    public GameObject GameOver;
    public GameObject leftClickButton;
    public GameObject rightClickButton;
    private GameObject pauseButton;

    private void Start()
    {
        pauseButton = GameObject.FindGameObjectWithTag("pause button");
    }

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            
            if (gameObject.transform.position.x < 1.7f)
            {
                gameObject.transform.Translate(2f,0,0);
            }   
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (gameObject.transform.position.x > -1.7f)
            {
                gameObject.transform.Translate(-2f,0,0);
            }
        }
       
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        GameOver.SetActive(true);
        leftClickButton.SetActive(false);
        rightClickButton.SetActive(false);
        pauseButton.SetActive(false);
        Destroy(gameObject);
        Destroy(GameObject.Find("GameManager"));
    }

    public void RightClick(GameObject player)
    {
     
        if (player.transform.position.x < 1.7f)
        {
            player.transform.Translate(1.7f,0,0);
        }   
    }

    public void LeftClick(GameObject player)
    {
        
        
        if (player.transform.position.x > -1.7f)
        {
            player.transform.Translate(-1.7f,0,0);
        }
    }
}
