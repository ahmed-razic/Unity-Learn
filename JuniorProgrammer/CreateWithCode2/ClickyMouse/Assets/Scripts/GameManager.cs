using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    private float spawnTime = 3f;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public Canvas titleScreen;

    private int score = 0;
    public bool isGameActive;

    public Button restartButton;

    public void StartGame(int difficulty)
    {
        titleScreen.gameObject.SetActive(false);
        isGameActive = true;
        spawnTime /= difficulty;
        StartCoroutine(SpawnTargets());
        UpdateScore(0);
    }

    IEnumerator SpawnTargets()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnTime);
            int randomIndex = Random.Range(0, targets.Count);
            Instantiate(targets[randomIndex]);
        }
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Clicky Mouse");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
    }
}
