using UnityEngine;
using System.Collections;

public class Ball2 : MonoBehaviour {
	//Animator animator;
	public static int ball2=0;
	// Use this for initialization
	void Start () {
		//animator = GetComponent (typeof(Animator)) as Animator;
	}
	
	// Update is called once per frame
	void Update () {
		//animator.Play("JumpToTop");
	}
	public int OnBecameInvisible(){
		//print ("lost" + this);
		return ball2 = 0;
	}
	
	public int OnBecameVisible(){
		//print ("found" + this);
		return ball2 = 1;
		
	}
}