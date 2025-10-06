using UnityEngine;

public class PlayerController : MonoBehaviour
{
	[SerializeField] private Animator LeftFlipper;
	[SerializeField] private Animator RightFlipper;

	[SerializeField] private Animator Plunger;

	private void Update()
	{
		FlipperController();
		PlungerController();
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

	private void PlungerController()
	{
		AnimatorStateInfo stateInfo = Plunger.GetCurrentAnimatorStateInfo(0);

		if (Input.GetKey(KeyCode.Space))
		{
			if (stateInfo.normalizedTime < 0)
			{
				Plunger.SetFloat("Power", 0);
			}
			else
			{
				Plunger.SetFloat("Power", -1);
			}
		}
		else
		{

			if (stateInfo.normalizedTime > 1)
			{
				Plunger.SetFloat("Power", 0);
			}
			else
			{
				Plunger.SetFloat("Power", 1);
			}
		}
	}
}
