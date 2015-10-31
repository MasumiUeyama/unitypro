using UnityEngine;
using System.Collections;
public class Obj05 : MonoBehaviour {
	
	public static int obj05=0;
	void Start () {
		
	}
	void Update () {
		
	}
	public int OnBecameInvisible(){
		return obj05 = 0;
	}
	
	public int OnBecameVisible(){
		return obj05 = 1;
	}
}