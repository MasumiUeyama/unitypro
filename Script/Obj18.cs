using UnityEngine;
using System.Collections;
public class Obj18 : MonoBehaviour {
	
	public static int obj18=0;
	void Start () {
		
	}
	void Update () {
		
	}
	public int OnBecameInvisible(){
		return obj18 = 0;
	}
	
	public int OnBecameVisible(){
		return obj18 = 1;
	}
}