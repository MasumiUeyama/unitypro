using UnityEngine;
using System.Collections;
public class Obj13 : MonoBehaviour {
	
	public static int obj13=0;
	void Start () {
		
	}
	void Update () {
		
	}
	public int OnBecameInvisible(){
		return obj13 = 0;
	}
	
	public int OnBecameVisible(){
		return obj13 = 1;
	}
}