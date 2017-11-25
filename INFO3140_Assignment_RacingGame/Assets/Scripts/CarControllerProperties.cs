using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControllerProperties : MonoBehaviour {

    public float carSpeedMotion;
    public float maxCarPosition = 1.77f;
    Vector3 position;
    public UiManager uiManagerComponent;


	// Use this for initialization
	void Start () {
        //ui = GetComponent<UiManager>();
        position = transform.position;

	}
	
	// Update is called once per frame
	void Update () {

        position.x += Input.GetAxis("Horizontal") * carSpeedMotion * Time.deltaTime;

        position.x =  Mathf.Clamp(position.x, -1.7f, 1.77f);

        transform.position = position;

	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy Vehicle")
        {
            Destroy(gameObject);
            uiManagerComponent.GameOverAction();
        }
    }

}
