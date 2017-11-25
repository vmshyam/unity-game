using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleSpawningLocation : MonoBehaviour {

    public GameObject[] vehicles;
    int vehicleIndexNum;
    public float maxVehiclePosition = 1.77f;
    public float[] randomPosition = new float[] { -1.30f, -0.45f, 0.50f, 1.40f };
    public float delayTimer = 1f;
    float carSpawnTimer;

    // Use this for initialization
    void Start () {
        carSpawnTimer = delayTimer;
        //Vector3 vehiclePosition = new Vector3(Random.Range(-1.77f, 1.77f), transform.position.y, transform.position.z);
        
	}
	
	// Update is called once per frame
	void Update () {

        carSpawnTimer -= Time.deltaTime;

        if (carSpawnTimer <= 0)
        {
            Vector3 vehiclePosition = new Vector3(randomPosition[Random.Range(0, randomPosition.Length)], transform.position.y, transform.position.z);
            vehicleIndexNum = Random.Range(0,5);
            Instantiate(vehicles[vehicleIndexNum], vehiclePosition, transform.rotation);
            carSpawnTimer = delayTimer;
        }



    }
}
