using UnityEngine;

public class PlayerController : MonoBehaviour
{
	[SerializeField] private Animator LeftFlipper;
	[SerializeField] private Animator RightFlipper;

	private void Update()
	{
		FlipperController();
	}

	private void FlipperController()
	{
		if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
		{
			LeftFlipper.SetTrigger("Push");
		}
		else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
		{
			RightFlipper.SetTrigger("Push");
		}

	}
}
