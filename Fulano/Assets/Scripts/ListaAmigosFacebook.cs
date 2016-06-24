using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class ListaAmigosFacebook : MonoBehaviour {

	public GameObject celula; 
	public GameObject table; 


	// Use this for initialization
	void Start () {

	}
	// Update is called once per frame
	void Update () {

	}
	//método para criar a lista de amigos, onde ele deverá escolher um
	public void newCell(){
		//	novaCelula.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = "recebe a foto de perfil do amigo";
		//	novaCelula.transform.GetChild(1).gameObject.GetComponent<Text>().text = "recebe o nome de perfil do amigo";

		GameObject  novaCelula =  Instantiate(celula, celula.transform.position, celula.transform.rotation) as GameObject;
		novaCelula.transform.parent = table.transform;
		novaCelula.transform.localScale = new Vector3 (1f, 1f, 1f);
	}

}
