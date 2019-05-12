using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCrashSound : MonoBehaviour
{
    private GameObject _player;
    // Update is called once per frame
    void Update()
    {
        _player = GameObject.FindWithTag("Player");
        if(_player==null)  
            gameObject.GetComponent<AudioSource>().Play();
    }
}
