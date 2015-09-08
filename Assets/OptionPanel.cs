using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OptionPanel : MonoBehaviour 
{
	public GameObject panel;
	public GameObject optOne;
	public GameObject optTwo;
	public GameObject optThree;
	public GameObject optFour;
	public GameObject optFive;

	public RectTransform box;
	public RectTransform butOne;
	public RectTransform butTwo;
	public RectTransform butThree;
	public RectTransform butFour;
	public RectTransform butFive;

	public Text textOne;
	public Text textTwo;
	public Text textThree;
	public Text textFour;
	public Text textFive;

	public int opt=0;
	public float mid;
	// Use this for initialization

	public void InitOption(int num, string [] texts)
	{
		float top;

		if (num <= 0)
			return;

		panel.SetActive (true);
		box.sizeDelta=new Vector2(box.sizeDelta.x, 50*num);
		top = mid + num * 25 - 25;
		opt = 0;

		optOne.SetActive (true);
		butOne.position = new Vector3 (butOne.position.x, top, butOne.position.z);
		textOne.text = texts [0];

		if (num == 1)
			return;

		optTwo.SetActive (true);
		butTwo.position = new Vector3 (butTwo.position.x, top - 50, butTwo.position.z);
		textTwo.text = texts [1];

		if (num == 2)
			return;

		optThree.SetActive (true);
		butThree.position = new Vector3 (butThree.position.x, top - 100, butThree.position.z);
		textThree.text = texts [2];

		if (num == 3)
			return;

		optFour.SetActive (true);
		butFour.position = new Vector3 (butFour.position.x, top - 150, butFour.position.z);
		textFour.text = texts [3];

		if (num == 4)
			return;

		optFive.SetActive (true);
		butFive.position = new Vector3 (butFive.position.x, top - 200, butFive.position.z);
		textFive.text = texts [4];

		if (num >= 5)
			return;
	}

	public void ClearOption()
	{
		panel.SetActive (false);
		optOne.SetActive (false);
		optTwo.SetActive (false);
		optThree.SetActive (false);
		optFour.SetActive (false);
		optFive.SetActive (false);
		
		box.sizeDelta=new Vector2(box.sizeDelta.x, 50);
		butOne.position = new Vector3 (butOne.position.x, mid, butOne.position.z);
		butTwo.position = new Vector3 (butTwo.position.x, mid, butTwo.position.z);
		butThree.position = new Vector3 (butThree.position.x, mid, butThree.position.z);
		butFour.position = new Vector3 (butFour.position.x, mid, butFour.position.z);
		butFive.position = new Vector3 (butFive.position.x, mid, butFive.position.z);
		
		textOne.text = "";
		textTwo.text = "";
		textThree.text = "";
		textFour.text = "";
		textFive.text = "";
	}

	public void ButOne()
	{
		opt = 1;
		ClearOption ();
	}

	public void ButTwo()
	{
		opt = 2;
		ClearOption ();
	}

	public void ButThree()
	{
		opt = 3;
		ClearOption ();
	}

	public void ButFour()
	{
		opt = 4;
		ClearOption ();
	}

	public void ButFive()
	{
		opt = 5;
		ClearOption ();
	}


	void Start () 
	{
		string[] abc=new string[5]{"a", "b", "c", "d", "e"};
		panel = GameObject.Find ("OptionPanel");
		optOne = GameObject.Find ("OptionOne");
		optTwo = GameObject.Find ("OptionTwo");
		optThree = GameObject.Find ("OptionThree");
		optFour = GameObject.Find ("OptionFour");
		optFive = GameObject.Find ("OptionFive");

		box = panel.GetComponent<RectTransform> ();
		butOne = optOne.GetComponent<RectTransform> ();
		butTwo = optTwo.GetComponent<RectTransform> ();
		butThree = optThree.GetComponent<RectTransform> ();
		butFour = optFour.GetComponent<RectTransform> ();
		butFive = optFive.GetComponent<RectTransform> ();

		textOne = GameObject.Find ("OptOneText").GetComponent<Text> ();
		textTwo = GameObject.Find ("OptTwoText").GetComponent<Text> ();
		textThree = GameObject.Find ("OptThreeText").GetComponent<Text> ();
		textFour = GameObject.Find ("OptFourText").GetComponent<Text> ();
		textFive = GameObject.Find ("OptFiveText").GetComponent<Text> ();

		mid = box.position.y;
		ClearOption ();

		InitOption (5, abc);
		//ClearOption ();
		//InitOption (3, abc);
	}
	
	// Update is called once per frame
	void Update () 
	{
	}
}
