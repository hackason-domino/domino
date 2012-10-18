using UnityEngine;
using System.Collections;

public class BallCtrl : MonoBehaviour
{
	// public variable
	// -----------------------------------------------------------------
	public	GameObject	m_hand;
	public	GameObject	m_ball;
	public	float		m_releaseTime	= 3.0f;
	// -----------------------------------------------------------------

	// private variable
	// -----------------------------------------------------------------
	private	float		m_stTime;
	private	bool		m_isRelease = false;
	// -----------------------------------------------------------------

	// public function
	// -----------------------------------------------------------------
	// -----------------------------------------------------------------

	// private function
	// -----------------------------------------------------------------
	private	void	AttachBallToHand()
	{
		// attach ball to hand;
		m_ball.transform.position	= m_hand.transform.position;
	}
	// -----------------------------------------------------------------
	
	// override function
	// -----------------------------------------------------------------
	void		Start()
	{
		m_stTime	= Time.realtimeSinceStartup;
	}
	
	void		Update()
	{		
		if (!m_isRelease) {
			AttachBallToHand();
			
			float elapse = Time.realtimeSinceStartup - m_stTime;
			if (elapse > m_releaseTime) {
				m_isRelease = true;
				
				// add force
				Vector3 dir = Vector3.forward;
				float mag = 3.0f;
				m_ball.rigidbody.AddForce(dir * mag, ForceMode.Impulse);
			}
		}
	}
	// -----------------------------------------------------------------
}
