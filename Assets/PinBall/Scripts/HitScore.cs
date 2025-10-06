using UnityEngine;

public class HitScore : MonoBehaviour
{
	[SerializeField] private int scorePerHit;
	private void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.GetComponent<Ball>())
		{
			GameManager.Score += scorePerHit;
			GameManager.GlobalAddScore.Invoke();
		}
	}
}
