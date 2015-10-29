using UnityEngine;
using System.Collections;
using Vuforia;

public class Main : MonoBehaviour {
	public Cube1 cube1;
	public Cube2 cube2;
	public Ball1 ball1;
	public Ball2 ball2;
	public Ball1 ball3;
	public Ball2 ball4;
	public Unity1 unity1;
	public Unity2 unity2;
	private GUIStyle m_guiStyle;
	private GUIStyleState m_styleState;
	GameObject kaiten1;
	GameObject kaiten2;
	GameObject kaiten3;
	GameObject kaiten4;
	GameObject kaiten5;
	GameObject kaiten6;
	public static int cube=0;
	public static int fball1=0;
	public static int fball2=0;
	public static int flg1=0;
	public static int flg2=0;
	public static int flg3=0;
	public AudioClip audioClip;
	AudioSource audioSource;

	void Start() {
		//Ssend = GetComponent<Script1>();
		//print ("Trac");
		//someScript = Send.GetComponent<SomeScript> ();
		kaiten1 = GameObject.Find ("Cube1");
		kaiten2 = GameObject.Find ("Cube2");
		kaiten3 = GameObject.Find ("Ball1");
		kaiten4 = GameObject.Find ("Ball2");
		kaiten5 = GameObject.Find ("Ball3");
		kaiten6 = GameObject.Find ("Ball4");
		m_guiStyle = new GUIStyle();
		m_guiStyle.fontSize = 999;
		
		m_styleState = new GUIStyleState();
		m_styleState.textColor = Color.red;   // 文字色の変更.
		m_guiStyle.normal = m_styleState;
		audioSource = gameObject.GetComponent<AudioSource>();
		audioSource.clip = audioClip;
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
		if (Cube1.cube1 == 1 && Cube2.cube2 == 1) {
			print ("Cubeが二個でてます");
			cube = 1;
			kaiten1.transform.Rotate(2,3,2);
			kaiten2.transform.Rotate(2,3,2);
			if (flg1 == 0) {
				audioSource.PlayOneShot (audioClip, 0.7F);
				flg1 = 1;
			}
		} else {
			print ("でてないです");
			cube = 0;
			flg1=0;
		}
	


		if (Ball1.ball1 == 1 && Ball2.ball2 == 1) {
			print ("Ballが二個でてます");
			fball1 = 1;
			kaiten3.transform.Rotate(2,3,2);
			kaiten4.transform.Rotate(2,3,2);
			if (flg2 == 0) {
				audioSource.PlayOneShot (audioClip, 0.7F);
				flg2 = 1;
			}
		} else {
			print ("たまでてないです");
			fball1 = 0;
			flg2=0;
		}

		if (Ball3.ball3 == 1 && Ball4.ball4 == 1) {
			print ("Ball2が二個でてます");
			fball2 = 1;
			kaiten5.transform.Rotate(2,3,2);
			kaiten6.transform.Rotate(2,3,2);
			if (flg3 == 0) {
				audioSource.PlayOneShot (audioClip, 0.7F);
				flg3 = 1;
			}
		} else {
			print ("たまでてないです");
			fball2 = 0;
			flg3=0;
		}


}

	void OnGUI(){
		if (Cube1.cube1 == 1 && Cube2.cube2 == 1) {
			GUI.Label (new Rect (90, 40, 80, 20), "正　 解", m_guiStyle);
		} else if(Ball1.ball1 == 1 && Ball2.ball2 == 1) {
			GUI.Label (new Rect (90, 40, 80, 20), "正　 解", m_guiStyle);
		} else {
			GUI.Label(new Rect(90, 40, 80, 20), "し　 ね", m_guiStyle);
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