using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pause : MonoBehaviour {
	public Image imagemShare;
	public Texture2D texAux;
	public Camera cameraPrint;
	public GameObject play;
	public GameObject popUp;
	public GameObject tempo;
	public Text tempoPause;
	public Text nomeFulanoPause;
	public Text nomeFulanoMenu;



	// Use this for initialization
	void Start () {
	
	}
	public static Texture2D TakeScreenshot(int width, int height, 
		Camera screenshotCamera) {
		if(width<=0 || height<=0) return null;
		if(screenshotCamera == null) screenshotCamera = Camera.main;

		Texture2D screenshot = new Texture2D(width, height, TextureFormat.RGB24, false);
		RenderTexture renderTex = new RenderTexture(width, height, 24);
		screenshotCamera.targetTexture = renderTex;
		screenshotCamera.Render();
		RenderTexture.active = renderTex;
		screenshot.ReadPixels(new Rect(0, 0, width, height), 0, 0);
		screenshot.Apply(true);
		screenshotCamera.targetTexture = null;
		RenderTexture.active = null;
		Destroy(renderTex);
		return screenshot;
	}
	public void Parar(){
		texAux = TakeScreenshot(100, 100, cameraPrint);
		imagemShare.sprite = Sprite.Create(texAux,  new Rect (0, 0, 100, 100), new Vector2 (0.5f, 0.5f));
		play.GetComponent<Play>().contando = false;
		popUp.SetActive(true);
		tempo.SetActive(false);
		tempoPause.text = tempo.GetComponent<Text>().text;
		nomeFulanoPause.text = nomeFulanoMenu.text;


	}
	// Update is called once per frame
	void Update () {
	
	}
}
