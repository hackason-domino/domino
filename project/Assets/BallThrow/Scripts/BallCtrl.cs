using UnityEngine;
using System.Collections;

public class BallCtrl : MonoBehaviour
{
	// public variable
	// -----------------------------------------------------------------
	public	Transform	m_hand;
	public	Transform	m_ball;
	public	float		m_releaseTime		= 3.0f;
	public	float		m_throwMagnitude	= 5.0f;
	
	public	float		m_gravity			= 10.0f;
	public	float		m_speedY			= 0.0f;
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
				m_ball.rigidbody.AddForce(dir * m_throwMagnitude, ForceMode.Impulse);
			}
		} else {
			m_speedY	+= m_gravity;
			Vector3 pos = transform.position;
			transform.position	= new Vector3(pos.x, pos.y - m_speedY, pos.z);
		}
	}
	// -----------------------------------------------------------------
}
