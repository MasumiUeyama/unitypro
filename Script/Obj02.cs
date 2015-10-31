using UnityEngine;
using System.Collections;
public class Obj02 : MonoBehaviour {
	
	public static int obj02=0;
	void Start () {
		
	}
	void Update () {
		
	}
	public int OnBecameInvisible(){
		return obj02 = 0;
	}
	
	public int OnBecameVisible(){
		return obj02 = 1;
	}
}