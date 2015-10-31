using UnityEngine;
using System.Collections;
public class Obj06 : MonoBehaviour {
	
	public static int obj06=0;
	void Start () {
		
	}
	void Update () {
		
	}
	public int OnBecameInvisible(){
		return obj06 = 0;
	}
	
	public int OnBecameVisible(){
		return obj06 = 1;
	}
}