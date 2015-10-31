using UnityEngine;
using System.Collections;
public class Obj07 : MonoBehaviour {
	
	public static int obj07=0;
	void Start () {
		
	}
	void Update () {
		
	}
	public int OnBecameInvisible(){
		return obj07 = 0;
	}
	
	public int OnBecameVisible(){
		return obj07 = 1;
	}
}