using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SelecionaFulanoFacebook : MonoBehaviour {

	private bool fulanoLogado;
	public Text nomeFulanoFacebook;
	public GameObject escolhaSeuFulano;
	private Sprite fotoFulanoFacebook;

	// Use this for initialization
	void Start () {
		fulanoLogado = true;
	
	}

	public void SelectFriendFacebook(){
		if(fulanoLogado){
			//gameObject.GetComponent<Image>().sprite = fotoFulanoFacebook;
			nomeFulanoFacebook.text = "Nome do Fulano";
			escolhaSeuFulano.SetActive(true);


		}

	}

	// Update is called once per frame
	void Update () {
		
	}
}
