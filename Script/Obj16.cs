using UnityEngine;
using System.Collections;
public class Obj16 : MonoBehaviour {
	
	public static int obj16=0;
	void Start () {
		
	}
	void Update () {
		
	}
	public int OnBecameInvisible(){
		return obj16 = 0;
	}
	
	public int OnBecameVisible(){
		return obj16 = 1;
	}
}