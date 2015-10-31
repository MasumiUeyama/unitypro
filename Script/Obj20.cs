using UnityEngine;
using System.Collections;
public class Obj20 : MonoBehaviour {
	
	public static int obj20=0;
	void Start () {
		
	}
	void Update () {
		
	}
	public int OnBecameInvisible(){
		return obj20 = 0;
	}
	
	public int OnBecameVisible(){
		return obj20 = 1;
	}
}