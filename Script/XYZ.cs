using UnityEngine;
using System.Collections;

public class XYZ : MonoBehaviour {

	public float x = 0.0f;
	public float z = 0.0f;
	
	// Use this for initialization
	void Start () {
		//Debug.Log("Hello World!"+ transform.localPosition.x);
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("Hello World!"+ transform.localPosition.x);
		if (Input.GetKey(KeyCode.RightArrow)) {
			x = 15f;
			z = 0.0f;
			
		}
		if (Input.GetKey(KeyCode.LeftArrow)) {
			x = -15f;
			z =  0.0f;
		}
		
		transform.Translate(x, 0, 0, Space.World);
		
		
		if (Input.GetKey(KeyCode.UpArrow)) {
			z = 15f;
			x = 0.0f;
			
		}
		if (Input.GetKey(KeyCode.DownArrow)) {
			z = -15f;
			x =  0.0f;
		}
		
		transform.Translate(0, 0, z, Space.World);
	}
}
