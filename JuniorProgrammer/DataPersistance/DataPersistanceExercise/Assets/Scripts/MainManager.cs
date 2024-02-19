using System.Collections;
using System.Collections.Generic;
using System.IO;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    public Brick BrickPrefab;
    public int LineCount = 6;
    public Rigidbody Ball;

    public Text ScoreText;
    public GameObject GameOverText;
    public Text HighScoreText;
    
    private bool m_Started = false;
    private int m_Points;
    public string m_HighScoreName;
    public int m_HighScoreValue;
    
    private bool m_GameOver = false;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadHighScore();        
    }

    public void SetHighScoreName(string inputName)
    {
        m_HighScoreName = inputName;
    }

    // Start is called before the first frame update
    void Start()
    {
        HighScoreText.text = $"Best Score : {m_HighScoreValue}  Name: {m_HighScoreName}";
        const float step = 0.6f;
        int perLine = Mathf.FloorToInt(4.0f / step);
        
        int[] pointCountArray = new [] {1,1,2,2,5,5};
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
        SaveHighScore();
        m_GameOver = true;
        GameOverText.SetActive(true);
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
        data.highScoreName = m_HighScoreName;
        data.highScoreValue = m_HighScoreValue;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/Highscore.json", json);
    }

    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/Highscore.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            m_HighScoreName = data.highScoreName;
            m_HighScoreValue = data.highScoreValue;
        }
    }
}
