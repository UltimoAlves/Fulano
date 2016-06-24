using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Play : MonoBehaviour {
	public Text texto;
	public float tempo;
	public float tempo2;
	public bool contando;
	public float tempoReal;


	// Use this for initialization
	void Start () {
				
	}

	public void Contar(){
		
		contando = true;
	}


	// Update is called once per frame
	void Update () {
		if (!contando){
			tempoReal = Time.time;
		}
		else {
			tempo = Time.time - tempoReal;
		}
		texto.text = string.Format("{0:00}:{1:00}", tempo2, tempo);
	
	
	}
}
