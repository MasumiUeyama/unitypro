using UnityEngine;
using System.Collections;
public class Ball1 : MonoBehaviour {
	
	
	public static int ball1=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public int OnBecameInvisible(){
		//print ("lost" + this);
		return ball1 = 0;
	}
	
	public int OnBecameVisible(){
		//print ("found" + this);
		return ball1 = 1;
	}
}