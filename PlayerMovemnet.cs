using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemnet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftArrow));
        {
            Vector3 Position = this.transform.position;
            Position.x--;
            this.transform.position = Position;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector3 Position = this.transform.position;
            Position.x++;
            this.transform.position = Position;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 Position = this.transform.position;
            Position.y++;
            this.transform.position = Position;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector3 Position = this.transform.position;
            Position.y--;
            this.transform.position = Position;
        }

	}
}
