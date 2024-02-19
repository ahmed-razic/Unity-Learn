using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    public Brick BrickPrefab;
    public int LineCount = 6;
    public Rigidbody Ball;

    public Text HighScoreText;
    public Text ScoreText;
    public GameObject GameOverText;

    private bool m_Started = false;
    private int m_Points;

    private bool m_GameOver = false;

    public string m_HighScoreName;
    private int m_HighScoreValue = 0;


    private void Awake()
    {
        m_HighScoreName = ScoreManager.Instance.playerName;
    }

    private void DisplayHighScore()
    {
        HighScoreText.text = $"Best Score: {m_HighScoreValue}, Name: {m_HighScoreName}";
    }

    // Start is called before the first frame update
    void Start()
    {

        LoadHighScore();
        DisplayHighScore();

        const float step = 0.6f;
        int perLine = Mathf.FloorToInt(4.0f / step);

        int[] pointCountArray = new[] { 1, 1, 2, 2, 5, 5 };
        for (int i = 0; i < LineCount; ++i)
        {
            for (int x = 0; x < perLine; ++x)
            {
                Vector3 position = new Vector3(-1.5f + step * x, 2.5f + i * 0.3f, 0);
                var brick = Instantiate(BrickPrefab, position, Quaternion.identity);
                brick.PointValue = pointCountArray[i];
                brick.onDestroyed.AddListener(AddPoint);
            }
        }
    }

    private void Update()
    {
        if (!m_Started)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                m_Started = true;
                float randomDirection = Random.Range(-1.0f, 1.0f);
                Vector3 forceDir = new Vector3(randomDirection, 1, 0);
                forceDir.Normalize();

                Ball.transform.SetParent(null);
                Ball.AddForce(forceDir * 2.0f, ForceMode.VelocityChange);
            }
        }
        else if (m_GameOver)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

    void AddPoint(int point)
    {
        m_Points += point;
        ScoreText.text = $"Score : {m_Points}";
    }

    public void GameOver()
    {
        m_GameOver = true;
        GameOverText.SetActive(true);
        if (m_Points > m_HighScoreValue)
        {
            SaveHighScore();
        }
    }

    [System.Serializable]
    public class SaveData
    {
        public string highScoreName;
        public int highScoreValue;
    }

    public void SaveHighScore()
    {
        SaveData data = new SaveData();
        data.highScoreName = ScoreManager.Instance.playerName;
        data.highScoreValue = m_Points;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/highscore.json", json);
    }

    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/highscore.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            m_HighScoreName = data.highScoreName;
            m_HighScoreValue = data.highScoreValue;
        }
    }
}
