using Mono.Cecil.Cil;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SocialPlatforms.Impl;

public class HighestScore : MonoBehaviour
{
    [SerializeField] HighestScoreChannel highestScoreChannel;
    readonly string KeyHighestScore = "HighestScore";
    readonly string KeyUser = "User";
    public int Score {get; private set;}
    public string NameUser { get; private set; }
    private void Start()
    {
        Debug.Log(Load());
    }
    private void OnEnable()
    {
        highestScoreChannel.OnEventNewScore += ListenerNewScore;
    }

    private void OnDisable()
    {
        highestScoreChannel.OnEventNewScore += ListenerNewScore;
    }
    private void ListenerNewScore(string arg0, int arg1)
    {
        if (arg1 >= Score)
        {
            Score = arg1;
            NameUser = arg0;
            highestScoreChannel.InvokeHighestScore(NameUser, Score);
            Save();
        }
    }
    public bool Load()
    {
        if (PlayerPrefs.HasKey(KeyHighestScore))
        {
            Score = PlayerPrefs.GetInt(KeyHighestScore);
            NameUser = PlayerPrefs.GetString(KeyUser);
            highestScoreChannel.InvokeHighestScore(NameUser, Score);
            return true;
        }
        else
        {
            return false;
        }
    }
    public void Save()
    {
        PlayerPrefs.SetInt(KeyHighestScore, Score);
        PlayerPrefs.SetString(KeyUser, NameUser);
    }
}
