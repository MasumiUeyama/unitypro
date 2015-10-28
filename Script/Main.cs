using UnityEngine;
using System.Collections;
using Vuforia;

public class Main : MonoBehaviour {
	public Cube1 cube1;
	public Cube2 cube2;
	public Unity1 unity1;
	public Unity2 unity2;
	public GUIStyleState styleState;
	private GUIStyle style;
	GameObject kaiten1;
	GameObject kaiten2;
	GameObject kaiten3;
	GameObject kaiten4;
	public static int cube=0;

	void Start() {
		//Ssend = GetComponent<Script1>();
		//print ("Trac");
		//someScript = Send.GetComponent<SomeScript> ();
		kaiten1 = GameObject.Find ("Cube1");
		kaiten2 = GameObject.Find ("Cube2");
		kaiten3 = GameObject.Find ("Unity1");
		kaiten4 = GameObject.Find ("Unity2");
		style = new GUIStyle();
		style.fontSize = 30;
	}
	void Update() {
		//Destroy(Cube1, 2.0f);
		//if (Cube1 == null) {
		//}
		//Send one1 = Cube2.GetComponent<Send>().OnBecameInvisible();
		//a = one1.OnBecameInvisible ();
		//print ("Cube1");
		//print("Cube2 = "+ Cube2.transform.position.x + Cube2.transform.localPosition.y + Cube2.transform.localPosition.z);
		//Cube2.Rotate(45, 90, 180);
		//print(Cube1.cube1);
		//print(Cube2.cube2);
		if (Cube1.cube1 == 1 && Cube2.cube2 == 1) {
			print ("Cubeが二個でてます");
			cube = 1;
			kaiten1.transform.Rotate(2,3,2);
			kaiten2.transform.Rotate(2,3,2);
		} else {
			print ("でてないです");
			cube = 0;
		}

		if (Unity1.unity1 == 1 && Unity2.unity2 == 1) {
			print ("unityが二個でてます");
			kaiten3.transform.Rotate(2,3,2);
			kaiten4.transform.Rotate(2,3,2);
		} else {
			print ("でてないです");
		}
		//print (./Vuforia/Scripts/DefaultTrackableEventHandler.OnTrackingFound())
	}

	void OnGUI()
	{
		if (cube == 1) {
			Rect rect = new Rect(10, 10, 400, 300);
			style.normal = styleState;
			GUI.Label(rect, "Cube揃ってるんですよ～", style);
		}
	}

	//public void OnBecameVisible(){
	//	print (Cube1);
	//}
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