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

    [SerializeField] private TMP_Text scoreUIGameOver;
    [Space]
    [SerializeField] private TMP_Text scoreUIMain;
    [SerializeField] private TMP_Text ballCountUI;

	private void Awake()
	{
		RebutParametrs();

		UpdateScoreUI();
        UpdateBallCount();


		GlobalAddScore.AddListener(UpdateScoreUI);
		GlobalLoseBall.AddListener(UpdateBallCount);
	}

	private void UpdateScoreUI()
    {
        scoreUIMain.text = $"Score: {Score}";
		scoreUIGameOver.text = $"Score: {Score}";
    }
	private void UpdateBallCount()
    {
		ballCountUI.text = $"Balls: {BallCount}";
    }

    private void RebutParametrs()
    {
        BallCount = 3;
        Score = 0;
	}

}
