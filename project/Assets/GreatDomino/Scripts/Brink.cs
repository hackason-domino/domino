using UnityEngine;
using System.Collections;

public class Brink : MonoBehaviour {
	
	
	private Material		 m_matStone		= null;
	public float			 m_fAlpha		= 1.0f;
	public float			 m_fAlphaMin	= 0.0f;
	public float			 m_fAlphaMax	= 1.0f;
	
	// Use this for initialization
	void Start () {
//		GameObject goTemp = GameObject.Find ()
		m_matStone	= renderer.material;
	}
	
	// Update is called once per frame
	void Update () {
		m_fAlpha += Time.deltaTime;
		m_fAlpha	= Mathf.Clamp( m_fAlpha %m_fAlphaMax, 0.0f, (m_fAlphaMax));
		float fTemp = ((1.0f -(m_fAlpha /m_fAlphaMax)) *(1.0f -m_fAlphaMin)) +m_fAlphaMin;
		m_matStone.color= new Color( 1.0f, 1.0f, 1.0f, fTemp);
	}
}
