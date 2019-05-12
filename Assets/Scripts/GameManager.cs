using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // set the AI vehicles positions
    Vector3[] positions =
    {
        new Vector3(-1.85f,6.5f,0),
        new Vector3(0.2f,6.5f,0),
        new Vector3(1.95f,6.5f,0)
    };
    public GameObject[] Vehicles;
    void Start()
    {
        StartCoroutine(instantiateVehicle());
    }

    IEnumerator instantiateVehicle()
    {
        //repeat every 1 second 
        yield return new WaitForSeconds(0.5f);
        //instantiate vehicle 
        int posINT = Random.Range(0, positions.Length);
        int vehicleINT = Random.Range(0, Vehicles.Length);
        Vector3 pos = positions[posINT];
        GameObject vehicle = Vehicles[vehicleINT];
        Instantiate(vehicle, pos,Quaternion.identity);
        StartCoroutine(instantiateVehicle());
    }
}
