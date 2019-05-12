using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundSound : MonoBehaviour
{
    public  GameObject[] NotDestroyedSounds;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        NotDestroyedSounds = GameObject.FindGameObjectsWithTag("background sound");
        if (NotDestroyedSounds.Length > 1)
        {
            Destroy(NotDestroyedSounds[1]);
        }
    }
}
