using UnityEngine;
using System.Collections;
public class Obj12 : MonoBehaviour {
	
	public static int obj12=0;
	void Start () {
		
	}
	void Update () {
		
	}
	public int OnBecameInvisible(){
		return obj12 = 0;
	}
	
	public int OnBecameVisible(){
		return obj12 = 1;
	}
}