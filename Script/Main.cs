using UnityEngine;
using System.Collections;
using Vuforia;

public class Main : MonoBehaviour {
	GameObject Find ;
	GameObject Cube1;
	GameObject Cube2;

	int a=0;
	
	void Start() {
		Cube1 = GameObject.Find("Cube1");
		Cube2 = GameObject.Find("Cube2");
		//print ("Trac");
		someScript = Send.GetComponent<SomeScript> ();
	}
	void Update() {
		//Destroy(Cube1, 2.0f);
		if (Cube1 == null) {
			print ("Cube1");
		}
		//a = a.GetComponent<Send>().OnBecameInvisible();
		//print ("Cube1");
		//print (Cube2);
	}


	/**
	// Use this for initialization
	void Start () {
		Cube1 = GameObject.Find("Cube1");
		Cube2 = GameObject.Find("Cube2");
	}
	
	// Update is called once per frame
	void Update () {
		print("unity1 = "+ Cube1.transform.localPosition.x + Cube1.transform.localPosition.y + Cube1.transform.localPosition.z);
		print("Cube2 = "+ Cube2.transform.localPosition.x + Cube2.transform.localPosition.y + Cube2.transform.localPosition.z);

		//GameObject[] objs = GameObject.FindGameObjectsWithTag("unity");
		//foreach(GameObject obj in objs){

		//}
		//print (a);

	}
	**/
}
