using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LibraryButton : MonoBehaviour 
{
	public GameObject button;
	public GameObject panel;

	public Text	text;

	public bool ifLibOpened = false;
	// Use this for initialization
	public void but()
	{
		if (!ifLibOpened) {
			panel.SetActive (true);
			text.text = "Leave";
			ifLibOpened = true;
			button.SetActive(false);
			button.SetActive(true);
		} 
		else 
		{
			panel.SetActive (false);
			text.text = "Library";
			ifLibOpened = false;
		}
	}

	void Start () 
	{
		button = GameObject.Find ("LibraryButton");
		panel = GameObject.Find ("LibraryPanel");

		text = GameObject.Find ("LibButText").GetComponent<Text> ();

		button.SetActive (true);
		text.text = "Library";
		panel.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
