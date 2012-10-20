using UnityEngine;
using System.Collections;

public class EndDomino : MonoBehaviour {
	
	public Transform sakura;
	
	public int offset_x = 40;
	public int offset_y = 26;
	public int fontSize	= 50;
	
	
	private GUIStyle style;
	private bool bClear = false;
	// Use this for initialization
	void Start () {
		style = new GUIStyle();
		style.fontSize = fontSize;	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision colli)
	{
		if(colli.gameObject.name == "DominoStart"
		|| colli.gameObject.name == "Domino"
		|| colli.gameObject.name == "Domino(Clone)")
		{
			bClear = true;
		}
	}
	void OnGUI()
	{
		if(bClear == true)
		{
			GUI.Label(new Rect(Screen.width/2 - offset_x, Screen.height/2 - offset_y, 400, 300), "Clear!!", style);
			
			if (!sakura.gameObject.active)
				sakura.gameObject.active = true;
		}
	}
}
