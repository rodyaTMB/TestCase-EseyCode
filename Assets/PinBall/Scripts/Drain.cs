using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class Drain : MonoBehaviour
{

	[SerializeField] private Transform spawnTransfrom;
	[SerializeField] private GameObject ballPrefab;

	private BoxCollider trigger;

	private void Awake()
	{
		trigger = GetComponent<BoxCollider>();
		trigger.isTrigger = true;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.GetComponent<Ball>() && GameManager.BallCount > 0)
		{
			if (GameManager.BallCount > 0)
			{
				GameManager.BallCount -= 1;
				Instantiate(ballPrefab, spawnTransfrom.position, Quaternion.identity);
			}
			else
			{
				GameManager.GlobalGameOver.Invoke();
			}
		}
		Destroy(other.gameObject);
	}

}
