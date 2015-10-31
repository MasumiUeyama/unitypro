using UnityEngine;
using System.Collections;
public class Obj08 : MonoBehaviour {
	
	public static int obj08=0;
	void Start () {
		
	}
	void Update () {
		
	}
	public int OnBecameInvisible(){
		return obj08 = 0;
	}
	
	public int OnBecameVisible(){
		return obj08 = 1;
	}
}