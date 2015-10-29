using UnityEngine;
using System.Collections;
public class Ball4 : MonoBehaviour {
	
	
	public static int ball4=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public int OnBecameInvisible(){
		//print ("lost" + this);
		return ball4 = 0;
	}
	
	public int OnBecameVisible(){
		//print ("found" + this);
		return ball4 = 1;
	}
}