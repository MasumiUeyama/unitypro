using UnityEngine;
using System.Collections;
public class Obj04 : MonoBehaviour {
	
	public static int obj04=0;
	void Start () {
		
	}
	void Update () {
		
	}
	public int OnBecameInvisible(){
		return obj04 = 0;
	}
	
	public int OnBecameVisible(){
		return obj04 = 1;
	}
}