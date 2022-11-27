using TMPro;
using UnityEngine;

public class HighestScoreCanvas : MonoBehaviour
{
    [SerializeField] HighestScoreChannel highestScoreChannel;
    [SerializeField] TextMeshProUGUI textScore;
    [SerializeField] TextMeshProUGUI textName;

    private void OnEnable()
    {
        highestScoreChannel.OnEventHighestScore += ListenerHighestScore;
    }
    private void OnDisable()
    {
        highestScoreChannel.OnEventHighestScore += ListenerHighestScore;
    }
    public void ListenerHighestScore(string _name, int _score)
    {
        Debug.Log(_score);
        textScore.text = _score.ToString();
        textName.text = _name;
    }
}
