using UnityEngine;
using System.Collections;

public class Send : MonoBehaviour {
	int a=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public int OnBecameInvisible(){
		print ("lost" + this);
		return a;
	}
	
	public void OnBecameVisible(){
		print ("found" + this);
	}
}
