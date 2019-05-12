using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeChanger : MonoBehaviour
{
    // Start is called before the first frame update
   /* void Start()
    {
        slider.minValue = 0;
        slider.maxValue = 100;
        slider.value = slider.maxValue;
        audioSource = GameObject.FindWithTag("background sound").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        audioSource.volume = slider.value/100;
    }*/
   public void SaveVolumeChanger(Slider slider)
   {
       AudioSource audioSource = GameObject.FindWithTag("background sound").GetComponent<AudioSource>();
       if(audioSource==null)
           return;
       else
       {
           slider.minValue = 0;
           slider.maxValue = 1;
           audioSource.volume = slider.value;
           PlayerPrefs.SetFloat("volume",slider.value);
       }
   }
   public void LoadVolumeChanger(Slider slider)
   {
       AudioSource audioSource = GameObject.FindWithTag("background sound").GetComponent<AudioSource>();
       if(audioSource==null)
           return;
       else
       {
           slider.minValue = 0;
           slider.maxValue = 1;
           float testVolume=PlayerPrefs.GetFloat("volume");
           if (audioSource.volume == testVolume)
           {
               audioSource.volume = testVolume;
               slider.value = testVolume;
           }
               
       }
   }
}
