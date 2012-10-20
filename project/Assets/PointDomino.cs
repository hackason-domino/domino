using UnityEngine;
using System.Collections;

public class PointDomino : MonoBehaviour {
	
	
	public Transform dominoPrefab;
	
	public Color gGolor;
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		//var screenPosition = Input.mousePosition;
		//screenPosition.z = Camera.main.transform.position.y;

//Camera.main.ScreenPointToRay		
		
		var hit = new RaycastHit();
		var ray = Camera.main.ScreenPointToRay(Input.mousePosition);		
		if (Physics.Raycast(ray, out hit))
		{
			transform.position = new Vector3(hit.point.x, 3.0f, hit.point.z);
			if (Input.GetButtonDown("Fire1"))
			{
				var obj = Instantiate(dominoPrefab, transform.position, transform.rotation) as GameObject;
				obj.name = "Domino";
				
				//DominoManager.DominoItem item = new DominoManager.DominoItem();
				//item.GameObject = obj;
				//DominoManager.Domino.Items.Add(item);
				
				//Debug.Log(obj);
			}
		}
			
/*		
		
		var wpos = Camera.main.ScreenToWorldPoint(screenPosition);
		wpos.y = 3;
		transform.position = wpos;
		*/
		//
		//if(Input.GetMouseButtonDown(0))
		//{
			//Instantiate(dominoPrefab,transform.position, transform.rotation);
		//}
	}
	
	void OnGUI()
	{
		//var rColor = GUI.TextField (new Rect (16, 16, 50, 16), "10");
		//var gColor = GUI.TextField (new Rect (16, 32, 50, 16), "10");
		//var bColor = GUI.TextField (new Rect (16, 48, 50, 16), "B");
		//gGolor.r = int.Parse(rColor); 
		//gGolor.g = int.Parse(gColor); 
		//gGolor.b = int.Parse(bColor); 
		
	}
}
