using UnityEngine;
using System.Collections;


[ExecuteInEditMode]
public class Title : MonoBehaviour {

	public GUISkin gSkin_title;

	public Texture2D titleback;

	private bool isLoading;

	void OnGUI ()
	{
		if (gSkin_title)
			GUI.skin = gSkin_title;
		else
			Debug.Log ("DOMINO: No GUI skin has been set!");
		
		GUIStyle backgroundStyle = new GUIStyle ();
		backgroundStyle.normal.background = titleback;
		GUI.Label (new Rect ((Screen.width - (Screen.height * 2)) * 0.75f, 0, Screen.height * 2, Screen.height), "", backgroundStyle);
		GUI.Label (new Rect ((Screen.width / 2) - 197, 50, 400, 100), "Master of DOMINO", "mainMenuTitle");
		
		
		if (GUI.Button (new Rect ((Screen.width / 2) - 70, Screen.height - 160, 140, 70), "Play")) {//Label
			isLoading = true;
			Application.LoadLevel ("menu");//name of scene
		}
		
		bool isWebPlayer = (Application.platform == RuntimePlatform.OSXWebPlayer || Application.platform == RuntimePlatform.WindowsWebPlayer);
		if (!isWebPlayer) {
			if (GUI.Button (new Rect ((Screen.width / 2) - 70, Screen.height - 80, 140, 70), "Quit")){//Label
				isLoading=false;
				
				Debug.Log ("DOMINO_Title: Goodbye!");
				
				GUI.Label (new Rect ((Screen.width / 2) - 110, (Screen.height / 2) + 30, 400, 70),
			           "Goodbye", "mainMenuTitle");// error
				Application.Quit ();
			}
		}
		
		
		if (isLoading)
			GUI.Label (new Rect ((Screen.width / 2) - 110, (Screen.height / 2) - 60, 400, 70),
			           "Loading...", "mainMenuTitle");
		
	}
	
}
