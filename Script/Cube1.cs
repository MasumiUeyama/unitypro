using UnityEngine;
using System.Collections;
public class Cube1 : MonoBehaviour {
	
	
	public static int cube1=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public int OnBecameInvisible(){
		//print ("lost" + this);
		return cube1 = 0;
	}
	
	public int OnBecameVisible(){
		//print ("found" + this);
		return cube1 = 1;
	}
}