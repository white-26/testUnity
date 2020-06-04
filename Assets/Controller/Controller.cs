using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller
{
    Player PlayerModel;
    PlayerView currentView;

    public Controller()
    {
        //初始化Model数据
        PlayerModel = new Player();
        currentView = new PlayerView();
        //给Model事件添加函数，此函数功能是修改视图显示
        PlayerModel.HpChange += UpdateLabel;

        //初始化View
        currentView = GameObject.Find("MainView").GetComponent<PlayerView>();
        //点击按钮触发
        currentView.OnClick += (s, e) =>
        {
            PlayerModel.HP = 50;
        };
    }

    public void UpdateLabel(object sender, EventArgs args)
    {
        currentView.Text = PlayerModel.HP.ToString();
    }
}
