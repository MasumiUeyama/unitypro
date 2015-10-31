using UnityEngine;
using System.Collections;
public class Obj01 : MonoBehaviour {
	
	public static int obj01=0;
	void Start () {
		
	}
	void Update () {
		
	}
	public int OnBecameInvisible(){
		return obj01 = 0;
	}
	
	public int OnBecameVisible(){
		return obj01 = 1;
	}
}
