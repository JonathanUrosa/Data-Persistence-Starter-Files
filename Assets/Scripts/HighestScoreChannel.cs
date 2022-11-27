using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "ScriptableObjects/HighestScoreChannel")]
public class HighestScoreChannel : ScriptableObject
{
    public UnityAction<string, int> OnEventNewScore { get; set; }
    public UnityAction<string, int> OnEventHighestScore { get; set; }

    public void InvokeHighestScore(string _name, int _score)
    {
        OnEventHighestScore?.Invoke(_name, _score);
    }
    public void InvokeNewScore(string _name, int _score)
    {
        OnEventNewScore?.Invoke(_name, _score);
    }
}
