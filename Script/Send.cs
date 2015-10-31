using UnityEngine;
using System.Collections;
public class Send : MonoBehaviour {


	public static int cube1=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public int OnBecameInvisible(){
		print ("lost" + this);
		cube1--;
		return cube1;
	}
	
	public int OnBecameVisible(){
		print ("found" + this);
		cube1++;
		return cube1;
	}
}