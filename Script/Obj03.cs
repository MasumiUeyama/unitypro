using UnityEngine;
using System.Collections;
public class Obj03 : MonoBehaviour {
	
	public static int obj03=0;
	void Start () {
		
	}
	void Update () {
		
	}
	public int OnBecameInvisible(){
		return obj03 = 0;
	}
	
	public int OnBecameVisible(){
		return obj03 = 1;
	}
}