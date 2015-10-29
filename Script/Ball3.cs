using UnityEngine;
using System.Collections;

public class Ball3 : MonoBehaviour {
	//Animator animator;
	public static int ball3=0;
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
		return ball3 = 0;
	}
	
	public int OnBecameVisible(){
		//print ("found" + this);
		return ball3 = 1;
		
	}
}