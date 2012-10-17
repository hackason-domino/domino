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
		screenPosition.z = Camera.main.transform.position.y;
		transform.position = Camera.main.ScreenToWorldPoint(screenPosition);
		
		if(Input.GetMouseButtonDown(0))
		{
			var pos = transform.position;
			pos.y = 1;
			Instantiate(dominoPrefab,transform.position, transform.rotation);
		}
		
	}
}
