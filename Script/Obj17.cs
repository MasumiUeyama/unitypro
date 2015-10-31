using UnityEngine;
using System.Collections;
public class Obj17 : MonoBehaviour {
	
	public static int obj17=0;
	void Start () {
		
	}
	void Update () {
		
	}
	public int OnBecameInvisible(){
		return obj17 = 0;
	}
	
	public int OnBecameVisible(){
		return obj17 = 1;
	}
}