using UnityEngine;
using System.Collections;
using Vuforia;

public class Main : MonoBehaviour {
	public Obj01 Obj01;
	public Obj02 Obj02;
	public Obj03 Obj03;
	public Obj04 Obj04;
	public Obj05 Obj05;
	public Obj06 Obj06;
	public Obj07 Obj07;
	public Obj08 Obj08;
	public Obj09 Obj09;
	public Obj10 Obj10;
	public Obj11 Obj11;
	public Obj12 Obj12;
	public Obj13 Obj13;
	public Obj14 Obj14;
	public Obj15 Obj15;
	public Obj16 Obj16;
	public Obj17 Obj17;
	public Obj18 Obj18;
	public Obj19 Obj19;
	public Obj20 Obj20;
	private GUIStyle m_guiStyle;
	private GUIStyleState m_styleState;
	GameObject kaiten01;
	GameObject kaiten02;
	GameObject kaiten03;
	GameObject kaiten04;
	GameObject kaiten05;
	GameObject kaiten06;
	GameObject kaiten07;
	GameObject kaiten08;
	GameObject kaiten09;
	GameObject kaiten10;
	GameObject kaiten11;
	GameObject kaiten12;
	GameObject kaiten13;
	GameObject kaiten14;
	GameObject kaiten15;
	GameObject kaiten16;
	GameObject kaiten17;
	GameObject kaiten18;
	GameObject kaiten19;
	GameObject kaiten20;
	public static int flg=0;
	public static int SoundFlg1=0;
	public static int SoundFlg2=0;

	public AudioClip audioClip;
	AudioSource audioSource;
	public AudioClip2 audioClip2;
	AudioSource2 audioSource2;
	
	public static int num;
	
