using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int score = 0;
    private Text scoreText;

    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreText.text = $"Artifacts collected: {score}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int updateValue)
    {
        score += updateValue;
        scoreText.text = $"Artifacts collected: {score}";
    }
}
