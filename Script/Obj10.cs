using UnityEngine;
using System.Collections;
public class Obj10 : MonoBehaviour {
	
	public static int obj10=0;
	void Start () {
		
	}
	void Update () {
		
	}
	public int OnBecameInvisible(){
		return obj10 = 0;
	}
	
	public int OnBecameVisible(){
		return obj10 = 1;
	}
}