	void Start() {
		//Ssend = GetComponent<Script1>();
		//print ("Trac");
		//someScript = Send.GetComponent<SomeScript> ();
		kaiten01 = GameObject.Find ("Obj01");
		kaiten02 = GameObject.Find ("Obj02");
		kaiten03 = GameObject.Find ("Obj03");
		kaiten04 = GameObject.Find ("Obj04");
		kaiten05 = GameObject.Find ("Obj05");
		kaiten06 = GameObject.Find ("Obj06");
		kaiten07 = GameObject.Find ("Obj07");
		kaiten08 = GameObject.Find ("Obj08");
		kaiten09 = GameObject.Find ("Obj09");
		kaiten10 = GameObject.Find ("Obj10");
		kaiten11 = GameObject.Find ("Obj11");
		kaiten12 = GameObject.Find ("Obj12");
		kaiten13 = GameObject.Find ("Obj13");
		kaiten14 = GameObject.Find ("Obj14");
		kaiten15 = GameObject.Find ("Obj15");
		kaiten16 = GameObject.Find ("Obj16");
		kaiten17 = GameObject.Find ("Obj17");
		kaiten18 = GameObject.Find ("Obj18");
		kaiten19 = GameObject.Find ("Obj19");
		kaiten20 = GameObject.Find ("Obj20");
		m_guiStyle = new GUIStyle();
		m_guiStyle.fontSize = 999;
		
		m_styleState = new GUIStyleState();
		m_styleState.textColor = Color.red;   // 文字色の変更.
		m_guiStyle.normal = m_styleState;

		audioSource = gameObject.GetComponent<AudioSource>();
		audioSource.clip = audioClip;
		audioSource2 = gameObject.GetComponent<AudioSource2>();
		audioSource.clip2 = audioClip2;
	}
	void Update() {
		//Destroy(Cube1, 2.0f);
		//if (Cube1 == null) {
		//}
		//Send one1 = Cube2.GetComponent<Send>().OnBecameInvisible();
		//a = one1.OnBecameInvisible ();
		//print ("Cube1");
		//print("Cube2 = "+ Cube2.transform.position.x + Cube2.transform.localPosition.y + Cube2.transform.localPosition.z);
		//Cube2.Rotate(45, 90, 180);
		//print(Cube1.cube1);
		//print(Cube2.cube2);
		
		
		
		num = Obj01.obj01 + Obj02.obj02
			+ Obj03.obj03 + Obj04.obj04
			+ Obj05.obj05 + Obj06.obj06
			+ Obj07.obj07 + Obj08.obj08
			+ Obj09.obj09 + Obj10.obj10
			+ Obj11.obj11 + Obj12.obj12
			+ Obj13.obj13 + Obj14.obj14
			+ Obj15.obj15 + Obj16.obj16
			+ Obj17.obj17 + Obj18.obj18
			+ Obj19.obj19 + Obj20.obj20;
			
		if(num != 2) SoundFlg2 = 0;
		
		if (Obj01.obj01 == 1 && Obj02.obj02 == 1) {
			flg = 1;
		} else if(Obj03.obj03 == 1 && Obj04.obj04 == 1) {
			flg = 2;
		} else if(Obj05.obj05 == 1 && Obj06.obj06 == 1) {
			flg = 3;
		} else if(Obj07.obj07 == 1 && Obj08.obj08 == 1) {
			flg= 4;
		} else if(Obj09.obj09 == 1 && Obj10.obj10 == 1) {
			flg = 5;
		} else if(Obj11.obj11 == 1 && Obj12.obj12 == 1) {
			flg = 6;
		} else if(Obj14.obj14 == 1 && Obj13.obj13 == 1) {
			flg = 7;
		} else if(Obj15.obj15 == 1 && Obj16.obj16 == 1) {
			flg = 8;
		} else if(Obj17.obj17 == 1 && Obj18.obj18 == 1) {
			flg = 9;
		} else if(Obj19.obj19 == 1 && Obj20.obj20 == 1) {
			flg = 10;
		} else {
			if(num == 2) Sound2();
			flg=0;
		}
		
		if(flg==1){
			kaiten01.transform.Rotate(2,3,2);
			kaiten02.transform.Rotate(2,3,2);
			Sound1();
			
		} else if(flg==2){
			kaiten03.transform.Rotate(2,3,2);
			kaiten04.transform.Rotate(2,3,2);
			Sound1();
			
		} else if(flg==3){
			kaiten05.transform.Rotate(2,3,2);
			kaiten06.transform.Rotate(2,3,2);
			Sound1();
			
		} else if(flg==4){
			kaiten07.transform.Rotate(2,3,2);
			kaiten08.transform.Rotate(2,3,2);
			Sound1();
			
		} else if(flg==5){
			kaiten09.transform.Rotate(2,3,2);
			kaiten10.transform.Rotate(2,3,2);
			Sound1();
			
		} else if(flg==6){
			kaiten11.transform.Rotate(2,3,2);
			kaiten12.transform.Rotate(2,3,2);
			Sound1();
			
		} else if(flg==7){
			kaiten13.transform.Rotate(2,3,2);
			kaiten14.transform.Rotate(2,3,2);
			Sound1();
			
		} else if(flg==8){
			kaiten15.transform.Rotate(2,3,2);
			kaiten16.transform.Rotate(2,3,2);
			Sound1();
			
		} else if(flg==9){
			kaiten17.transform.Rotate(2,3,2);
			kaiten18.transform.Rotate(2,3,2);
			Sound1();
			
		} else if(flg==10){
			kaiten19.transform.Rotate(2,3,2);
			kaiten20.transform.Rotate(2,3,2);
			Sound1();
			
		} else {
			SoundFlg1 = 0;
		}
		
	}
	
	void OnGUI(){
		
		if(flg != 0){
			GUI.Label (new Rect (90, 40, 80, 20), "あたり", m_guiStyle);
		} else {
			GUI.Label(new Rect(90, 40, 80, 20), "はずれ", m_guiStyle);
		}
	}
	
	void Sound1(){
		if (SoundFlg1 == 0) {
			audioSource.PlayOneShot (audioClip, 0.7F);
			SoundFlg1 = 1;
		}
	}

	void Sound2(){
		if (SoundFlg2 == 0) {
			audioSource.PlayOneShot (audioClip2, 0.7F);
			SoundFlg2 = 1;
		}
	}
	//public void OnBecameVisible(){
	//	print (Cube1);
	//}
	/**
	// Use this for initialization
	void Start () {
		Cube1 = GameObject.Find("Cube1");
		Cube2 = GameObject.Find("Cube2");
	}
	
	// Update is called once per frame
	void Update () {
		print("unity1 = "+ Cube1.transform.localPosition.x + Cube1.transform.localPosition.y + Cube1.transform.localPosition.z);
		print("Cube2 = "+ Cube2.transform.localPosition.x + Cube2.transform.localPosition.y + Cube2.transform.localPosition.z);
		//GameObject[] objs = GameObject.FindGameObjectsWithTag("unity");
		//foreach(GameObject obj in objs){
		//}
		//print (a);
	}
	**/
}
