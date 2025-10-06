using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
	[SerializeField] private Button pause;
	[SerializeField] private Button restart;
	[SerializeField] private Button resum;
	[SerializeField] private Button exit;
	[Space]
	[SerializeField] private Button exitGameOver;
	[SerializeField] private Button restartGameOver;

	[SerializeField] GameObject pausePanel;
	[SerializeField] GameObject gameOverPanel;

	private bool isPause;

	private void Awake()
	{
		pause.onClick.AddListener(PauseGame);
		restart.onClick.AddListener(RestartGame);
		resum.onClick.AddListener(PauseGame);
		exit.onClick.AddListener(QuitGame);

		exitGameOver.onClick.AddListener(QuitGame);
		restartGameOver.onClick.AddListener(RestartGame);

		GameManager.GlobalGameOver.AddListener(GameOver);
	}

	private void RestartGame()
	{
		int sceneID = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(sceneID);
		Time.timeScale = 1.0f;
	}

	private void QuitGame()
	{
		Application.Quit();
	}

	private void PauseGame()
	{		
		if (!isPause)
		{
			Time.timeScale = 0;
			isPause = true;
			pausePanel.SetActive(true);
		}
		else
		{
			Time.timeScale = 1;
			isPause = false;
			pausePanel.SetActive(false);
		}
	}
	private void GameOver()
	{
		gameOverPanel.SetActive(true);
		Time.timeScale = 0f;
	}
}
