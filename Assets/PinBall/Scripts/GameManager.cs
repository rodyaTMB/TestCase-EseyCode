using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public static UnityEvent GlobalGameOver = new UnityEvent();
    public static UnityEvent GlobalAddScore = new UnityEvent();
    public static UnityEvent GlobalLoseBall = new UnityEvent();

    public static int BallCount = 3;
    public static int Score;

    [SerializeField] private TMP_Text scoreUI;
    [SerializeField] private TMP_Text ballCountUI;

	private void Awake()
	{
        UpdateScoreUI();
        UpdateBallCount();


		GlobalAddScore.AddListener(UpdateScoreUI);
		GlobalLoseBall.AddListener(UpdateBallCount);
	}

	private void UpdateScoreUI()
    {
        scoreUI.text = $"Score: {Score}";
    }
	private void UpdateBallCount()
    {
		ballCountUI.text = $"Balls: {BallCount}";
    }

}
