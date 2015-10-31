using UnityEngine;
using System.Collections;
public class Obj09 : MonoBehaviour {
	
	public static int obj09=0;
	void Start () {
		
	}
	void Update () {
		
	}
	public int OnBecameInvisible(){
		return obj09 = 0;
	}
	
	public int OnBecameVisible(){
		return obj09 = 1;
	}
}