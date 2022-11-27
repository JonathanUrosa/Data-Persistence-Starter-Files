using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/NameUser")]
public class User : ScriptableObject
{
    public string Name { get; private set; }
    public int Score { get; private set; }

    public void ChangeName(string _name)
    {
        Name = _name;
    }
    public void ChangeScore(int _score)
    {
        Score = _score;
    }
    public void Reset()
    {
        Score = 0;
        Name = string.Empty;
    }
}
