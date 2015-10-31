using UnityEngine;
using System.Collections;
public class Obj19 : MonoBehaviour {
	
	public static int obj19=0;
	void Start () {
		
	}
	void Update () {
		
	}
	public int OnBecameInvisible(){
		return obj19 = 0;
	}
	
	public int OnBecameVisible(){
		return obj19 = 1;
	}
}