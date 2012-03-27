using UnityEngine;
using System.Collections;

public class CameraMoveScript : MonoBehaviour {
	//TODO: Move Main Camera around its parent, StageCenterpoint [ ]
	//		Move Main Camera around the player [ ]
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		
	//This currently makes the camera rotate around the world origin
	transform.RotateAround(Vector3.zero,Vector3.up*System.Convert.ToInt32(Input.GetKey("q")),1);
	transform.RotateAround(Vector3.zero,Vector3.up*(-1)*System.Convert.ToInt32(Input.GetKey("e")),1);
	//Moves the camera with the player
		//transform.Translate((Input.GetAxis("Horizontal")/100), 0, (Input.GetAxis ("Vertical")/100));

}
}