using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMovement : MonoBehaviour {

    // Use this for initialization
    public float carspeed;
    public float maxpos = 2.1F;
    public UIManager ui;
    Vector3 position;
	void Start () {
        position = transform.position;
        
    }
	
	// Update is called once per frame
	void Update () {

        position.x += Input.GetAxis("Horizontal")*carspeed*Time.deltaTime;

        position.x=Mathf.Clamp(position.x, -2.1F, maxpos);
        transform.position = position;
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="enemy")
        {
            Destroy(gameObject);
            ui.finish();
        }
    }
}
