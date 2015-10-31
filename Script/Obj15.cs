using UnityEngine;
using System.Collections;
public class Obj15 : MonoBehaviour {
	
	public static int obj15=0;
	void Start () {
		
	}
	void Update () {
		
	}
	public int OnBecameInvisible(){
		return obj15 = 0;
	}
	
	public int OnBecameVisible(){
		return obj15 = 1;
	}
}