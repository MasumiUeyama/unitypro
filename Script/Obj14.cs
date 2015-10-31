using UnityEngine;
using System.Collections;
public class Obj14 : MonoBehaviour {
	
	public static int obj14=0;
	void Start () {
		
	}
	void Update () {
		
	}
	public int OnBecameInvisible(){
		return obj14 = 0;
	}
	
	public int OnBecameVisible(){
		return obj14 = 1;
	}
}