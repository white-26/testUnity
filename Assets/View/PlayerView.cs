using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerView : MonoBehaviour
{
    public Text hpText;//血量标签
    public Button addButton;//点击按钮触发血量变化
    public event EventHandler OnClick;
    private void Start()
    {
        addButton.onClick.AddListener(BtnClick);
    }

    void BtnClick() 
    {
        OnClick?.Invoke(this, new EventArgs());
    }

    public string Text 
    {
        get { return hpText.text; }
        set { hpText.text = value; }
    }
}
