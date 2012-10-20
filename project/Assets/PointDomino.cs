using UnityEngine;
using System.Collections;

public class PointDomino : MonoBehaviour {
	
	
	public Transform dominoPrefab;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		var screenPosition = Input.mousePosition;
		screenPosition.z = Camera.main.transform.position.y;
		//
		var wpos = Camera.main.ScreenToWorldPoint(screenPosition);
		wpos.y = 3;
		transform.position = wpos;
		//
		if(Input.GetMouseButtonDown(0))
		{
			Instantiate(dominoPrefab,transform.position, transform.rotation);
		}
		
	}
}
