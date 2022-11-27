using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveUser : MonoBehaviour
{
    [SerializeField] User user;


    private void OnEnable()
    {
        user.Reset();
    }
    public void SetName(string _name)
    {
        user.ChangeName(_name);
    }
}
