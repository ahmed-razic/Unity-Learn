using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CongratScript : MonoBehaviour
{
    public TextMesh Text;
    public ParticleSystem SparksParticles;

    [SerializeField] private List<string> TextToDisplay;
    [SerializeField] private float RotatingSpeed;
    [SerializeField] private float TimeToNextText;
    [SerializeField] private int CurrentText;

    // Start is called before the first frame update
    void Start()
    {
        TextToDisplay = new List<string>();
        TimeToNextText = 0.0f;
        CurrentText = 0;

        RotatingSpeed = 1.0f;

        TextToDisplay.Add("Congratulation");
        TextToDisplay.Add("All Errors Fixed");

        Text.text = TextToDisplay[0];
        SparksParticles.Play();
    }

    // Update is called once per frame
    void Update()
    {
        TimeToNextText += Time.deltaTime;
        Text.transform.Rotate(-GameObject.Find("Main Camera").transform.forward, RotatingSpeed);

        if (TimeToNextText > 1.5f)
        {
            TimeToNextText = 0.0f;

            if (CurrentText < TextToDisplay.Count)
            {
                Text.text = TextToDisplay[CurrentText];
                CurrentText++;
            }
            if (CurrentText == 2)
            {
                CurrentText = 0;
            }
        }
    }
}