using UnityEngine;
using System.Collections;

public class PlayerMoveScript : MonoBehaviour {
	
	GameObject cam;
	GameObject player;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	//finds the Main Camera object and assigns it to a variable
	cam = GameObject.Find("Main Camera");
	player = GameObject.Find("PlayerProto17");
	//this gets the camera to follow the player
	cam.transform.position = new Vector3(GameObject.Find("PlayerProto17").transform.position.x+2,1,GameObject.Find("PlayerProto17").transform.position.z);
	//animates the character
	cam.transform.LookAt(GameObject.Find("PlayerProto17").transform.position);
	//This currently makes the camera rotate around the world origin
	cam.transform.RotateAround(Vector3.zero,Vector3.up*System.Convert.ToInt32(Input.GetKey("q")),1);
	cam.transform.RotateAround(Vector3.zero,Vector3.up*(-1)*System.Convert.ToInt32(Input.GetKey("e")),1);
	
	
		
		if (Input.GetAxis("Vertical") >= 0.2)
       animation.CrossFade ("Run");
   else
      animation.CrossFade("Idle");
		
	transform.Translate((Input.GetAxis("Horizontal")/100), 0, (Input.GetAxis ("Vertical")/100));
	//Have the camera face the player
		
		
}
}