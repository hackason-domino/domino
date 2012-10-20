using UnityEngine;
using System.Collections;

public class ColorCtrl : MonoBehaviour {

	private	float	m_colorValue	= 1.0f;
	private	int		m_frame			= 0;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		int FRAME = 150;	// interval
		
		m_colorValue	= Mathf.Abs( Mathf.Sin ((float)m_frame / FRAME * 3.14f * 2.0f) );
		
		// apply color
		renderer.material.color	= new Color(m_colorValue, m_colorValue, m_colorValue);
		
		m_frame++;
		if (m_frame > FRAME) {
			m_frame = 0;
		}
	}
}
