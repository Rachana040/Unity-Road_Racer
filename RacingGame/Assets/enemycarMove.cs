using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycarMove : MonoBehaviour {

    // Use this for initialization
    public float speed = 5f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(new Vector3(0, 1, 0) * speed *Time.deltaTime);
	}
}
