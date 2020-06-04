using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class Model : MonoBehaviour
//{
    public class Player
    {
        private int hp;

        public int HP {
            get { return hp; }
            set {
                hp += value;
                if (HpChange != null)
                {
                    HpChange(this, new EventArgs());
                }
            }
        }

        //当玩家的血量进行更新的时候，界面应该发生变化
        //最传统的方式，全部写到一起，获取玩家player组件，组件里面的hp--。

        //定义一个事件，当血量变化的时候触发该事件
        public event EventHandler HpChange;
    }
//}
