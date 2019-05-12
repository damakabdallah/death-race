using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarAI : MonoBehaviour
{
    private float carSpeed = 10f;
    // Update is called once per frame
    void Update()
    {
        transform.position-=new Vector3(0,carSpeed*Time.deltaTime,0);
    }
    
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
