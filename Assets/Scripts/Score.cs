using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using  UnityEngine.UI;

public class Score : MonoBehaviour
{
    private GameObject player;
    private int score;
    public Text ScoreTXT;
    public AudioSource audioSource;

    private void Start()
    {
        player=GameObject.FindWithTag("Player");
    }

    private void Update()
    {
        if(player==null)
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        score++;
        ScoreTXT.text = "score : " + score;
        audioSource.Play();
          
        
    }
}
