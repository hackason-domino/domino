using UnityEngine;
using System.Collections;

public class EndDomino : MonoBehaviour {
	
	private GUIStyle style;
	private bool bClear = false;
	// Use this for initialization
	void Start () {
		style = new GUIStyle();
		style.fontSize = 30;	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision colli)
	{
		if(colli.gameObject.name == "Domino")
		{
			bClear = true;
		}
	}
	void OnGUI()
	{
		if(bClear == true)
		{
			GUI.Label(new Rect(16,16, 400, 300), "Clear!!", style);
		}
	}
}
