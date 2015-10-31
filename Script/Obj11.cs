using UnityEngine;
using System.Collections;
public class Obj11 : MonoBehaviour {
	
	public static int obj11=0;
	void Start () {
		
	}
	void Update () {
		
	}
	public int OnBecameInvisible(){
		return obj11 = 0;
	}
	
	public int OnBecameVisible(){
		return obj11 = 1;
	}
}