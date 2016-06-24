using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AmigoFacebook : MonoBehaviour {


	public Text nomeAmigoFacebook;
	public Image fotoAmigoFacebook;
	// Use this for initialization
	void Start () {

	}

	//método que pega a foto e nome do amigo selecionado
	public void clicou(){
		//GameObject.Find("NomeFulano").SetActive(true);
		GameObject.Find("popUpEscolhaOSeuFulano").SetActive(false);
		GameObject.Find("facebook").SetActive(false);
		//GameObject.Find("fotoFulano").SetActive(true);
		GameObject.Find("NomeFulano").GetComponent<Text>().text = nomeAmigoFacebook.text;
		GameObject.Find("fotoFulano").GetComponent<Image>().sprite = fotoAmigoFacebook.sprite;
		;

	}
	// Update is called once per frame
	void Update () {
	
	}


}
