using UnityEngine;
using System.Collections;
[ExecuteInEditMode]
public class RotateObject : MonoBehaviour {
	
	float speed = 20.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0,speed * Time.deltaTime,0);
	}
}
