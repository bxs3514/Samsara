using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogPanel : MonoBehaviour 
{
	public bool ifopened = false;
	public bool iftext = false;

	public GameObject panel;
	public GameObject speaker;
	public GameObject text;

	public Text speakerText;
	public Text textText;

	public int Length = 0;
	// Use this for initialization
	
	void Start () 
	{
		panel = GameObject.Find ("DialogPanel");
		speaker = GameObject.Find ("SpeakerDialogPanel");
		text = GameObject.Find ("TextDialogPanel");

		speakerText = speaker.GetComponent <Text> ();
		textText = text.GetComponent <Text> ();

		panel.SetActive (false);
		speakerText.text="";
		textText.text="";
	}

	public void InitPanel()
	{
		panel.SetActive (true);

		ifopened = true;
	}

	public void DisplayText(string speakerString, string textString)
	{
		speakerText.text = speakerString;
		textText.text = textString;
		Length = textString.Length;
	}

	public void ClearText()
	{
		speakerText.text = "";
		textText.text = "";
		Length = 0;
	}

	public void ClosePanel()
	{
		panel.SetActive (false);

		ifopened = false;
	}
	// Update is called once per frame

	void Update () 
	{
	}
}
