using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using Facebook.Unity;


public class FBscript : MonoBehaviour {
	public GameObject login;
	public GameObject logout;
	public GameObject userName;
	public GameObject foto;

	void Awake(){
		FB.Init(SetInit, OnHideUnity);	
	}

	void SetInit(){
		if(FB.IsLoggedIn){
			Debug.Log("Logado!");
		} else {
			Debug.Log("Nao logado");
		}
		DealWithFBMenus(FB.IsLoggedIn);

	}
	void OnHideUnity(bool isGameShown){
		if(!isGameShown){
			Time.timeScale = 0;
		} else{
			Time.timeScale = 1;
		}
	}
	public void FBLogin(){
		List<string> permissions = new List<string> ();
		permissions.Add("public_profile");
		FB.LogInWithReadPermissions(permissions, AuthCallBack);
	}
	void AuthCallBack(IResult result){
		if(result.Error != null){
			Debug.Log(result.Error);
		}else{
			if(FB.IsLoggedIn){
				Debug.Log("is logged in");
			} else {
				Debug.Log("is not logged in");
			}
			DealWithFBMenus(FB.IsLoggedIn);
		}
	}

	void DealWithFBMenus(bool isLoggedIn){
		if(isLoggedIn){
			login.SetActive(true);
			logout.SetActive(false);
			FB.API("/me?fields=first_name", HttpMethod.GET, DisplayUsername);
			FB.API("/me/friends", HttpMethod.GET, Friendname);
			FB.API("/me/picture?type=square&height=128&width=128", HttpMethod.GET, DisplayFoto);
		} else {
			login.SetActive(false);
			logout.SetActive(true);
		}


	}

	void Friendname(IResult result){

		print(result.ResultDictionary);

	}
	void DisplayFoto(IGraphResult result){
		if(result != null){
			Image fotoPerfil = foto.GetComponent<Image>();
			fotoPerfil.sprite = Sprite.Create(result.Texture, new Rect (0,0,128,128), new Vector2());
			
		}
	}
	void DisplayUsername(IResult result){
		Text UserName = userName.GetComponent<Text>();
		if(result.Error == null){
			UserName.text = "Hi there, " + result.ResultDictionary["first_name"];
		}else {
			Debug.Log(result.Error);
		}
	}





























}

